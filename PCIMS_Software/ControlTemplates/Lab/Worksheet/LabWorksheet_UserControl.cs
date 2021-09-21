using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCIMS_Software.Services;

namespace PCIMS_Software.ControlTemplates.Lab.Worksheet
{
    public partial class LabWorksheet_UserControl : UserControl
    {
        private MainInvoiceForm mainInvoice;
        private DataTable templateObjs;
        private DataTable WorksheetTable = new DataTable();
        private int currentTemplateId = 0;
        private int currentWorksheet = 1;
        private int maxSheet = 1;

        public LabWorksheet_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
        }

        private void LabWorksheet_UserControl_Load(object sender, EventArgs e)
        {
            DataTable tests = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);

            if (tests != null)
            { 
                foreach (DataRow row in tests.Rows)
                {
                    if (row.Field<short>("SheetNbr") > currentWorksheet)
                        maxSheet = row.Field<short>("SheetNbr");
                }
            }

            labworksheet_worksheettotalnbr.Text = "/" +  maxSheet.ToString();
            tests.Dispose();

            labworksheet_currentworksheet.Text = currentWorksheet.ToString();

            WorksheetTable.Columns.Add("DtlNbr");
            WorksheetTable.Columns.Add("JobNbr");
            WorksheetTable.Columns.Add("SheetNbr");
            WorksheetTable.Columns.Add("LineNbr");
            WorksheetTable.Columns.Add("Marked");
            WorksheetTable.Columns.Add("Re");
            WorksheetTable.Columns.Add("TemplateId");
            WorksheetTable.Columns.Add("TestId");
            WorksheetTable.Columns.Add("Test");
            WorksheetTable.Columns.Add("Astm");
            WorksheetTable.Columns.Add("CompBy");
            WorksheetTable.Columns.Add("ReleaseId");
            WorksheetTable.Columns.Add("Spec");
            WorksheetTable.Columns.Add("Fee");
            WorksheetTable.Columns.Add("Result");
            WorksheetTable.Columns.Add("Note");

            labworksheet_datagridview.DataSource = WorksheetTable;

            labworksheet_datagridview.Columns["DtlNbr"].Visible = false;
            labworksheet_datagridview.Columns["JobNbr"].Visible = false;
            labworksheet_datagridview.Columns["SheetNbr"].Visible = false;
            labworksheet_datagridview.Columns["LineNbr"].Visible = false;
            labworksheet_datagridview.Columns["TemplateId"].Visible = false;
            labworksheet_datagridview.Columns["TestId"].Visible = false;
            labworksheet_datagridview.Columns["Fee"].Visible = false;
                        
            LoadTemplatePanel();
        }

        private void LoadTemplatePanel()
        {
            templateObjs = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);
            List<int> templateIds = new List<int>();
            foreach (DataRow row in templateObjs.Rows)
                if(!templateIds.Contains(row.Field<int>("TemplateId")))
                    templateIds.Add(row.Field<int>("TemplateId"));

            List<string> templateNames = new List<string>();
            foreach (int id in templateIds)
                templateNames.Add(LabService.GetLabTemplateNameById(id));

            foreach(string name in templateNames)
            {
                    Label temp = new Label()
                    {
                    Text = name,
                    Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Underline),
                    ForeColor = SystemColors.Highlight,
                    Margin = new Padding(5),
                    Name = name
                };

                temp.DoubleClick += OpenATemplate;
                labworksheet_loadtemplate_panel.Controls.Add(temp);
            }
        }

        private void OpenATemplate(object sender, EventArgs e)
        {
            WorksheetTable.Clear();
            //ClearInputs();

            Label sndr = (Label)sender;

            currentTemplateId = FindTemplateIdByName(sndr.Name);
            labworksheet_current_template.Text = sndr.Name;

            if (currentTemplateId != 0)
                LoadTestData(currentTemplateId);

            labworksheet_datagridview.ClearSelection();
        }

        private int FindTemplateIdByName(string name)
        {
            try
            {
                DataTable templates = LabService.GetAllLabTemplateInfo();

                DataRow[] rows = templates.Select($"TemplateName = '{ name }'");

                templates.Dispose();

                return rows.First<DataRow>().Field<int>("TemplateId");
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        private void LoadTestData(int id)
        {
            WorksheetTable.Clear();

            DataTable tests = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);

            if (tests != null)
            {
                foreach (DataRow row in tests.Rows)
                {
                    if (row.Field<int>("TemplateId") == id && row.Field<short>("SheetNbr") == currentWorksheet)
                        WorksheetTable.Rows.Add(row.ItemArray);
                }

                labworksheet_datagridview.DataSource = WorksheetTable;
                tests.Dispose();

                labworksheet_currentworksheet.Text = currentWorksheet.ToString();
            }
        }

        private void labworksheet_save_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in labworksheet_datagridview.Rows)
            { 
                LabService.UpdateAssignedTestResultsById(mainInvoice.GetWorkingJob().JobNbr,
                                                         currentWorksheet,
                                                         Convert.ToInt32(row.Cells["TestId"].Value),
                                                         Convert.ToString(row.Cells["Result"].Value),
                                                         Convert.ToString(row.Cells["ReleaseId"].Value),
                                                         Convert.ToString(row.Cells["Marked"].Value),
                                                         Convert.ToString(row.Cells["CompBy"].Value));


                labworksheet_datagridview.ClearSelection();
            }

            if (currentTemplateId != 0)
                LoadTestData(currentTemplateId);
        }


        private void labworksheet_clearall_btn_Click(object sender, EventArgs e)
        {
            //ClearInputs();

            labworksheet_current_template.Text = "Please Load a Template";
            WorksheetTable.Clear();
        }

        private void labworksheet_clearinput_btn_Click(object sender, EventArgs e)
        {
            //ClearInputs();
            labworksheet_datagridview.ClearSelection();
        }

        private void ClearInputs()
        {
            //labworksheet_result.Text = "";
            //labworksheet_releaseId.Text = "";
            //labworksheet_marked.Text = "";
            //labworksheet_compBy.Text = "";
        }

        private void labworksheet_datagridview_Click(object sender, EventArgs e)
        {
            //DataGridView grid = (DataGridView)sender;

            //if (grid.CurrentRow != null)
            //{
            //    labworksheet_result.Text = Convert.ToString(labworksheet_datagridview.CurrentRow.Cells["Result"].Value);
            //    labworksheet_releaseId.Text = Convert.ToString(labworksheet_datagridview.CurrentRow.Cells["ReleaseId"].Value);
            //    labworksheet_marked.Text = Convert.ToString(labworksheet_datagridview.CurrentRow.Cells["Marked"].Value);
            //    labworksheet_compBy.Text = Convert.ToString(labworksheet_datagridview.CurrentRow.Cells["CompBy"].Value);
            //}
        }

        private void labworksheet_changeworksheetbtn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(labworksheet_currentworksheet.Text) > maxSheet)
            {
                MessageBox.Show("Sheet entered is out of bounds. Please select a sheet between 1 and " + maxSheet, "Error");
                return;
            }

            currentWorksheet = Convert.ToInt32((string.IsNullOrWhiteSpace(labworksheet_currentworksheet.Text)) ? "1" : labworksheet_currentworksheet.Text);

            LoadTestData(currentTemplateId);
        }
    }
}
