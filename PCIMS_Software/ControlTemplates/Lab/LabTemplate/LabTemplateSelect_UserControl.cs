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
using PCIMS_Software.Forms;

namespace PCIMS_Software.ControlTemplates.Lab
{
    public partial class LabTemplateSelect_UserControl : UserControl // : BaseUserControl
    {
        private MainInvoiceForm mainInvoice;
        private LabTemplate_UserControl labTemplate_UserControl;

        public LabTemplateSelect_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;

            RefreshLabTemplateSelectTable();
        }

        private void labtemplateselect_new_btn_Click(object sender, EventArgs e)
        {
            labTemplate_UserControl = new LabTemplate_UserControl(mainInvoice);
            mainInvoice.BindControl(labTemplate_UserControl);
        }

        private void labtemplateselect_edit_btn_Click(object sender, EventArgs e)
        {
            labTemplate_UserControl = new LabTemplate_UserControl(mainInvoice, LabService.RowToLabTemplateObject(labtemplateselect_datagridview.CurrentRow));
            mainInvoice.BindControl(labTemplate_UserControl);
        }

        private void labtemplateselect_delete_btn_Click(object sender, EventArgs e)
        {
            if (labtemplateselect_datagridview.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show($"Would you like to delete lab template: { labtemplateselect_datagridview.SelectedRows[0].Cells["templateID"].Value.ToString() } " +
                                                            $": { labtemplateselect_datagridview.SelectedRows[0].Cells["templateName"].Value.ToString() }?",
                                                            "Delete Lab Template?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in labtemplateselect_datagridview.SelectedRows)
                    {
                        LabService.DeleteLabTemplateInfoById(int.Parse(row.Cells["templateID"].Value.ToString()));
                    }

                    RefreshLabTemplateSelectTable();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to delete " + labtemplateselect_datagridview.SelectedRows.Count + " rows?",
                    "Delete Lab Templates?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in labtemplateselect_datagridview.SelectedRows)
                    {
                        LabService.DeleteLabTemplateInfoById(int.Parse(row.Cells["templateID"].Value.ToString()));
                    }

                    RefreshLabTemplateSelectTable();
                }
            }

            labtemplateselect_datagridview.ClearSelection();
        }

        private void labfees_feemaintenance_btn_Click(object sender, EventArgs e)
        {
            FeeMaintenanceForm form = new FeeMaintenanceForm(null);
            form.Location = new Point(MousePosition.X, MousePosition.Y);
            form.Show();
        }

        private void RefreshLabTemplateSelectTable()
        {
            LabTemplateSelect_BindingSource.DataSource = LabService.GetAllLabTemplateInfo();
        }

        private void labtemplateselect_datagridview_SelectionChanged(object sender, EventArgs e)
        {
            if (labtemplateselect_datagridview.SelectedRows.Count == 1)
            {
                DataGridViewRow row = labtemplateselect_datagridview.SelectedRows[0];
                labtemplateselect_delete_btn.Enabled = true;
                labtemplateselect_edit_btn.Enabled = true;
            }
            else if(labtemplateselect_datagridview.SelectedRows.Count > 1)
            {
                labtemplateselect_edit_btn.Enabled = false;
            }
            else
            {
                labtemplateselect_delete_btn.Enabled = false;
                labtemplateselect_edit_btn.Enabled = false;
            }
        }

        private void labtemplateselect_datagridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            labtemplateselect_datagridview.ClearSelection();
        }
    }
}
