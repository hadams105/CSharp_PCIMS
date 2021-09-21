using PCIMS_Software.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCIMS_Software.Forms
{
    public partial class PriceMaintenanceForm : Form
    {
        MainInvoiceForm mainInvoice;
        DataTable PriceTable = new DataTable();

        public PriceMaintenanceForm(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
        }

        private void PricesMaintenanceForm_Load(object sender, EventArgs e)
        {
            PriceTable.Columns.Add("ServiceCode", typeof(string));
            PriceTable.Columns.Add("ServiceDesc", typeof(string));
            PriceTable.Columns.Add("Amount", typeof(decimal));
            PriceTable.Columns.Add("MinCharge", typeof(decimal));

            pricemaintenance_datagridview.DataSource = PriceTable;

            pricemaintenance_datagridview.Columns[2].DefaultCellStyle.Format = "c";
            pricemaintenance_datagridview.Columns[3].DefaultCellStyle.Format = "c";

            LoadData();

            pricemaintenance_datagridview.ClearSelection();
            pricemaintenance_servicecode.Text = "";
            pricemaintenance_servicedesc.Text = "";
            pricemaintenance_actualcost_nud.Value = 1.00M;
            pricemaintenance_mincost_nud.Value = 0.00M;
        }
        
        private void LoadData()
        {
            PriceTable.Clear();

            List<object[]> prices = PriceService.GetAllPrices();

            foreach (object[] price in prices)
            {
                PriceTable.Rows.Add(price);
            }

            pricemaintenance_servicecode.Enabled = true;
            pricemaintenance_addedit_btn.Text = "Add";
            pricemaintenance_datagridview.ClearSelection();
        }

        private void pricemaintenance_addedit_btn_Click(object sender, EventArgs e)
        {
            if (pricemaintenance_servicecode.Text == null) MessageBox.Show("Please insert Service Code", "Error");
            if (pricemaintenance_servicedesc.Text == null) MessageBox.Show("Please insert Service Description", "Error");

            if (pricemaintenance_datagridview.SelectedRows.Count == 1)
                PriceService.UpdatePriceByServiceCode(
                        pricemaintenance_servicecode.Text,
                        pricemaintenance_servicedesc.Text,
                        pricemaintenance_actualcost_nud.Value,
                        pricemaintenance_mincost_nud.Value);
            
            else
                PriceService.InsertPrice(
                        pricemaintenance_servicecode.Text,
                        pricemaintenance_servicedesc.Text,
                        pricemaintenance_actualcost_nud.Value,
                        pricemaintenance_mincost_nud.Value);

            LoadData();
            pricemaintenance_datagridview.ClearSelection();
        }

        private void pricemaintenance_delete_btn_Click(object sender, EventArgs e)
        {
            if (pricemaintenance_datagridview.SelectedRows.Count == 1)
            {
                PriceService.DeletePriceByServiceCode(pricemaintenance_datagridview.CurrentRow.Cells[0].Value.ToString());

                LoadData();
            }
        }

        private void pricemaintenance_clear_btn_Click(object sender, EventArgs e)
        {
            PriceTable.Clear();
            LoadData();

            pricemaintenance_servicecode.Text = "";
            pricemaintenance_servicedesc.Text = "";
            pricemaintenance_actualcost_nud.Value = 1.00M;
            pricemaintenance_mincost_nud.Value = 0.00M;

            pricemaintenance_servicecode.Enabled = true;
            pricemaintenance_addedit_btn.Text = "Save";
        }

        private void pricemaintenance_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (pricemaintenance_datagridview.SelectedRows.Count == 1)
            {
                pricemaintenance_servicecode.Text = pricemaintenance_datagridview.CurrentRow.Cells[0].Value.ToString();
                pricemaintenance_servicecode.Enabled = false;
                pricemaintenance_servicedesc.Text = pricemaintenance_datagridview.CurrentRow.Cells[1].Value.ToString();
                pricemaintenance_actualcost_nud.Value = Convert.ToDecimal(pricemaintenance_datagridview.CurrentRow.Cells[2].Value);
                pricemaintenance_mincost_nud.Value = Convert.ToDecimal(pricemaintenance_datagridview.CurrentRow.Cells[3].Value);

                pricemaintenance_addedit_btn.Text = "Save";
            }
            else
            {
                pricemaintenance_servicecode.Text = "";
                pricemaintenance_servicedesc.Text = "";
                pricemaintenance_actualcost_nud.Value = 1.00M;
                pricemaintenance_mincost_nud.Value = 0.00M;

                pricemaintenance_servicecode.Enabled = true;
                pricemaintenance_addedit_btn.Text = "Add";
            }
        }
    }
}
