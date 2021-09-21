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
using PCIMS_Software.ControlTemplates.Base;
using PCIMS_Software.Models;
using PCIMS_Software.Services.Utilities;

namespace PCIMS_Software.ControlTemplates
{
	public partial class JobSelect_UserControl : UserControl //: Base_UserControl
	{
		private MainInvoiceForm mainInvoice;

		public JobSelect_UserControl(MainInvoiceForm mainInvoice)
		{
			InitializeComponent();
			this.mainInvoice = mainInvoice;
		}

		private void JobSelect_UserControl_Load(object sender, EventArgs e)
		{
            CreateRefreshJobSelectTable();
		}

		private void jobselect_datagridview_SelectionChanged(object sender, EventArgs e)
		{
			if (jobselect_datagridview.SelectedRows.Count == 1)
			{
                DataGridViewRow row = jobselect_datagridview.SelectedRows[0];
                FillJobForm(row);
                jobselect_delete_btn.Enabled = true;
                jobselect_select_btn.Enabled = true;
            }
            else
            {
                ClearJobForm();
                jobselect_select_btn.Enabled = false;
            }
		}

        private void jobselect_select_btn_Click(object sender, EventArgs e)
        {
            if (mainInvoice != null)
                if (jobselect_datagridview.SelectedRows.Count == 1)
                {
                    JobObject jobObject = JobService.GetJobById(Convert.ToInt32(jobselect_datagridview.CurrentRow.Cells["JobNbr"].Value));
                    mainInvoice.OpenWorkingJob(jobObject);
                }
        }

		private void jobselect_delete_btn_Click(object sender, EventArgs e)
		{
            if (jobselect_datagridview.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to delete job: " + jobselect_datagridview.SelectedRows[0].Cells["jobNbr"].Value.ToString() + "?",
                                                            "Delete Job Information?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in jobselect_datagridview.SelectedRows)
                    {
                        JobService.DeleteJobById(int.Parse(row.Cells["jobNbr"].Value.ToString()));
                    }

                    CreateRefreshJobSelectTable();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to delete " + jobselect_datagridview.SelectedRows.Count + " rows?",
                    "Delete Job Information?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in jobselect_datagridview.SelectedRows)
                    {
                        JobService.DeleteJobById(int.Parse(row.Cells["jobNbr"].Value.ToString()));
                    }

                    CreateRefreshJobSelectTable();
                }
            }
        }

		public void CreateRefreshJobSelectTable()
		{
            jobselect_datagridview.Rows.Clear();

            DataTable dataTable = JobService.GetAllJobSelectInfo();

            if(dataTable.Rows.Count != 0)
                jobselect_datagridview.Rows.Add(dataTable.Rows.Count);

            int index = 0;
            foreach(DataRow row in dataTable.Rows)
            {
                DataGridViewRow currentRow = jobselect_datagridview.Rows[index];
                currentRow.Cells["JobNbr"].Value = dataTable.Rows[index].Field<int>("JobNbr");
                currentRow.Cells["companyID"].Value = dataTable.Rows[index].Field<int>("CustomerID");
                currentRow.Cells["companyName"].Value = CustomerService.GetCompanyNameById(dataTable.Rows[index].Field<int>("CustomerID"));
                currentRow.Cells["orderDateTime"].Value = dataTable.Rows[index].Field<DateTime>("OrderDateTime").ToShortDateString();
                int test = dataTable.Rows[index].Field<int>("JobType");
                currentRow.Cells["jobType"].Value = JobService.GetJobTypeById(test);
                index++;
            }

            jobselect_datagridview.ClearSelection();
        }

		private void FillJobForm(DataGridViewRow row)
		{
            JobObject jobObject;

            if (row.Cells["JobNbr"].Value != null)
            {
                jobObject = JobService.GetJobById(int.Parse(row.Cells["JobNbr"].Value.ToString()));
                
                jobselect_companyname.Text = CustomerService.GetCustomerById(jobObject.CustomerId).CompanyName;
                jobselect_orderdate.Text = jobObject.OrderDateTime;
                jobselect_takenby.Text = jobObject.TakenBy;
                jobselect_jobtype.Text = JobService.GetJobTypeById(jobObject.JobType);
                jobselect_orderby.Text = jobObject.OrderBy;
                jobselect_datesampled.Text = jobObject.DateSampled;
                jobselect_submissionId.Text = jobObject.SubmissionId;
                jobselect_terminal.Text = jobObject.Terminal;
                jobselect_location.Text = jobObject.Location;
                jobselect_cargo.Text = jobObject.Cargo;
                jobselect_sampleqty.Text = jobObject.SampleQty.ToString();
                jobselect_dateinlab.Text = jobObject.DateInLab;
                jobselect_datecompleted.Text = jobObject.DateCompleted;
                jobselect_reports.Text = jobObject.Reports;
                jobselect_splits.Text = jobObject.Splits.ToString();
                jobselect_dist1.Text = jobObject.Dist1;
                jobselect_dist2.Text = jobObject.Dist2;
                jobselect_subs.Text = jobObject.Subs.ToString();
                jobselect_ld.Text = jobObject.LD;
            }
        }

        private void ClearJobForm()
        {
            jobselect_companyname.Text = "";
            jobselect_orderdate.Text = "";
            jobselect_takenby.Text = "";
            jobselect_jobtype.Text = "";
            jobselect_orderby.Text = "";
            jobselect_datesampled.Text = "";
            jobselect_submissionId.Text = "";
            jobselect_terminal.Text = "";
            jobselect_location.Text = "";
            jobselect_cargo.Text = "";
            jobselect_sampleqty.Text = "";
            jobselect_dateinlab.Text = "";
            jobselect_datecompleted.Text = "";
            jobselect_reports.Text = "";
            jobselect_splits.Text = "";
            jobselect_dist1.Text = "";
            jobselect_dist2.Text = "";
            jobselect_subs.Text = "";
            jobselect_ld.Text = "";
        }
	}
}
