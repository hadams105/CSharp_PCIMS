using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCIMS_Software.Models;
using PCIMS_Software.Services;

namespace PCIMS_Software.ControlTemplates
{
    public partial class LabReports_UserControl : UserControl
    {
        MainInvoiceForm mainInvoice;
        private LabReportHeaderObject reportHeaderObject;
        bool loading = true;

        private DataTable ReportsTable = new DataTable();

        public LabReports_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;            
        }

        private void LabReports_UserControl_Load(object sender, EventArgs e)
        {
            DataTable customers = new DataTable();
            customers.Columns.Add("CustomerID");
            customers.Columns.Add("CompanyName");

            customers.Rows.Add();

            foreach (DataRow dr in CustomerService.GetAllCompanyNames().Rows)
            {
                customers.Rows.Add(dr.ItemArray);
            }

            labreports_client1.DisplayMember = "CompanyName";
            labreports_client1.ValueMember = "CustomerID";
            labreports_client1.DataSource = customers.Copy();

            labreports_client2.DisplayMember = "CompanyName";
            labreports_client2.ValueMember = "CustomerID";
            labreports_client2.DataSource = customers.Copy();

            labreports_client3.DisplayMember = "CompanyName";
            labreports_client3.ValueMember = "CustomerID";
            labreports_client3.DataSource = customers.Copy();

            labreports_client4.DisplayMember = "CompanyName";
            labreports_client4.ValueMember = "CustomerID";
            labreports_client4.DataSource = customers.Copy();

            reportHeaderObject = LabService.GetLabReportHeaderById(mainInvoice.GetWorkingJob().JobNbr);

            if (reportHeaderObject.LabNumber == null)
            {
                labreports_setheader_btn.Enabled = true;
            }
            else
            {
                FillForm(reportHeaderObject);
                labreports_setheader_btn.Text = "Save Header";
            }

            PopulateWorksheetsPanel();
            
            ReportsTable.Columns.Add("Test");
            ReportsTable.Columns.Add("Astm");
            ReportsTable.Columns.Add("Spec");
            ReportsTable.Columns.Add("Min");
            ReportsTable.Columns.Add("Max");
            ReportsTable.Columns.Add("Result");

            labreports_datagridview.DataSource = ReportsTable;

            loading = false;
        }

        private void labreports_setheader_btn_Click(object sender, EventArgs e)
        {
            LabReportHeaderObject reportHeaderObject = new LabReportHeaderObject();

            reportHeaderObject.JobNbr = mainInvoice.GetWorkingJob().JobNbr;
            reportHeaderObject.LabNumber = labreports_labnumber.Text;
            reportHeaderObject.ReportDate = labreports_reportdate_dtp.Value.Date;
            reportHeaderObject.SDA1 = labreports_sda1.Text;
            reportHeaderObject.SDA2 = labreports_sda2.Text;
            reportHeaderObject.IdMarks1 = labreports_idmarks1.Text;
            reportHeaderObject.IdMarks2 = labreports_idmarks2.Text;
            reportHeaderObject.IdMarks3 = labreports_idmarks3.Text;
            reportHeaderObject.IdMarks4 = labreports_idmarks4.Text;
            reportHeaderObject.Submitted1 = labreports_submitted1.Text;
            reportHeaderObject.Submitted2 = labreports_submitted2.Text;
            reportHeaderObject.Client1 = Convert.ToInt32((labreports_client1.SelectedValue != DBNull.Value) ? labreports_client1.SelectedValue : 0);
            reportHeaderObject.Client2 = Convert.ToInt32((labreports_client2.SelectedValue != DBNull.Value) ? labreports_client2.SelectedValue : 0);
            reportHeaderObject.Client3 = Convert.ToInt32((labreports_client3.SelectedValue != DBNull.Value) ? labreports_client3.SelectedValue : 0);
            reportHeaderObject.Client4 = Convert.ToInt32((labreports_client4.SelectedValue != DBNull.Value) ? labreports_client4.SelectedValue : 0);

            LabService.InsertLabReportHeader(reportHeaderObject);

            labreports_setheader_btn.Enabled = false;
            labreports_setheader_btn.Text = "Save Header";
        }

