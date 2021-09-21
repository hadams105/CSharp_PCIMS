using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Repositories
{
    public static class InvoiceRepository
    {
        public static List<object[]> GetInvoiceRowsByJobNumber(int jobNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_InvoiceRowsByJobNumber", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobNbr", jobNbr);

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> prices = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    prices.Add(values);
                }

                return prices;
            }
        }

        public static void InsertUpdateInvoiceRow(int jobNbr, string serviceCode, string serviceDesc, int quantity, decimal cost, decimal total)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("InsertUpdate_InvoiceRow", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);
                cmd.Parameters.AddWithValue("ServiceDesc", serviceDesc);
                cmd.Parameters.AddWithValue("Quantity", quantity);
                cmd.Parameters.AddWithValue("Cost", cost);
                cmd.Parameters.AddWithValue("Total", total);

                cmd.ExecuteNonQuery();

                return;
            }
        }

        public static int GetInvoiceNumber(int jobNbr, int customerId, string jobDate)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_InvoiceNumber", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("CustomerId", customerId);
                string[] split = jobDate.Split('/');
                string builder = split[2] + "-" + ((split[0].Length == 1) ? "0" + split[0] : split[0]) + "-" + ((split[1].Length == 1) ? "0" + split[1] : split[1]);
                cmd.Parameters.AddWithValue("JobDate", builder);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }

                return -1;
            }
        }
        
        public static void InsertInvoiceNumber(int jobNbr, int customerId, string jobDate)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_InvoiceNumber", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("CustomerId", customerId);
                cmd.Parameters.AddWithValue("JobDate", jobDate);

                cmd.ExecuteNonQuery();

                return;
            }
        }

        public static void DeleteInvoiceRowByJobNbrAndServiceCode(int jobNbr, string serviceCode)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_InvoiceRowByJobNbrAndServiceCode", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);

                cmd.ExecuteNonQuery();
            }

            return;
        }
    }
}
