using PCIMS_Software.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Repositories.Interfaces
{
	public interface IJobRepository
	{
		DataTable GetAllJobInfo();
		DataTable GetAllJobSelectInfo();
		JobObject GetJobById(int id);
		string InsertJobInfo(JobObject jobObject); 
		string UpdateJobById(JobObject jobObject);
		string DeleteJobById(int id);
	}
}
