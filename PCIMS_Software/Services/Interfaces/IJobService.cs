using PCIMS_Software.Models;
using System.Data;

namespace PCIMS_Software.Services.Interfaces
{
	public interface IJobService
	{
		DataTable GetAllJobInfo();
		DataTable GetAllJobSelectInfo();
		JobObject GetJobById(int id);
		string InsertJobInfo(JobObject jobObject);
		string UpdateJobById(JobObject jobObject);
		string DeleteJobById(int id);
	}
}
