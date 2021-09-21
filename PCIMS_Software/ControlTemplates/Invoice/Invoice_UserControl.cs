using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCIMS_Software.ControlTemplates.Base;
using PCIMS_Software.Forms;
using PCIMS_Software.Services;
using PCIMS_Software.Models;

namespace PCIMS_Software.ControlTemplates.Invoice
{
	public partial class Invoice_UserControl : Base_UserControl
	{
        MainInvoiceForm mainInvoice;
        DataTable InvoiceTable = new DataTable();
        JobObject currentJob;

        public Invoice_UserControl(MainInvoiceForm mainInvoice)
		{
			InitializeComponent();
            this.mainInvoice = mainInvoice;
            currentJob = mainInvoice.GetWorkingJob();
		}

		private void Invoice_UserControl_Load(object sender, EventArgs e)
		{
            InvoiceTable.Columns.Add("JobNbr", typeof(int));
            InvoiceTable.Columns.Add("ServiceCode", typeof(string));
            InvoiceTable.Columns.Add("ServiceDescription", typeof(string));
            InvoiceTable.Columns.Add("Quantity", typeof(int));
            InvoiceTable.Columns.Add("Cost", typeof(decimal));
            InvoiceTable.Columns.Add("Total", typeof(decimal));

            invoice_datagridview.DataSource = InvoiceTable;
            
            InvoiceTable.Columns["ServiceCode"].ReadOnly = true;
            InvoiceTable.Columns["ServiceDescription"].ReadOnly = true;
            InvoiceTable.Columns["Cost"].ReadOnly = true;
            InvoiceTable.Columns["Total"].ReadOnly = true;

            invoice_datagridview.Columns[0].Visible = false;
            invoice_datagridview.Columns[4].DefaultCellStyle.Format = "c";
            invoice_datagridview.Columns[5].DefaultCellStyle.Format = "c";

            if(mainInvoice.GetWorkingJob() != null)
            {
                LoadData();

                invoice_number.Text = InvoiceService.GetInvoiceNumber(currentJob.JobNbr, currentJob.CustomerId, currentJob.OrderDateTime).ToString();
                invoice_jobdate.Value = Convert.ToDateTime(mainInvoice.GetWorkingJob().DateSampled);
                invoice_invoicedate.Enabled = true;
                invoice_add_btn.Enabled = true;
                invoice_save_btn.Enabled = true;
                invoice_delete_btn.Enabled = true;

                return;
            }

            invoice_number.Text = "Please Open a Job";
            invoice_add_btn.Enabled = false;
            invoice_save_btn.Enabled = false;
            invoice_delete_btn.Enabled = false;
            InvoiceTable.Clear();
        }

        private void LoadData()
        {
            InvoiceTable.Clear();

            List<object[]> invoiceRows = InvoiceService.GetInvoiceRowsByJobNumber(mainInvoice.GetWorkingJob().JobNbr);

            foreach (object[] row in invoiceRows)
            {
                InvoiceTable.Rows.Add(row);
            }
        }

		//private void invoice_addnotes_btn_Click(object sender, EventArgs e)
		//{
		//	if (!notesOpen)
		//	{
		//		invoice_datagridview.Size = TableSize_Full;
		//		invoice_notes.Visible = false;
		//		invoice_addnotes_btn.Text = "+ Notes";
		//		notesOpen = true;
		//	}
		//	else
		//	{
		//		invoice_datagridview.Size = TableSize_Comp;
		//		invoice_notes.Visible = true;
		//		invoice_addnotes_btn.Text = "- Notes";
		//		notesOpen = false;
		//	}
		//}

		private void MainInvoiceForm_Resize(object sender, EventArgs e)
		{
			//TableSize_Full = new Size(invoice_datagridview.Width, invoice_datagridview.Top - (invoice_datagridview.Height + invoice_notes.Height + 6));
			//TableSize_Comp = new Size(invoice_datagridview.Width, invoice_datagridview.Top - (invoice_datagridview.Height - (invoice_notes.Height + 6)));
		}

        private void invoice_add_btn_Click(object sender, EventArgs e)
        {
            PriceSelectForm form = new PriceSelectForm(this);
            form.Location = new Point(MousePosition.X, MousePosition.Y);
            form.Show();
        }

        public void AddPricesToTable(List<object[]> prices)
        {
            foreach (object[] price in prices)
            {
                object total = 0;
                if (int.TryParse(price[2].ToString(), out int r1))
                    total = r1;
                else if (decimal.TryParse(price[2].ToString(), out decimal r2))
                    total = r2;

                object[] adjusted = { mainInvoice.GetWorkingJob().JobNbr, price[0], price[1], 1, price[2], total };
                InvoiceTable.Rows.Add(adjusted);
            }
        }

        private object GetTotal(int price, int quantity)
        {
            return price * quantity;
        }

        private void invoice_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView) sender;
            DataGridViewCell cell = view.CurrentCell;

            if (cell != null)
            {
                if (cell.ColumnIndex == 3)
                {
                    DataGridViewRow row = invoice_datagridview.Rows[cell.RowIndex];

                    decimal.TryParse(row.Cells["Cost"].Value.ToString(), out decimal cost);
                    bool quantity_b = int.TryParse(cell.Value.ToString(), out int quantity);

                    if (quantity_b)
                    {
                        InvoiceTable.Columns["Total"].ReadOnly = false;
                        InvoiceTable.Rows[cell.RowIndex].SetField("Total", quantity * cost);
                        InvoiceTable.Columns["Total"].ReadOnly = true;
                    }
                    else
                        MessageBox.Show("Please insert valid quantity.", "Error");
                }
            }
        }

        private void invoice_save_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in invoice_datagridview.Rows)
            {
                InvoiceService.InsertUpdateInvoiceRow(mainInvoice.GetWorkingJob().JobNbr,
                                                      row.Cells["ServiceCode"].Value.ToString(),
                                                      row.Cells["ServiceDescription"].Value.ToString(),
                                                      Convert.ToInt32(row.Cells["Quantity"].Value),
                                                      Convert.ToDecimal(row.Cells["Cost"].Value),
                                                      Convert.ToDecimal(row.Cells["Total"].Value));
            }
        }

        private void invoice_delete_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in invoice_datagridview.SelectedRows)
            {
                InvoiceService.DeleteInvoiceRowByJobNbrAndServiceCode(mainInvoice.GetWorkingJob().JobNbr, row.Cells["ServiceCode"].Value.ToString());
            }

            LoadData();
        }
    }
}
