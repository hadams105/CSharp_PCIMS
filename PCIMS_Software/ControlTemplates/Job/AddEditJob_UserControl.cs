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
using PCIMS_Software.Models;
using PCIMS_Software.Services;

namespace PCIMS_Software.ControlTemplates.Job
{
	public partial class AddEditJob_UserControl : UserControl// : Base_UserControl
	{
		private MainInvoiceForm mainInvoice;
        private bool editMode = false;

		public AddEditJob_UserControl(MainInvoiceForm mainInvoice)
		{
			InitializeComponent();
			this.mainInvoice = mainInvoice;
			addeditjob_company_cb.DisplayMember = "CompanyName";
			addeditjob_company_cb.ValueMember = "CustomerID";
            addeditjob_company_cb.DataSource = CustomerService.GetAllCompanyNames();

			addeditjob_jobtype_cb.DisplayMember = "JobTypeDesc";
			addeditjob_jobtype_cb.ValueMember = "JobTypeID";
			addeditjob_jobtype_cb.DataSource = JobService.GetJobTypes();

			addeditjob_addsubmit_btn.Text = "Add";
		}

		public AddEditJob_UserControl(MainInvoiceForm mainInvoice, JobObject jobObject)
		{
			InitializeComponent();
			this.mainInvoice = mainInvoice;
			addeditjob_company_cb.DisplayMember = "CompanyName";
			addeditjob_company_cb.ValueMember = "CustomerID";
			addeditjob_company_cb.DataSource = CustomerService.GetAllCompanyNames();

			addeditjob_jobtype_cb.DisplayMember = "JobTypeDesc";
			addeditjob_jobtype_cb.ValueMember = "JobTypeID";
			addeditjob_jobtype_cb.DataSource = JobService.GetJobTypes();

			FillJobEditForm(jobObject);

			addeditjob_addsubmit_btn.Text = "Submit";
            editMode = true;
		}

		private void FillJobEditForm(JobObject jobObject)
		{
			addeditjob_company_cb.SelectedValue = jobObject.CustomerId;
			addeditjob_orderdate_dtp.Value = DateTime.Parse(jobObject.OrderDateTime);
			addeditjob_takenby.Text = jobObject.TakenBy;
			addeditjob_jobtype_cb.SelectedValue = jobObject.JobType;
			addeditjob_orderby.Text = jobObject.OrderBy;
			addeditjob_datesampled_dtp.Value = DateTime.Parse(jobObject.DateSampled);
			addeditjob_submissionId.Text = jobObject.SubmissionId;
			addeditjob_terminal.Text = jobObject.Terminal;
			addeditjob_location.Text = jobObject.Location;
			addeditjob_cargo.Text = jobObject.Cargo;
			addeditjob_cargo_nud.Value = jobObject.SampleQty;
			addeditjob_dateinlab_dtp.Value = DateTime.Parse(jobObject.DateInLab);
            addeditjob_datecompleted_dtp.Value = DateTime.Parse(jobObject.DateCompleted);
			addeditjob_reports.Text = jobObject.Reports;
			addeditjob_splits_nud.Value = jobObject.Splits;
			addeditjob_dist1.Text = jobObject.Dist1;
			addeditjob_subs_nud.Value = jobObject.Subs;
			addeditjob_dist2.Text = jobObject.Dist2;
			addeditjob_ld.Text = jobObject.LD;
		}

