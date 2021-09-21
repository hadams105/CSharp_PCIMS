using PCIMS_Software.Models;
using PCIMS_Software.Repositories.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PCIMS_Software.Repositories
{
	public static class CustomerRepository
	{
		public static DataTable GetAllCustomers()
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				DataTable dataTable = new DataTable();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_AllCustomerInfo", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dataTable);

				connection.Close();
				adapter.Dispose();

				return dataTable;
			}
		}

		public static DataTable GetAllCompanyNames()
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				DataTable dataTable = new DataTable();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_AllCompanyNames", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dataTable);

				connection.Close();
				adapter.Dispose();

				return dataTable;
			}
		}

        public static string GetCompanyNameById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_CompanyNameById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("CustomerID", id);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    return reader.GetString(0);
                }

                return null;
            }
        }

        public static CustomerObject GetCustomerById(int id)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				CustomerObject customerObject = new CustomerObject();

				connection.Open();

				SqlCommand cmd = new SqlCommand("Get_CustomerInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("CustomerID", id);

				SqlDataReader reader = cmd.ExecuteReader();

				int index = 0;
				while(reader.Read())
				{
					customerObject.CustomerId = reader.GetInt32(index++);
					customerObject.CompanyName = reader.GetString(index++);
					customerObject.ContactFirstName = reader.GetString(index++);
					customerObject.ContactLastName = reader.GetString(index++);
					customerObject.CompanyOrDepartment = reader.GetString(index++);
					customerObject.SortOrder = reader.GetString(index++);
					customerObject.BillingAddress = reader.GetString(index++);
					customerObject.BillingAddress2 = reader.GetString(index++);
					customerObject.City = reader.GetString(index++);
					customerObject.StateOrProvince = reader.GetString(index++);
					customerObject.PostalCode = reader.GetString(index++);
					customerObject.Country = reader.GetString(index++);
					customerObject.ContactTitle = reader.GetString(index++);
					customerObject.PhoneNumber = reader.GetString(index++);
					customerObject.Extension = reader.GetString(index++);
					customerObject.FaxNumber = reader.GetString(index++);
					customerObject.EmailAddress = reader.GetString(index++);
					customerObject.Notes = reader.GetString(index++);
				}

				return customerObject;
			}
		}

		public static string InsertCustomerInfo(CustomerObject customerObject)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Insert_CustomerInfo", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("CompanyName", customerObject.CompanyName);
				cmd.Parameters.AddWithValue("ContactFirstName", customerObject.ContactFirstName);
				cmd.Parameters.AddWithValue("ContactLastName", customerObject.ContactLastName);
				cmd.Parameters.AddWithValue("CompanyOrDepartment", customerObject.CompanyOrDepartment);
				cmd.Parameters.AddWithValue("SortOrder", customerObject.SortOrder);
				cmd.Parameters.AddWithValue("BillingAddress", customerObject.BillingAddress);
				cmd.Parameters.AddWithValue("BillingAddress2", customerObject.BillingAddress2);
				cmd.Parameters.AddWithValue("City", customerObject.City);
				cmd.Parameters.AddWithValue("StateOrProvince", customerObject.StateOrProvince);
				cmd.Parameters.AddWithValue("PostalCode", customerObject.PostalCode);
				cmd.Parameters.AddWithValue("Country", customerObject.Country);
				cmd.Parameters.AddWithValue("ContactTitle", customerObject.ContactTitle);
				cmd.Parameters.AddWithValue("PhoneNumber", customerObject.PhoneNumber);
				cmd.Parameters.AddWithValue("Extension", customerObject.Extension);
				cmd.Parameters.AddWithValue("FaxNumber", customerObject.FaxNumber);
				cmd.Parameters.AddWithValue("EmailAddress", customerObject.EmailAddress);
				cmd.Parameters.AddWithValue("Notes", customerObject.Notes);

				cmd.ExecuteNonQuery();

				return null;
			}
		}

		public static string UpdateCustomerById(CustomerObject customerObject)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Update_CustomerInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("CustomerId", customerObject.CustomerId);
				cmd.Parameters.AddWithValue("CompanyName", customerObject.CompanyName);
				cmd.Parameters.AddWithValue("ContactFirstName", customerObject.ContactFirstName);
				cmd.Parameters.AddWithValue("ContactLastName", customerObject.ContactLastName);
				cmd.Parameters.AddWithValue("CompanyOrDepartment", customerObject.CompanyOrDepartment);
				cmd.Parameters.AddWithValue("SortOrder", customerObject.SortOrder);
				cmd.Parameters.AddWithValue("BillingAddress", customerObject.BillingAddress);
				cmd.Parameters.AddWithValue("BillingAddress2", customerObject.BillingAddress2);
				cmd.Parameters.AddWithValue("City", customerObject.City);
				cmd.Parameters.AddWithValue("StateOrProvince", customerObject.StateOrProvince);
				cmd.Parameters.AddWithValue("PostalCode", customerObject.PostalCode);
				cmd.Parameters.AddWithValue("Country", customerObject.Country);
				cmd.Parameters.AddWithValue("ContactTitle", customerObject.ContactTitle);
				cmd.Parameters.AddWithValue("PhoneNumber", customerObject.PhoneNumber);
				cmd.Parameters.AddWithValue("Extension", customerObject.Extension);
				cmd.Parameters.AddWithValue("FaxNumber", customerObject.FaxNumber);
				cmd.Parameters.AddWithValue("EmailAddress", customerObject.EmailAddress);
				cmd.Parameters.AddWithValue("Notes", customerObject.Notes);

				cmd.ExecuteNonQuery();

				return null;
			}
		}

		public static string DeleteCustomerById(int id)
		{
			using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
			{
				connection.Open();

				SqlCommand cmd = new SqlCommand("Delete_CustomerInfoById", connection);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("CustomerId", id);

				cmd.ExecuteNonQuery();
			}

			return null;
		}
	}
}
