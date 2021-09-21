using PCIMS_Software.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Repositories
{
    public static class LabRepository
    {
        // Lab Template Database Services 

        public static DataTable GetAllLabTemplateInfo()
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllLabTemplateInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                connection.Close();
                adapter.Dispose();

                return dataTable;
            }
        }

        public static void DeleteLabTemplateInfoById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                DeleteAllLabTemplateFeeDataById(id);

                SqlCommand cmd = new SqlCommand("Delete_LabTemplateInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TemplateID", id);

                cmd.ExecuteNonQuery();
            }
        }

        private static void DeleteAllLabTemplateFeeDataById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AllLabTemplateFeeDataById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TemplateID", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Lab Template Database Services 
        
        public static object[] GetLabTemplateById(int templateId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_LabTemplateInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TemplateID", templateId);

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

        public static string GetLabTemplateNameById(int templateId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_LabTemplateNameById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TemplateID", templateId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetString(0);
                }

                return null;
            }
        }

        public static DataTable GetAllLabTemplateFees()
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllLabTemplateFeeInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                connection.Close();
                adapter.Dispose();

                return dataTable;
            }
        }

        public static List<int> Get_AllLabTemplateFeesById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                List<int> testList = new List<int>();
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllLabTemplateFeeInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TemplateID", id);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    testList.Add(reader.GetInt32(0));
                }

                return testList;
            }
        }

        public static DataTable GetLabFeesInfoById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_LabFeeInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TestId", id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                connection.Close();
                adapter.Dispose();

                return dataTable;
            }
        }

        public static void InsertLabFeeInfo(LabFeeObject labFeeObject)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_LabFeeInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("TestDesc", labFeeObject.TestDesc);
                cmd.Parameters.AddWithValue("Fee", labFeeObject.Fee);
                cmd.Parameters.AddWithValue("ASTM", labFeeObject.ASTM);

                cmd.ExecuteNonQuery();
            }
        }

        public static string UpdateLabFeeInfoById(LabFeeObject labFeeObject)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_LabFeeInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TestID", labFeeObject.TestID);
                cmd.Parameters.AddWithValue("TestDesc", labFeeObject.TestDesc);
                cmd.Parameters.AddWithValue("Fee", labFeeObject.Fee);
                cmd.Parameters.AddWithValue("ASTM", labFeeObject.ASTM);

                cmd.ExecuteNonQuery();

                return null;
            }
        }

        public static void DeleteLabFeeInfoById(int id)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_LabFeeInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TestID", id);

                cmd.ExecuteNonQuery();
            }
        }

        public static int InsertLabTemplateInfo(string templateName, string re)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_LabTemplateInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TemplateName", templateName);
                cmd.Parameters.AddWithValue("Re", re);

                return int.Parse(cmd.ExecuteScalar().ToString());
            }
        }        

        public static void UpdateLabTemplateInfo(int id, string templateName, string re)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_LabTemplateInfoById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TemplateID", id);
                cmd.Parameters.AddWithValue("TemplateName", templateName);
                cmd.Parameters.AddWithValue("Re", re);

                cmd.ExecuteNonQuery();
            }
        }

        public static void InsertLabTemplateFeeData(int id, int testId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_LabTemplateFeeData", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TemplateID", id);
                cmd.Parameters.AddWithValue("TestID", testId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteLabTemplateFeeData(int id, int testId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_LabTemplateFeeData", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TemplateID", id);
                cmd.Parameters.AddWithValue("TestID", testId);

                cmd.ExecuteNonQuery();
            }
        }

        // Lab Test Assigning Services

        public static DataTable GetAssignedTestsById(int jobId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AppliedTestsById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobNbr", jobId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);

                connection.Close();
                adapter.Dispose();

                return dataTable;
            }
        }

        public static void InsertAppliedTest(AppliedTestObject appliedTestObject)
                
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_AppliedTest", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", (appliedTestObject.JobNbr != 0) ? appliedTestObject.JobNbr : throw new Exception("No JobNbr provided"));
                cmd.Parameters.AddWithValue("SheetNbr", (appliedTestObject.SheetNbr != 0) ? appliedTestObject.SheetNbr : 1);
                cmd.Parameters.AddWithValue("Marked", (appliedTestObject.Marked != null) ? appliedTestObject.Marked : "");
                cmd.Parameters.AddWithValue("Re", (appliedTestObject.Re != null) ? appliedTestObject.Re : "");
                cmd.Parameters.AddWithValue("TestId", (appliedTestObject.TestId != 0) ? appliedTestObject.TestId : throw new Exception("No TestId provided"));
                cmd.Parameters.AddWithValue("TemplateId", (appliedTestObject.TemplateId != 0) ? appliedTestObject.TemplateId : throw new Exception("No TemplateId provided"));
                cmd.Parameters.AddWithValue("Test", (appliedTestObject.Test != null) ? appliedTestObject.Test : "");
                cmd.Parameters.AddWithValue("Astm", (appliedTestObject.Astm != null) ? appliedTestObject.Astm : "");
                cmd.Parameters.AddWithValue("CompBy", (appliedTestObject.CompBy != null) ? appliedTestObject.CompBy : "");
                cmd.Parameters.AddWithValue("Result", (appliedTestObject.Result != null) ? appliedTestObject.Result : "");
                cmd.Parameters.AddWithValue("Spec", (appliedTestObject.Spec.max != 0) ? appliedTestObject.Spec.max : 0);
                cmd.Parameters.AddWithValue("Fee", (appliedTestObject.Fee != 0) ? appliedTestObject.Fee : 0);
                cmd.Parameters.AddWithValue("ReleaseId", (appliedTestObject.ReleaseId != null) ? appliedTestObject.ReleaseId : "");
                cmd.Parameters.AddWithValue("Note", (appliedTestObject.Note != null) ? appliedTestObject.Note : "");

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateAppliedTest(AppliedTestObject appliedTestObject)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_AppliedTestsById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("DtlNbr", appliedTestObject.DtlNbr);
                cmd.Parameters.AddWithValue("JobNbr", appliedTestObject.JobNbr);
                cmd.Parameters.AddWithValue("Marked", appliedTestObject.Marked);
                cmd.Parameters.AddWithValue("Re", appliedTestObject.Re);
                cmd.Parameters.AddWithValue("TestId", appliedTestObject.TestId);
                cmd.Parameters.AddWithValue("Test", appliedTestObject.Test);
                cmd.Parameters.AddWithValue("Astm", appliedTestObject.Astm);
                cmd.Parameters.AddWithValue("CompBy", appliedTestObject.CompBy);
                cmd.Parameters.AddWithValue("Result", appliedTestObject.Result);
                cmd.Parameters.AddWithValue("Spec", appliedTestObject.Spec);
                cmd.Parameters.AddWithValue("Fee", appliedTestObject.Fee);
                cmd.Parameters.AddWithValue("ReleaseId", appliedTestObject.ReleaseId);
                cmd.Parameters.AddWithValue("Note", appliedTestObject.Note);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAppliedTestById(int dtlId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AppliedTestById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("DtlNbr", dtlId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAppliedTestsById(int jobNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AppliedTestsById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);

                cmd.ExecuteNonQuery();
            }
        }

        public static object[] GetAssignedTemplateById(int dtlNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AppliedTemplateById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DtlNbr", dtlNbr);

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

        public static List<object[]> GetAssignedTemplatesById(int jobId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AppliedTemplatesById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobNbr", jobId);

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> assignedTemplates = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    assignedTemplates.Add(values);
                }

                return assignedTemplates;
            }
        }

        public static void InsertAppliedTemplateById(int templateId, int jobId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_AppliedTemplateById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("TemplateId", templateId);
                cmd.Parameters.AddWithValue("JobNbr", jobId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAppliedTemplateById(int dtlId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AppliedTemplateById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("DtlNbr", dtlId);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAppliedTemplatesById(int jobNbr, int templateId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AppliedTemplatesById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("TemplateId", templateId);

                cmd.ExecuteNonQuery();
            }
        }

        // Lab Report Database Services

        public static LabReportHeaderObject GetLabReportHeaderById(int id)
        {
            LabReportHeaderObject labReportHeaderObject = new LabReportHeaderObject() { JobNbr = id };

            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_LabReportHeaderById", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobNbr", id);

                SqlDataReader reader = cmd.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    labReportHeaderObject.JobNbr = id;
                    labReportHeaderObject.LabNumber = reader.GetString(index++);
                    labReportHeaderObject.ReportDate = reader.GetDateTime(index++);
                    labReportHeaderObject.SDA1 = reader.GetString(index++);
                    labReportHeaderObject.SDA2 = reader.GetString(index++);
                    labReportHeaderObject.IdMarks1 = reader.GetString(index++);
                    labReportHeaderObject.IdMarks2 = reader.GetString(index++);
                    labReportHeaderObject.IdMarks3 = reader.GetString(index++);
                    labReportHeaderObject.IdMarks4 = reader.GetString(index++);;
                    labReportHeaderObject.Submitted1 = reader.GetString(index++);
                    labReportHeaderObject.Submitted2 = reader.GetString(index++);
                    labReportHeaderObject.Client1 = reader.GetInt32(index++);
                    labReportHeaderObject.Client2 = reader.GetInt32(index++);
                    labReportHeaderObject.Client3 = reader.GetInt32(index++);
                    labReportHeaderObject.Client4 = reader.GetInt32(index++);
                }

                return labReportHeaderObject;
            }
        }

        public static void InsertLabReportHeader(LabReportHeaderObject reportHeaderObject)
        {
            using(SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_LabReportHeader", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", reportHeaderObject.JobNbr);
                cmd.Parameters.AddWithValue("LabNbr", reportHeaderObject.LabNumber);
                cmd.Parameters.AddWithValue("ReportDate", reportHeaderObject.ReportDate);
                cmd.Parameters.AddWithValue("Sample1", reportHeaderObject.SDA1);
                cmd.Parameters.AddWithValue("Sample2", reportHeaderObject.SDA2);
                cmd.Parameters.AddWithValue("IdMarks1", reportHeaderObject.IdMarks1);
                cmd.Parameters.AddWithValue("IdMarks2", reportHeaderObject.IdMarks2);
                cmd.Parameters.AddWithValue("IdMarks3", reportHeaderObject.IdMarks3);
                cmd.Parameters.AddWithValue("IdMarks4", reportHeaderObject.IdMarks4);
                cmd.Parameters.AddWithValue("Submitted1", reportHeaderObject.Submitted1);
                cmd.Parameters.AddWithValue("Submitted2", reportHeaderObject.Submitted2);
                cmd.Parameters.AddWithValue("Client1", reportHeaderObject.Client1);
                cmd.Parameters.AddWithValue("Client2", reportHeaderObject.Client2);
                cmd.Parameters.AddWithValue("Client3", reportHeaderObject.Client3);
                cmd.Parameters.AddWithValue("Client4", reportHeaderObject.Client4);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateAssignedTestResultsById(int jobNbr, int sheetNbr, int testId, string result, string releaseId, string marked, string compBy)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_AssignedTestResultsById", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("SheetNbr", sheetNbr);
                cmd.Parameters.AddWithValue("TestId", testId);
                cmd.Parameters.AddWithValue("Result", result);
                cmd.Parameters.AddWithValue("ReleaseId", releaseId);
                cmd.Parameters.AddWithValue("Marked", marked);
                cmd.Parameters.AddWithValue("CompBy", compBy);

                cmd.ExecuteNonQuery();
            }
        }

        public static void DeleteAppliedTestsBySheetNbr(int jobNbr, int sheetNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_AppliedTestsBySheetNbr", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("SheetNbr", sheetNbr);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<object[]> GetAppliedTestsBySheetNbr(int jobNbr, int sheetNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AppliedTestsBySheetNbr", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("SheetNbr", sheetNbr);

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> assignedTemplates = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    assignedTemplates.Add(values);
                }

                return assignedTemplates;
            }
        }

        public static List<int> GetWorksheetsByJobNbr(int jobNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                List<int> worksheets = new List<int>();
                SqlCommand cmd = new SqlCommand("Get_WorksheetsByJobNbr", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("JobNbr", jobNbr);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    worksheets.Add(reader.GetInt16(0));
                }

                return worksheets;
            }
        }

        public static List<object[]> GetWorksheetBySheetNbr(int jobNbr, int sheetNbr)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_WorksheetBySheetNbr", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("JobNbr", jobNbr);
                cmd.Parameters.AddWithValue("SheetNbr", sheetNbr);

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> worksheet = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    worksheet.Add(values);
                }

                return worksheet;
            }
        }

        // Lab Specification Repository
        public static void DeleteLabSpecByCustomerIdAndTestId(int customerId, int testId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Delete_LabSpecByCustomerIdAndTestId", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("CustomerId", customerId);
                cmd.Parameters.AddWithValue("TestId", testId);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<object[]> GetAllLabSpecs()
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllLabSpecs", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> specs = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    specs.Add(values);
                }

                return specs;
            }
        }

        public static List<object[]> GetAllLabSpecsByCustomerId(int customerId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_AllLabSpecsByCustomerId", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("CustomerId", customerId);

                SqlDataReader reader = cmd.ExecuteReader();

                List<object[]> specs = new List<object[]>();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    int fieldCount = reader.GetValues(values);

                    specs.Add(values);
                }

                return specs;
            }
        }

        public static object[] GetLabSpecByCustomerIdAndTestId(int customerId, int testId)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Get_LabSpecByCustomerIdAndTestId", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("CustomerId", customerId);
                cmd.Parameters.AddWithValue("TestId", testId);

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

        public static void InsertLabSpec(string testName, int customerId, string specs, int testId, string astm, string min, string max)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Insert_LabSpec", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Product", testName);
                cmd.Parameters.AddWithValue("CustomerId", customerId);
                cmd.Parameters.AddWithValue("Specs", specs);
                cmd.Parameters.AddWithValue("TestId", testId);
                cmd.Parameters.AddWithValue("Astm", astm);
                cmd.Parameters.AddWithValue("Min", min);
                cmd.Parameters.AddWithValue("Max", max);
               
                cmd.ExecuteNonQuery();
            }
        }

        public static void UpdateLabSpec(string testName, int customerId, string specs, int testId, string astm, string min, string max)
        {
            using (SqlConnection connection = new SqlConnection(PCIMSSettings.Default.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Update_LabSpec", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Product", testName);
                cmd.Parameters.AddWithValue("CustomerId", customerId);
                cmd.Parameters.AddWithValue("Specs", specs);
                cmd.Parameters.AddWithValue("TestId", testId);
                cmd.Parameters.AddWithValue("Astm", astm);
                cmd.Parameters.AddWithValue("Min", min);
                cmd.Parameters.AddWithValue("Max", max);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