		private void addeditjob_addsubmit_btn_Click(object sender, EventArgs e)
		{
			JobObject jobObject = new JobObject();

			int.TryParse(addeditjob_company_cb.SelectedValue.ToString(), out int result);
			jobObject.CustomerId = result;
			jobObject.OrderDateTime = addeditjob_orderdate_dtp.Value.ToShortDateString();
			jobObject.TakenBy = addeditjob_takenby.Text;
			jobObject.JobType = (int) addeditjob_jobtype_cb.SelectedValue;
			jobObject.OrderBy = addeditjob_orderby.Text;
			jobObject.DateSampled = addeditjob_datesampled_dtp.Value.ToShortDateString();
			jobObject.SubmissionId = addeditjob_submissionId.Text;
			jobObject.Terminal = addeditjob_terminal.Text;
			jobObject.Location = addeditjob_location.Text;
			jobObject.Cargo = addeditjob_cargo.Text;
			jobObject.SampleQty = (int)addeditjob_cargo_nud.Value;
			jobObject.DateInLab = addeditjob_dateinlab_dtp.Value.ToShortDateString();
			jobObject.DateCompleted = addeditjob_datecompleted_dtp.Value.ToShortDateString();
            jobObject.Reports = addeditjob_reports.Text;
			jobObject.Splits = (int) addeditjob_splits_nud.Value;
			jobObject.Dist1 = addeditjob_dist1.Text;
			jobObject.Subs = (int) addeditjob_subs_nud.Value;
			jobObject.Dist2 = addeditjob_dist2.Text;
			jobObject.LD = addeditjob_ld.Text;


            if(editMode)
            {
                int maxSheet = 0;
                int sampleQty = jobObject.SampleQty;
                DataTable tests = LabService.GetAssignedTestsById(mainInvoice.GetWorkingJob().JobNbr);
               

                DataTable distinctTests = tests.DefaultView.ToTable(true, "Re", "TemplateId", "TestId");

                if (tests != null)
                {
                    foreach (DataRow row in tests.Rows)
                    {
                        if (row.Field<short>("SheetNbr") > maxSheet)
                            maxSheet = row.Field<short>("SheetNbr");
                    }
                }

                if (maxSheet < sampleQty)
                {
                    int sheetsToMake = sampleQty - maxSheet;

                    foreach (DataRow row in distinctTests.Rows)
                    {
                        for (int i = 1; i <= sheetsToMake; i++) 
                        {
                            // Create the test object
                            AppliedTestObject obj = new AppliedTestObject();

                            DataTable test = LabService.GetLabFeesInfoById(row.Field<int>("TestId"));

                            obj.JobNbr = mainInvoice.GetWorkingJob().JobNbr;
                            obj.Re = row.Field<string>("Re");
                            obj.TemplateId = row.Field<int>("TemplateId");
                            obj.TestId = row.Field<int>("TestId");
                            obj.Test = test.Rows[0]["TestDesc"].ToString();
                            obj.Fee = Convert.ToDouble(test.Rows[0]["Fee"]);
                            obj.Astm = test.Rows[0]["ASTM"].ToString();
                            obj.SheetNbr = maxSheet + i;

                            LabService.InsertAppliedTest(obj);
                            LabService.InsertLabSpec(obj.Test,
                                                     mainInvoice.GetWorkingJob().CustomerId,
                                                     "",
                                                     obj.TestId,
                                                     obj.Astm,
                                                     "",
                                                     "");
                        }
                    }

                    tests.Dispose();
                    distinctTests.Dispose();
                }
                else if(maxSheet > sampleQty)
                {
                    int sheetsToDelete = maxSheet - sampleQty;

                    DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {sheetsToDelete} samples? If data is inserted, this action cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        for (int i = sheetsToDelete; i > 0; i--)
                        {
                            LabService.DeleteAppliedTestsBySheetNbr(mainInvoice.GetWorkingJob().JobNbr, sampleQty + i);
                        }
                    }                    
                }

				jobObject.JobNbr = mainInvoice.GetWorkingJob().JobNbr;
				JobService.UpdateJobById(jobObject);
            }
            else
            {
                jobObject.JobNbr = JobService.InsertJobInfo(jobObject);
                InvoiceService.InsertInvoiceNumber(jobObject.JobNbr, jobObject.CustomerId, jobObject.OrderDateTime);
                mainInvoice.OpenWorkingJob(jobObject);
            }
		}
	}
}
