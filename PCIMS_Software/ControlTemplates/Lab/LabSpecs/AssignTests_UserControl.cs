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
using PCIMS_Software.Models;

namespace PCIMS_Software.ControlTemplates.Lab.LabSpecs
{
    public partial class AssignTests_UserControl : UserControl
    {
        private MainInvoiceForm mainInvoice;
        private DataTable templateDataTable = new DataTable();
        private DataTable appliedDataTable = new DataTable();
        private DataTable previewDataTable = new DataTable();

        public AssignTests_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
            FillLabTemplateTables();
        }

        private void AssignTests_UserControl_Load(object sender, EventArgs e)
        {
            labtemplates_datagridview.ClearSelection();
            labtemplates_appliedtests_datagridview.ClearSelection();
            previewDataTable.Clear();
            previewtemplate_datagridview.Columns["TestId"].Visible = false;
        }

        private void FillLabTemplateTables()
        {
            templateDataTable.Columns.Add("TemplateID", typeof(int));
            templateDataTable.Columns.Add("TemplateName", typeof(string));
            templateDataTable.Columns.Add("Re", typeof(string));

            appliedDataTable.Columns.Add("DtlNbr", typeof(int));
            appliedDataTable.Columns.Add("TemplateID", typeof(int));
            appliedDataTable.Columns.Add("TemplateName", typeof(string));
            appliedDataTable.Columns.Add("Re", typeof(string));

            previewDataTable.Columns.Add("TestId", typeof(int));
            previewDataTable.Columns.Add("TestDesc", typeof(string));
            previewDataTable.Columns.Add("Fee", typeof(double));
            previewDataTable.Columns.Add("ATSM", typeof(string));

            DataTable temp_DataTable = LabService.GetAllLabTemplateInfo().Copy();

            DataTable testIdList = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);

            //Template Ids
            List<int> appliedIds = new List<int>();

            foreach (DataRow id in testIdList.Rows)
            {
                appliedIds.Add(id.Field<int>("TemplateId"));
            }

            foreach (DataRow row in temp_DataTable.Rows)
            {
                if (testIdList != null)
                {
                    if (appliedIds.Contains(row.Field<int>("TemplateId")))
                    {
                        object[] rowToInsert = new object[4];

                        //add the templateId, templateName, and Re
                        rowToInsert[1] = row.Field<int>("TemplateId");
                        rowToInsert[2] = LabService.GetLabTemplateNameById(row.Field<int>("TemplateId"));
                        rowToInsert[3] = row.Field<string>("Re");

                        appliedDataTable.LoadDataRow(rowToInsert, true);
                    }
                    else
                    {
                        templateDataTable.LoadDataRow(row.ItemArray, true);
                    }
                }
                else
                {
                    templateDataTable.LoadDataRow(row.ItemArray, true);
                }
            }

            // Set the data sources to the DataTables   
            temp_DataTable.Dispose();
            labtemplates_datagridview.DataSource = templateDataTable;
            labtemplates_appliedtests_datagridview.DataSource = appliedDataTable;
            previewtemplate_datagridview.DataSource = previewDataTable;

            // Hide the ID columns
            labtemplates_datagridview.Columns["TemplateID"].Visible = false;
            labtemplates_appliedtests_datagridview.Columns["TemplateID"].Visible = false;
            labtemplates_appliedtests_datagridview.Columns["DtlNbr"].Visible = false;

