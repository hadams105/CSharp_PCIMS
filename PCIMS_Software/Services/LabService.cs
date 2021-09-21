using PCIMS_Software.Models;
using PCIMS_Software.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PCIMS_Software.Services
{
    public static class LabService
    {
        // Lab Template Services

        public static DataTable GetAllLabTemplateInfo()
        {
            return LabRepository.GetAllLabTemplateInfo();
        }

        public static void DeleteLabTemplateInfoById(int id)
        {
            LabRepository.DeleteLabTemplateInfoById(id);
        }

        public static string GetLabTemplateNameById(int templateId)
        {
            return LabRepository.GetLabTemplateNameById(templateId);
        }

        // Lab Fee Services
        public static object[] GetLabTemplateById(int templateId)
        {
            return LabRepository.GetLabTemplateById(templateId);
        }

        public static DataTable GetAllLabTemplateFees()
        {
            return LabRepository.GetAllLabTemplateFees();
        }

        public static List<int> GetAllTemplateLabFeesById(int id)
        {
            return LabRepository.Get_AllLabTemplateFeesById(id);
        }
        
        public static DataTable GetLabFeesInfoById(int id)
        {
            return LabRepository.GetLabFeesInfoById(id);
        }

        public static void InsertLabFeeInfo(LabFeeObject labFeeObject)
        {
            LabRepository.InsertLabFeeInfo(labFeeObject);
        }

        public static void UpdateLabFeeInfoById(LabFeeObject labFeeObject)
        {
            LabRepository.UpdateLabFeeInfoById(labFeeObject);
        }

        public static void DeleteLabFeeInfoById(int id)
        {
            LabRepository.DeleteLabFeeInfoById(id);
        }

        public static int InsertLabTemplateInfo(string templateName, string re)
        {
            return LabRepository.InsertLabTemplateInfo(templateName, re);
        }

        public static void UpdateLabTemplateInfo(int id, string templateName, string re)
        {
            LabRepository.UpdateLabTemplateInfo(id, templateName, re);
        }

        public static void InsertLabTemplateFeeData(int id, int testId)
        {
            LabRepository.InsertLabTemplateFeeData(id, testId);
        }

        public static void DeleteLabTemplateFeeData(int id, int testId)
        {
            LabRepository.DeleteLabTemplateFeeData(id, testId);
        }

        // Lab Test Assigning Services
        public static DataTable GetAssignedTestsById(int jobId)
        { 
            return LabRepository.GetAssignedTestsById(jobId);
        }

        public static void InsertAppliedTest(AppliedTestObject appliedTestObject)
        {
            LabRepository.InsertAppliedTest(appliedTestObject);
        }

        public static void UpdateAppliedTest(AppliedTestObject appliedTestObject)
        {
            LabRepository.UpdateAppliedTest(appliedTestObject);
        }

        public static void DeleteAppliedTestById(int dtlId)
        {
            LabRepository.DeleteAppliedTestById(dtlId);
        }

        public static void DeleteAppliedTestsById(int dtlId)
        {
            LabRepository.DeleteAppliedTestsById(dtlId);
        }


        public static object[] GetAssignedTemplateById(int dtlNbr)
        {
            return LabRepository.GetAssignedTemplateById(dtlNbr);
        }

        public static List<object[]> GetAssignedTemplatesById(int jobId)
        {
            return LabRepository.GetAssignedTemplatesById(jobId);
        }

        public static void InsertAppliedTemplateById(int templateId, int jobId)
        {
            LabRepository.InsertAppliedTemplateById(templateId, jobId);
        }

        public static void DeleteAppliedTemplateById(int dtlId)
        {
            LabRepository.DeleteAppliedTemplateById(dtlId);
        }

        public static void DeleteAppliedTemplatesById(int jobNbr, int templateId)
        {
            LabRepository.DeleteAppliedTemplatesById(jobNbr, templateId);
        }

        // Lab Report Services

        public static LabReportHeaderObject GetLabReportHeaderById(int id)
        {
            return LabRepository.GetLabReportHeaderById(id);
        }

        public static void InsertLabReportHeader(LabReportHeaderObject reportHeaderObject)
        {
            LabRepository.InsertLabReportHeader(reportHeaderObject);
        }

        // Lab Worksheet Services

        public static void UpdateAssignedTestResultsById(int jobNbr, int sheetNbr, int testId, string result, string releaseId, string marked, string compBy)
        {
            LabRepository.UpdateAssignedTestResultsById(jobNbr, sheetNbr, testId, result, releaseId, marked, compBy);
        }

        public static List<object[]> GetAppliedTestsBySheetNbr(int jobNbr, int sheetNbr)
        {
            return LabRepository.GetAppliedTestsBySheetNbr(jobNbr, sheetNbr);
        }

        public static List<int> GetWorksheetsByJobNbr(int jobNbr)
        {
            return LabRepository.GetWorksheetsByJobNbr(jobNbr);
        }

        public static void DeleteAppliedTestsBySheetNbr(int jobNbr, int sheetNbr)
        {
            LabRepository.DeleteAppliedTestsBySheetNbr(jobNbr, sheetNbr);
        }

        public static List<object[]> GetWorksheetBySheetNbr(int jobNbr, int sheetNbr)
        {
            return LabRepository.GetWorksheetBySheetNbr(jobNbr, sheetNbr);
        }

        // Lab Specification Services

        public static void DeleteLabSpecByCustomerIdAndTestId(int customerId, int testId)
        {
            LabRepository.DeleteLabSpecByCustomerIdAndTestId(customerId, testId);
        }

        public static List<object[]> GetAllLabSpecs()
        {
            return LabRepository.GetAllLabSpecs();
        }

        public static List<object[]> GetAllLabSpecsByCustomerId(int customerId)
        {
            return LabRepository.GetAllLabSpecsByCustomerId(customerId);
        }

        public static object[] GetLabSpecByCustomerIdAndTestId(int customerId, int testId)
        {
            return LabRepository.GetLabSpecByCustomerIdAndTestId(customerId, testId);
        }

        public static void InsertLabSpec(string testName, int customerId, string specs, int testId, string astm, string min, string max)
        {
            LabRepository.InsertLabSpec(testName, customerId, specs, testId, astm, min, max);
        }

        public static void UpdateLabSpec(string testName, int customerId, string specs, int testId, string astm, string min, string max)
        {
            LabRepository.UpdateLabSpec(testName, customerId, specs, testId, astm, min, max);
        }

        // Translation Services

        public static LabTemplateObject RowToLabTemplateObject(DataGridViewRow row)
        {
            LabTemplateObject labTemplateObject = new LabTemplateObject();

            labTemplateObject.TemplateID = Convert.ToInt32(row.Cells["templateID"].Value);
            labTemplateObject.TemplateName = row.Cells["templateName"].Value.ToString();
            labTemplateObject.Re = row.Cells["re"].Value.ToString();

            return labTemplateObject;
        }

        public static LabFeeObject RowToLabFeeObject(DataGridViewRow row)
        {
            LabFeeObject labFeeObject = new LabFeeObject();

            labFeeObject.TestID = int.Parse(row.Cells["testID"].Value.ToString());
            labFeeObject.TestDesc = row.Cells["testDesc"].Value.ToString();
            labFeeObject.Fee = decimal.Parse(row.Cells["fee"].Value.ToString());
            labFeeObject.ASTM = row.Cells["astm"].Value.ToString();

            return labFeeObject;
        }

        public static LabFeeObject FormToLabFeeObject(int id, string testDesc, string astm, decimal fee)
        {
            LabFeeObject labFeeObject = new LabFeeObject();

            labFeeObject.TestID = id;
            labFeeObject.TestDesc = testDesc;
            labFeeObject.Fee = fee;
            labFeeObject.ASTM = astm;

            return labFeeObject;
        }
    }
}
