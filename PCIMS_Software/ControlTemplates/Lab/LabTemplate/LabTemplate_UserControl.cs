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
using PCIMS_Software.Services.Utilities;
using PCIMS_Software.Forms;

namespace PCIMS_Software.ControlTemplates.Lab
{
    public partial class LabTemplate_UserControl : UserControl //: BaseUserControl
    {
        private MainInvoiceForm mainInvoice;
        private LabTemplateObject labTemplateObject;
        private DataTable feesDataTable = new DataTable();
        private DataTable appliedDataTable = new DataTable();
        bool isNew = false;

        public LabTemplate_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
            labTemplateObject = new LabTemplateObject
            {
                TemplateID = LabService.InsertLabTemplateInfo("", "")
            };
            isNew = true;
        }

        public LabTemplate_UserControl(MainInvoiceForm mainInvoice, LabTemplateObject labTemplateObject)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
            this.labTemplateObject = labTemplateObject;
            labtemplate_templatename.Text = (string.IsNullOrWhiteSpace(labTemplateObject.TemplateName)) ? "" : labTemplateObject.TemplateName;
            labtemplate_re.Text = (string.IsNullOrWhiteSpace(labTemplateObject.Re)) ? "" : labTemplateObject.Re;
        }

        private void LabTemplate_UserControl_Load(object sender, EventArgs e)
        {
            FillLabTemplateTables();
        }

        private void labfees_feemaintenance_btn_Click(object sender, EventArgs e)
        {
            FeeMaintenanceForm form = new FeeMaintenanceForm(null);
            form.Location = new Point(MousePosition.X, MousePosition.Y);
            form.Show();
        }

        private void FillLabTemplateTables()
        {
            feesDataTable.Columns.Add("TestID", typeof(int));
            feesDataTable.Columns.Add("TestDesc", typeof(string));
            feesDataTable.Columns.Add("Fee", typeof(decimal));
            feesDataTable.Columns.Add("ASTM", typeof(string));

            appliedDataTable.Columns.Add("TestID", typeof(int));
            appliedDataTable.Columns.Add("TestDesc", typeof(string));
            appliedDataTable.Columns.Add("Fee", typeof(decimal));
            appliedDataTable.Columns.Add("ASTM", typeof(string));

            DataTable temp_DataTable = LabService.GetAllLabTemplateFees().Copy();

            List<int> testIDList = LabService.GetAllTemplateLabFeesById(labTemplateObject.TemplateID);

            foreach(DataRow row in temp_DataTable.Rows)
            {
                if(testIDList.Contains(row.Field<int>(0)))
                {
                    appliedDataTable.LoadDataRow(row.ItemArray, true);
                }
                else
                {
                    feesDataTable.LoadDataRow(row.ItemArray, true);
                }
            }

            temp_DataTable.Dispose();
            labtemplate_datagridview.DataSource = feesDataTable;
            LabTemplate_AppliedFee_BindingSource.DataSource = appliedDataTable;
        }
        
        private void labtemplates_addTo_btn_Click(object sender, EventArgs e)
        {
            if(labtemplate_datagridview.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow row in labtemplate_datagridview.SelectedRows)
                {
                    List<object> values = new List<object>();

                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value);
                    
                    appliedDataTable.LoadDataRow(values.ToArray(), true);

                    LabService.InsertLabTemplateFeeData(labTemplateObject.TemplateID, Convert.ToInt32(row.Cells["testID"].Value));
                    
                    string query = $"TestID = '{Convert.ToInt32(row.Cells["testID"].Value)}'";
                    feesDataTable.Rows.Remove(feesDataTable.Select(query).First());
                }
            }

            labtemplate_datagridview.ClearSelection();
        }

        private void labtemplates_removeFrom_btn_Click(object sender, EventArgs e)
        {
            if (labtemplate_datagridview_applied.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow row in labtemplate_datagridview_applied.SelectedRows)
                {
                    List<object> values = new List<object>();

                    foreach (DataGridViewCell cell in row.Cells)
                        values.Add(cell.Value);

                    feesDataTable.LoadDataRow(values.ToArray(), true);
                    
                    LabService.DeleteLabTemplateFeeData(labTemplateObject.TemplateID, Convert.ToInt32(row.Cells["testIDApplied"].Value));

                    string query = $"TestID = '{Convert.ToInt32(row.Cells["testIDApplied"].Value)}'";
                    appliedDataTable.Rows.Remove(appliedDataTable.Select(query).First());
                }
            }

            labtemplate_datagridview_applied.ClearSelection();
        }

        private void labtemplate_datagridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labtemplate_datagridview.ClearSelection();
            labtemplate_datagridview_applied.ClearSelection();
        }

        private void labtemplate_save_btn_Click(object sender, EventArgs e)
        {
            LabService.UpdateLabTemplateInfo(labTemplateObject.TemplateID, labtemplate_templatename.Text, labtemplate_re.Text);
        }

        private void labtemplate_back_btn_Click(object sender, EventArgs e)
        {
            if(isNew && labtemplate_templatename.Text.Equals("") && labtemplate_re.Text.Equals(""))
            {
                LabService.DeleteLabTemplateInfoById(labTemplateObject.TemplateID);
            }

            mainInvoice.BindControl(new LabTemplateSelect_UserControl(mainInvoice));
        }
    }
}