            temp_DataTable.Dispose();
            testIdList.Dispose();
        }

        private void assigntests_addTo_btn_Click(object sender, EventArgs e)
        {
            if (labtemplates_datagridview.SelectedRows.Count >= 1)
            {
                appliedDataTable.Clear();

                foreach (DataGridViewRow row in labtemplates_datagridview.SelectedRows)
                {
                    List<object> values = new List<object>();

                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value);

                    // Get a list of tests for the template
                    List<int> testIds = LabService.GetAllTemplateLabFeesById(Convert.ToInt32(row.Cells["TemplateId"].Value));
                    
                    for (int i = 0; i < mainInvoice.GetWorkingJob().SampleQty; i++)
                    {
                        // Create and insert tests 
                        foreach (int id in testIds)
                        {
                            // Create the test object
                            AppliedTestObject obj = new AppliedTestObject();

                            DataTable test = LabService.GetLabFeesInfoById(id);

                            obj.JobNbr = mainInvoice.GetWorkingJob().JobNbr;
                            obj.Re = row.Cells["Re"].Value.ToString();
                            obj.TemplateId = Convert.ToInt32(row.Cells["TemplateId"].Value);
                            obj.TestId = Convert.ToInt32(test.Rows[0]["TestId"].ToString());
                            obj.Test = test.Rows[0]["TestDesc"].ToString();
                            obj.Fee = Convert.ToDouble(test.Rows[0]["Fee"]);
                            obj.Astm = test.Rows[0]["ASTM"].ToString();
                            obj.SheetNbr = i + 1;

                            LabService.InsertAppliedTest(obj);
                        }
                    }

                    List<int> tests = LabService.GetAllTemplateLabFeesById(Convert.ToInt32(row.Cells["TemplateId"].Value));
                    tests = tests.Distinct<int>().ToList();

                    foreach (int id in tests)
                    {
                        DataTable test = LabService.GetLabFeesInfoById(id);

                        LabService.InsertLabSpec(test.Rows[0]["TestDesc"].ToString(), 
                                                 mainInvoice.GetWorkingJob().CustomerId, 
                                                 "",
                                                 Convert.ToInt32(test.Rows[0]["TestId"].ToString()),
                                                 test.Rows[0]["ASTM"].ToString(),
                                                 "",
                                                 "");
                    }

                    string query = $"TemplateId = '{Convert.ToInt32(row.Cells["TemplateId"].Value)}'";
                    templateDataTable.Rows.Remove(templateDataTable.Select(query).First());

                    DataTable testIdList = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);

                    List<int> alreadyAdded = new List<int>();

                    foreach (DataRow row2 in testIdList.Rows)
                    {
                        if (!alreadyAdded.Contains(row2.Field<int>("TemplateId")))
                        {
                            object[] rowToInsert = new object[4];

                            //add the templateId, templateName, sampleId and Re
                            rowToInsert[1] = row2.Field<int>("TemplateId");
                            rowToInsert[2] = LabService.GetLabTemplateNameById(row2.Field<int>("TemplateId"));
                            rowToInsert[3] = row2.Field<string>("Re");

                            alreadyAdded.Add(row2.Field<int>("TemplateId"));

                            appliedDataTable.LoadDataRow(rowToInsert, true);
                        }
                    }
                }
            }
            labtemplates_datagridview.ClearSelection();
        }

        private void assigntests_removeFrom_btn_Click(object sender, EventArgs e)
        {
            if (labtemplates_appliedtests_datagridview.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow row in labtemplates_appliedtests_datagridview.SelectedRows)
                {
                    List<object> values = new List<object>();

                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value);

                    values.RemoveAt(0);
                    templateDataTable.LoadDataRow(values.ToArray(), true);

                    LabService.DeleteAppliedTemplatesById(mainInvoice.GetWorkingJob().JobNbr, Convert.ToInt32(row.Cells["TemplateId"].Value));

                    List<int> tests = LabService.GetAllTemplateLabFeesById(Convert.ToInt32(row.Cells["TemplateId"].Value));
                    tests = tests.Distinct<int>().ToList();

                    foreach (int test in tests)
                        LabService.DeleteLabSpecByCustomerIdAndTestId(mainInvoice.GetWorkingJob().CustomerId, test);

                    string query = $"TemplateId = '{Convert.ToInt32(row.Cells["TemplateId"].Value)}'";
                    appliedDataTable.Rows.Remove(appliedDataTable.Select(query).First());
                }
            }

            labtemplates_appliedtests_datagridview.ClearSelection();
        }

        private void assigntests_clear_btn_Click(object sender, EventArgs e)
        {
            labtemplates_datagridview.ClearSelection();
            labtemplates_appliedtests_datagridview.ClearSelection();
            previewDataTable.Rows.Clear();
        }

        private void labtemplates_datagridview_Click(object sender, EventArgs e)
        {
            if (labtemplates_appliedtests_datagridview.SelectedRows.Count >= 1)
                labtemplates_appliedtests_datagridview.ClearSelection();

            previewDataTable.Rows.Clear();

            if (labtemplates_datagridview.CurrentRow != null)
            {
                List<int> tests = LabService.GetAllTemplateLabFeesById(Convert.ToInt32(labtemplates_datagridview.CurrentRow.Cells[0].Value));
                foreach (int test in tests)
                {
                    DataRowCollection rows = LabService.GetLabFeesInfoById(test).Rows;

                    if (rows.Count != 0)
                    {
                        object[] data = (rows[0] != null) ? rows[0].ItemArray : null;

                        if (data != null)
                            previewDataTable.Rows.Add(data);
                    }
                }
            }
        }

        private void labtemplates_appliedtests_datagridview_Click(object sender, EventArgs e)
        {
            if (labtemplates_datagridview.SelectedRows.Count >= 1)
                labtemplates_datagridview.ClearSelection();

            previewDataTable.Rows.Clear();

            if (labtemplates_appliedtests_datagridview.CurrentRow != null)
            {
                List<int> tests = LabService.GetAllTemplateLabFeesById(Convert.ToInt32(labtemplates_appliedtests_datagridview.CurrentRow.Cells[1].Value));
                foreach (int test in tests)
                {
                    DataRowCollection rows = LabService.GetLabFeesInfoById(test).Rows;

                    if (rows.Count != 0)
                    {
                        object[] data = (rows[0] != null) ? rows[0].ItemArray : null;

                        if (data != null)
                            previewDataTable.Rows.Add(data);
                    }
                }
            }
        }
    }
}
