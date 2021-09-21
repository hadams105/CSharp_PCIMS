using PCIMS_Software.ControlTemplates;
using PCIMS_Software.ControlTemplates.Base;
using PCIMS_Software.ControlTemplates.Customer;
using PCIMS_Software.ControlTemplates.Invoice;
using PCIMS_Software.ControlTemplates.Job;
using PCIMS_Software.ControlTemplates.Lab;
using PCIMS_Software.ControlTemplates.Lab.LabSpecs;
using PCIMS_Software.ControlTemplates.Lab.Worksheet;
using PCIMS_Software.Forms;
using PCIMS_Software.Models;
using PCIMS_Software.Services;
using PCIMS_Software.Services.Utilities;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PCIMS_Software
{
	public partial class MainInvoiceForm : Form
	{
		UserControl currentControl;

        Invoice_UserControl invoice_UserControl;
		Customer_UserControl customer_UserControl = new Customer_UserControl();
		JobSelect_UserControl jobselect_UserControl;
		AddEditJob_UserControl addeditJob_UserControl;
        LabTemplateSelect_UserControl labTemplateSelect_UserControl;
        AssignTests_UserControl assignTests_UserControl;
        AssignTestSpecs_UserControl assignTestSpecs_UserControl;
        LabReports_UserControl labReports_UserControl;
        LabWorksheet_UserControl labWorksheet_UserControl;

        JobObject currentJob = null;

		public MainInvoiceForm()
		{
			InitializeComponent();
                        
			jobselect_UserControl = new JobSelect_UserControl(this);

            invoice_UserControl = new Invoice_UserControl(this);
            BindControl(invoice_UserControl);
        }

        //public void ReopenInvoiceUserControl()
        //{
        //    BindControl(invoice_UserControl);
        //}

		private void MainInvoiceForm_Load(object sender, EventArgs e)
		{
			currentControl = invoice_UserControl;
			invoice_panel.Controls.Add(invoice_UserControl);
		}

		private void nav_menu_clientmaintenance_btn_Click(object sender, EventArgs e)
		{
			BindControl(customer_UserControl);
		}

		private void nav_menu_invoice_Click(object sender, EventArgs e)
		{
            invoice_UserControl = new Invoice_UserControl(this);
            BindControl(invoice_UserControl);
		}

		private void nav_menu_openclose_btn_Click(object sender, EventArgs e)
		{
			if (currentJob == null)
			{
				BindControl(jobselect_UserControl);
				jobselect_UserControl.CreateRefreshJobSelectTable();
			}
			else
			{
				CloseWorkingJob();
                invoice_UserControl = new Invoice_UserControl(this);
                BindControl(invoice_UserControl);
            }
		}

		private void nav_menu_addeditjob_btn_Click(object sender, EventArgs e)
		{
			if (currentJob == null)
			{
				addeditJob_UserControl = new AddEditJob_UserControl(this);
				BindControl(addeditJob_UserControl);
			}
			else
			{
				addeditJob_UserControl = new AddEditJob_UserControl(this, currentJob);
				BindControl(addeditJob_UserControl);
			}
        }

        private void nav_menu_labtemps_btn_Click(object sender, EventArgs e)
        {
            labTemplateSelect_UserControl = new LabTemplateSelect_UserControl(this);
            BindControl(labTemplateSelect_UserControl);
        }

        private void nav_menu_pricemaintenance_btn_Click(object sender, EventArgs e)
        {
            PriceMaintenanceForm form = new PriceMaintenanceForm(this);
            form.Location = new Point(MousePosition.X, MousePosition.Y);
            form.Show();
        }

        private void nav_menu_assigntests_btn_Click(object sender, EventArgs e)
        {
            if (currentJob != null)
            {
                assignTests_UserControl = new AssignTests_UserControl(this);
                BindControl(assignTests_UserControl);
            }
            else
            {
                MessageBox.Show("Please open a job first.", "No Job Open");
            }
        }

        private void nav_menu_labspecs_btn_Click(object sender, EventArgs e)
        {
            if (currentJob != null)
            {
                assignTestSpecs_UserControl = new AssignTestSpecs_UserControl(this);
                BindControl(assignTestSpecs_UserControl);                
            }
            else
            {
                MessageBox.Show("Please open a job first.", "No Job Open");
            }
        }

        private void nav_menu_labwkshts_btn_Click(object sender, EventArgs e)
        {
            if (currentJob != null)
            {
                labWorksheet_UserControl = new LabWorksheet_UserControl(this);
                BindControl(labWorksheet_UserControl);
            }
            else
            {
                MessageBox.Show("Please open a job first.", "No Job Open");
            }
        }

        private void nav_menu_labrpts_btn_Click(object sender, EventArgs e)
        {
            if (currentJob != null)
            {
                labReports_UserControl = new LabReports_UserControl(this);
                BindControl(labReports_UserControl);
            }
            else
            {
                MessageBox.Show("Please open a job first.", "No Job Open");
            }
        }

        public void BindControl(UserControl userControl)
		{
			if (currentControl != null)
				invoice_panel.Controls.Remove(currentControl);

			currentControl = userControl;
			invoice_panel.Controls.Add(userControl);
			//userControl.AdjustControlSize();
		}

		private void UnbindControl()
		{
			if (currentControl == null)
				return;

			invoice_panel.Controls.Remove(currentControl);
			currentControl = null;
		}
		
		public void OpenWorkingJob(JobObject jobObject)
		{
			currentJob = jobObject;
			FillJobForm(jobObject);
			nav_menu_openclose_btn.Text = "Close Job";
			nav_menu_addedit_btn.Text = "Edit Job";

            invoice_UserControl = new Invoice_UserControl(this);
            BindControl(invoice_UserControl);
		}

		public void CloseWorkingJob()
		{
			currentJob = null;
			NullJobForm();
			nav_menu_openclose_btn.Text = "Open Job";
			nav_menu_addedit_btn.Text = "Add Job";

			BindControl(invoice_UserControl);
		}

		public JobObject GetWorkingJob()
		{
			return currentJob;
		}

		private void FillJobForm(JobObject jobObject)
		{
			CustomerObject customerObject = CustomerService.GetCustomerById(jobObject.CustomerId);

			nav_menu_companyname.Text = customerObject.CompanyName;
			nav_menu_jobnumber.Text = jobObject.JobNbr.ToString();
			nav_menu_jobtype.Text = JobService.GetJobTypeById(jobObject.JobType);
            nav_menu_orderdate.Text = jobObject.OrderDateTime;
			nav_menu_location.Text = jobObject.Location;
			nav_menu_terminal.Text = jobObject.Terminal;
		}

		private void NullJobForm()
		{
			nav_menu_companyname.Text = "NULL";
			nav_menu_jobnumber.Text = "NULL";
			nav_menu_jobtype.Text = "NULL";
			nav_menu_orderdate.Text = "NULL";
			nav_menu_location.Text = "NULL";
			nav_menu_terminal.Text = "NULL";
		}
    }
}
