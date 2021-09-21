using PCIMS_Software.Models;
using PCIMS_Software.Repositories.Interfaces;
using System;
using System.Data;
using System.Data.SqlClient;

namespace PCIMS_Software.Repositories
{
	public static class JobRepository
	{
		public static DataTable GetAllJobInfo()
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				DataTable dataTable = new DataTable();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_AllJobInfo", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dataTable);

				connection.Close();
				adapter.Dispose();

				return dataTable;
			}
		}

		public static DataTable GetAllJobSelectInfo()
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				DataTable dataTable = new DataTable();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_AllJobSelectInfo", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dataTable);

				connection.Close();
				adapter.Dispose();

				return dataTable;
			}
		}

        public static string GetJobTypeById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_JobTypeById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobTypeId", id);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return reader.GetString(0);
                }

                return null;
            }
        }

        public static JobObject GetJobById(int id)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				JobObject jobObject = new JobObject();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_JobInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("JobNbr", id);

				SqlDataReader reader = cmd.ExecuteReader();

				int index = 0;
				while(reader.Read())
				{
                    jobObject.JobNbr = reader.GetInt32(index++);
                    jobObject.CustomerId = reader.GetInt32(index++);
					jobObject.OrderDateTime = reader.GetDateTime(index++).ToShortDateString();
					jobObject.TakenBy = reader.GetString(index++);
					jobObject.JobType = reader.GetInt32(index++);
					jobObject.OrderBy = reader.GetString(index++);
					jobObject.DateSampled = reader.GetDateTime(index++).ToShortDateString();
					jobObject.SubmissionId = reader.GetString(index++);
					jobObject.Terminal = reader.GetString(index++);
					jobObject.Location = reader.GetString(index++);
					jobObject.Cargo = reader.GetString(index++);
                    jobObject.SampleQty = reader.GetInt32(index++);
					jobObject.DateInLab = reader.GetDateTime(index++).ToShortDateString();
					jobObject.DateCompleted = reader.GetDateTime(index++).ToShortDateString();
					jobObject.Reports = reader.GetString(index++);
                    jobObject.Splits = reader.GetInt16(index++);
					jobObject.Dist1 = reader.GetString(index++);
					jobObject.Dist2 = reader.GetString(index++);
					jobObject.Subs = reader.GetByte(index++);
					jobObject.LD = reader.GetString(index++);
				}

				return jobObject;
			}
		}

		public static DataTable GetJobTypes()
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				DataTable dataTable = new DataTable();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_JobTypes", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dataTable);

				connection.Close();
				adapter.Dispose();

				return dataTable;
			}
		}

		public static int InsertJobInfo(JobObject jobObject)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Insert_JobInfo", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("CustomerId", jobObject.CustomerId);
				cmd.Parameters.AddWithValue("OrderDateTime", jobObject.OrderDateTime);
				cmd.Parameters.AddWithValue("TakenBy", jobObject.TakenBy);
				cmd.Parameters.AddWithValue("JobType", jobObject.JobType);
				cmd.Parameters.AddWithValue("OrderBy", jobObject.OrderBy);
				cmd.Parameters.AddWithValue("DateSampled", jobObject.DateSampled);
				cmd.Parameters.AddWithValue("SubmissionId", jobObject.SubmissionId);
				cmd.Parameters.AddWithValue("Terminal", jobObject.Terminal);
				cmd.Parameters.AddWithValue("Location", jobObject.Location);
				cmd.Parameters.AddWithValue("Cargo", jobObject.Cargo);
				cmd.Parameters.AddWithValue("SampleQty", jobObject.SampleQty);
				cmd.Parameters.AddWithValue("DateInLab", jobObject.DateInLab);
				cmd.Parameters.AddWithValue("DateCompleted", jobObject.DateCompleted);
				cmd.Parameters.AddWithValue("Reports", jobObject.Reports);
				cmd.Parameters.AddWithValue("Splits", jobObject.Splits);
				cmd.Parameters.AddWithValue("Dist1", jobObject.Dist1);
				cmd.Parameters.AddWithValue("Dist2", jobObject.Dist2);
				cmd.Parameters.AddWithValue("Subs", jobObject.Subs);
				cmd.Parameters.AddWithValue("LD", jobObject.LD);
				
				return int.Parse(cmd.ExecuteScalar().ToString()); 
			}
		}

		public static string UpdateJobById(JobObject jobObject)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Update_JobInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("JobNbr", jobObject.JobNbr);
                cmd.Parameters.AddWithValue("CustomerId", jobObject.CustomerId);
                cmd.Parameters.AddWithValue("OrderDateTime", jobObject.OrderDateTime);
                cmd.Parameters.AddWithValue("TakenBy", jobObject.TakenBy);
                cmd.Parameters.AddWithValue("JobType", jobObject.JobType);
                cmd.Parameters.AddWithValue("OrderBy", jobObject.OrderBy);
                cmd.Parameters.AddWithValue("DateSampled", jobObject.DateSampled);
                cmd.Parameters.AddWithValue("SubmissionId", jobObject.SubmissionId);
                cmd.Parameters.AddWithValue("Terminal", jobObject.Terminal);
                cmd.Parameters.AddWithValue("Location", jobObject.Location);
                cmd.Parameters.AddWithValue("Cargo", jobObject.Cargo);
                cmd.Parameters.AddWithValue("SampleQty", jobObject.SampleQty);
                cmd.Parameters.AddWithValue("DateInLab", jobObject.DateInLab);
                cmd.Parameters.AddWithValue("DateCompleted", jobObject.DateCompleted);
                cmd.Parameters.AddWithValue("Reports", jobObject.Reports);
                cmd.Parameters.AddWithValue("Splits", jobObject.Splits);
                cmd.Parameters.AddWithValue("Dist1", jobObject.Dist1);
                cmd.Parameters.AddWithValue("Dist2", jobObject.Dist2);
                cmd.Parameters.AddWithValue("Subs", jobObject.Subs);
                cmd.Parameters.AddWithValue("LD", jobObject.LD);

                cmd.ExecuteNonQuery();

				return null;
			}
		}

		public static string DeleteJobById(int id)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Delete_JobInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("JobNbr", id);

				cmd.ExecuteNonQuery();
			}

			return null;
		}
	}
}
