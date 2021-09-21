using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PCIMS_Software.Repositories
{
    public static class PriceRepository
    {
        public static List<object[]> GetAllPrices()
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllPrices", connection);
                cmd.CommandType = CommandType.StoredProcedure;

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

        public static object[] GetPriceByServiceCode(string serviceCode)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_PriceByServiceCode", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    return values;
                }

                return null;
            }
        }

        public static void InsertPrice(string serviceCode, string serviceDesc, decimal amount, decimal minCharge)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_Price", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);
                cmd.Parameters.AddWithValue("ServiceDesc", serviceDesc);
                cmd.Parameters.AddWithValue("Amount", amount);
                cmd.Parameters.AddWithValue("MinCharge", minCharge);

                cmd.ExecuteNonQuery();

                return;
            }
        }

        public static void UpdatePriceByServiceCode(string serviceCode, string serviceDesc, decimal amount, decimal minCharge)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_PriceByServiceCode", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);
                cmd.Parameters.AddWithValue("ServiceDesc", serviceDesc);
                cmd.Parameters.AddWithValue("Amount", amount);
                cmd.Parameters.AddWithValue("MinCharge", minCharge);

                cmd.ExecuteNonQuery();

                return;
            }
        }

        public static void DeletePriceByServiceCode(string serviceCode)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_PriceByServiceCode", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("ServiceCode", serviceCode);

                cmd.ExecuteNonQuery();
            }

            return;
        }
    }
}
