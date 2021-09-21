using PCIMS_Software.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Services
{
    public static class InvoiceService
    {
        public static List<object[]> GetInvoiceRowsByJobNumber(int jobNbr)
        {
            return InvoiceRepository.GetInvoiceRowsByJobNumber(jobNbr);
        }

        public static void InsertUpdateInvoiceRow(int jobNbr, string serviceCode, string serviceDesc, int quantity, decimal cost, decimal total)
        {
            InvoiceRepository.InsertUpdateInvoiceRow(jobNbr, serviceCode, serviceDesc, quantity, cost, total);
        }

        public static int GetInvoiceNumber(int jobNbr, int customerId, string jobDate)
        {
            return InvoiceRepository.GetInvoiceNumber(jobNbr, customerId, jobDate);
        }

        public static void InsertInvoiceNumber(int jobNbr, int customerId, string jobDate)
        {
            InvoiceRepository.InsertInvoiceNumber(jobNbr, customerId, jobDate);
        }

        public static void DeleteInvoiceRowByJobNbrAndServiceCode(int jobNbr, string serviceCode)
        {
            InvoiceRepository.DeleteInvoiceRowByJobNbrAndServiceCode(jobNbr, serviceCode);
        }
    }
}
