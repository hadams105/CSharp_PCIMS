using PCIMS_Software.ControlTemplates.Lab;
using PCIMS_Software.Models;
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
    public partial class FeeMaintenanceForm : Form
    {
        private LabTemplate_UserControl labTemplate_UserControl;
        public FeeMaintenanceForm(LabTemplate_UserControl labTemplate_UserControl)
        {
            InitializeComponent();

            this.labTemplate_UserControl = labTemplate_UserControl;
            RefreshDataGridView();
        }

        private void feemaintenance_addedit_btn_Click(object sender, EventArgs e)
        {
            if (feemaintenance_datagridview.SelectedRows.Count == 0)
            {
                LabFeeObject labFeeObject = LabService.FormToLabFeeObject(0, feemaintenance_testdesc.Text, feemaintenance_astm.Text, feemaintenance_fee_nud.Value);
                LabService.InsertLabFeeInfo(labFeeObject);
            }
            else if (feemaintenance_datagridview.SelectedRows.Count == 1)
            {
                LabFeeObject labFeeObject = LabService.FormToLabFeeObject(int.Parse(feemaintenance_datagridview.CurrentRow.Cells["testID"].Value.ToString()), feemaintenance_testdesc.Text, feemaintenance_astm.Text, feemaintenance_fee_nud.Value);
                LabService.UpdateLabFeeInfoById(labFeeObject);
            }

            RefreshDataGridView();
            ClearForm();
        }

        private void feemaintenance_delete_btn_Click(object sender, EventArgs e)
        {
            if (feemaintenance_datagridview.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to this fee template?",
                                                            "Delete Fee Template?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (feemaintenance_datagridview.SelectedRows.Count == 1)
                    {
                        LabService.DeleteLabFeeInfoById(int.Parse(feemaintenance_datagridview.CurrentRow.Cells["testID"].Value.ToString()));
                    }

                    RefreshDataGridView();
                    ClearForm();
                }
            }
        }

        private void feemaintenance_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if(feemaintenance_datagridview.SelectedRows.Count == 1)
            {
                feemaintenance_addedit_btn.Text = "Save ";
                FillForm(feemaintenance_datagridview.CurrentRow);
            }
        }

        private void feemaintenance_clear_btn_Click(object sender, EventArgs e)
        {
            feemaintenance_addedit_btn.Text = "Add";
            feemaintenance_datagridview.CurrentRow.Selected = false;
            ClearForm();
        }

        private void RefreshDataGridView()
        {
            feemaintenance_datagridview.DataSource = LabService.GetAllLabTemplateFees();
        }

        private void FillForm(DataGridViewRow row)
        {
            feemaintenance_testdesc.Text = row.Cells["testDesc"].Value.ToString();
            feemaintenance_astm.Text = row.Cells["astm"].Value.ToString();
            string test = row.Cells["fee"].Value.ToString();
            feemaintenance_fee_nud.Value = decimal.Parse(test);
        }

        private void ClearForm()
        {
            feemaintenance_testdesc.Text = null;
            feemaintenance_astm.Text = null;
            feemaintenance_fee_nud.Value = 0.00M;

            feemaintenance_datagridview.ClearSelection();
        }

        private void Fee_Maintenance_Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