        private void FillForm(LabReportHeaderObject reportHeaderObject)
        {
            labreports_labnumber.Text = reportHeaderObject.LabNumber;
            labreports_reportdate_dtp.Value = reportHeaderObject.ReportDate;
            labreports_sda1.Text = reportHeaderObject.SDA1;
            labreports_sda2.Text = reportHeaderObject.SDA2;
            labreports_idmarks1.Text = reportHeaderObject.IdMarks1;
            labreports_idmarks2.Text = reportHeaderObject.IdMarks2;
            labreports_idmarks3.Text = reportHeaderObject.IdMarks3;
            labreports_idmarks4.Text = reportHeaderObject.IdMarks4;
            labreports_submitted1.Text = reportHeaderObject.Submitted1;
            labreports_submitted2.Text = reportHeaderObject.Submitted2;
            labreports_client1.SelectedIndex = reportHeaderObject.Client1;
            labreports_client2.SelectedIndex = reportHeaderObject.Client2;
            labreports_client3.SelectedIndex = reportHeaderObject.Client3;
            labreports_client4.SelectedIndex = reportHeaderObject.Client4;
        }

        private void labreports_FormChanged(object sender, EventArgs e)
        {
            if (!loading)
                labreports_setheader_btn.Enabled = true;
        }

        private void PopulateWorksheetsPanel()
        {
            List<int> worksheets = LabService.GetWorksheetsByJobNbr(mainInvoice.GetWorkingJob().JobNbr);

            foreach (int i in worksheets)
            {
                Label temp = new Label()
                {
                    Text = "Sample " + i,
                    Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline),
                    ForeColor = SystemColors.Highlight,
                    Margin = new Padding(5),
                    Name = i.ToString()
                };

                temp.DoubleClick += OpenATemplate;
                labreports__loadworksheet_panel.Controls.Add(temp);
            }
        }

        private void OpenATemplate(object sender, EventArgs e)
        {
            Label sndr = (Label)sender;

            int sheetNbr = Convert.ToInt32(sndr.Name);
            if (sheetNbr != 0)
                LoadTestData(sheetNbr);
        }

        private void LoadTestData(int sheetNbr)
        {
            ReportsTable.Clear();

            List<object[]> tests = LabService.GetWorksheetBySheetNbr(mainInvoice.GetWorkingJob().JobNbr, sheetNbr);

            if (tests != null)
            {
                foreach (object[] test in tests)
                {
                    object[] specs = LabService.GetLabSpecByCustomerIdAndTestId(mainInvoice.GetWorkingJob().CustomerId, Convert.ToInt32(test[1]));

                    object[] toAdd = { test[0], test[2], specs[1], specs[4], specs[5], test[4] };

                    ReportsTable.Rows.Add(toAdd);
                    
                    labreports_datagridview.DataSource = ReportsTable;
                    labreports_currentworksheet.Text = sheetNbr.ToString();
                }
            }

            CheckSpecs();
        }

        private void CheckSpecs()
        {
            foreach (DataGridViewRow row in labreports_datagridview.Rows)
            {
                string result_s = row.Cells["Result"].Value.ToString();
                bool result_blank = string.IsNullOrWhiteSpace(result_s);

                string min_s = row.Cells["Min"].Value.ToString();
                bool min_blank = string.IsNullOrWhiteSpace(min_s);

                string max_s = row.Cells["Max"].Value.ToString();
                bool max_blank = string.IsNullOrWhiteSpace(max_s);

                if (!result_blank)
                {
                    if (!min_blank || !max_blank)
                    {
                        float min = 0;
                        bool min_isNum = float.TryParse(row.Cells["Min"].Value.ToString(), out min);

                        float max = 0;
                        bool max_isNum = float.TryParse(row.Cells["Max"].Value.ToString(), out max);

                        float result = 0;
                        bool result_isNum = float.TryParse(row.Cells["Result"].Value.ToString(), out result);

                        if ((min_isNum || max_isNum) && result_isNum)
                        {
                            if (!min_isNum)
                            {
                                if (result > max)
                                    row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if (!max_isNum)
                            {
                                if (result < min)
                                    row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                if ((result < min) || (result > max))
                                    row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        else if ((!min_isNum || !max_isNum) && !result_isNum)
                        {
                            if (min_blank && !max_blank)
                            {
                                if (!max_s.ToLower().Equals(result_s.ToLower()))
                                    row.DefaultCellStyle.BackColor = Color.Red;
                            }
                            else if (max_blank && !min_blank)
                            {
                                if (!min_s.ToLower().Equals(result_s.ToLower()))
                                    row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        row.Cells["Min"].Value = "Min Spec Missing";
                        row.Cells["Max"].Value = "Max Spec Missing";
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
                else
                {
                    row.Cells["Result"].Value = "Result Missing";

                    if (min_blank && max_blank)
                    {
                        row.Cells["Min"].Value = "Min Spec Missing";
                        row.Cells["Max"].Value = "Max Spec Missing";
                    }

                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void labreports_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            labreports_datagridview.ClearSelection();
        }

        private void labreports_datagridview_Sorted(object sender, EventArgs e)
        {
            CheckSpecs();
        }
    }
}