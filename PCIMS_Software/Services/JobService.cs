using PCIMS_Software.Models;
using PCIMS_Software.Repositories;
using PCIMS_Software.Services.Interfaces;
using System.Data;
using System.Windows.Forms;

namespace PCIMS_Software.Services
{
	public static class JobService
	{

		public static DataTable GetAllJobInfo()
		{
			return JobRepository.GetAllJobInfo();
		}

		public static DataTable GetAllJobSelectInfo()
		{
			return JobRepository.GetAllJobSelectInfo();
		}

		public static JobObject GetJobById(int id)
		{
			return JobRepository.GetJobById(id);
		}

		public static DataTable GetJobTypes()
		{
			return JobRepository.GetJobTypes();	
		}

		public static int InsertJobInfo(JobObject jobObject)
		{
			return JobRepository.InsertJobInfo(jobObject);
		}

		public static string UpdateJobById(JobObject jobObject)
		{
			return JobRepository.UpdateJobById(jobObject);
		}

		public static string DeleteJobById(int id)
		{
			return JobRepository.DeleteJobById(id);
		}

        public static string GetJobTypeById(int id)
        {
            return JobRepository.GetJobTypeById(id);
        }

		public static JobObject TranslateRowToJobObject(DataGridViewRow row)
		{
			JobObject jobObject = new JobObject();

			jobObject.JobNbr = (row.Cells["jobNbr"].Value != null) ? int.Parse(row.Cells["jobNbr"].Value.ToString()) : 0;
			jobObject.CustomerId = (row.Cells["customerID"].Value != null) ? int.Parse(row.Cells["customerID"].Value.ToString()) : 0;
			jobObject.OrderDateTime = (row.Cells["orderDateTime"].Value != null) ? row.Cells["orderDateTime"].Value.ToString() : "";
			jobObject.TakenBy = (row.Cells["takenBy"].Value != null) ? row.Cells["takenBy"].Value.ToString() : "";
			jobObject.JobType = (row.Cells["jobType"].Value != null) ? int.Parse(row.Cells["jobType"].Value.ToString()) : 0;
			jobObject.OrderBy = (row.Cells["orderBy"].Value != null) ? row.Cells["orderBy"].Value.ToString() : "";
			jobObject.DateSampled = (row.Cells["dateSampled"].Value != null) ? row.Cells["vesselType"].Value.ToString() : "";
			jobObject.SubmissionId = (row.Cells["submissionId"].Value != null) ? row.Cells["eta"].Value.ToString() : "";
			jobObject.Terminal = (row.Cells["terminal"].Value != null) ? row.Cells["terminal"].Value.ToString() : "";
			jobObject.Location = (row.Cells["location"].Value != null) ? row.Cells["location"].Value.ToString() : "";
			jobObject.Cargo = (row.Cells["cargo"].Value != null) ? row.Cells["cargo"].Value.ToString() : "";
			jobObject.SampleQty = (row.Cells["sampleQty"].Value != null) ? int.Parse(row.Cells["sampleQty"].Value.ToString()) : 0;
			jobObject.DateInLab = (row.Cells["dateInLab"].Value != null) ? row.Cells["vessel"].Value.ToString() : "";
			jobObject.DateCompleted = (row.Cells["dateCompleted"].Value != null) ? row.Cells["inspectionDate"].Value.ToString() : "";
			jobObject.Reports = (row.Cells["reports"].Value != null) ? row.Cells["reports"].Value.ToString() : "";
			jobObject.Splits = (row.Cells["splits"].Value != null) ? int.Parse(row.Cells["splits"].Value.ToString()) : -1;
			jobObject.Dist1 = (row.Cells["dist1"].Value != null) ? row.Cells["dist1"].Value.ToString() : "";
			jobObject.Dist2 = (row.Cells["dist2"].Value != null) ? row.Cells["dist2"].Value.ToString() : "";
			jobObject.Subs = (row.Cells["subs"].Value != null) ? int.Parse(row.Cells["subs"].Value.ToString()) : -1;
			jobObject.LD = (row.Cells["LD"].Value != null) ? row.Cells["LD"].Value.ToString() : "";

			return jobObject;
		}
	}
}
