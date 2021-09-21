using PCIMS_Software.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Services
{
    public class PriceService
    {
        public static List<object[]> GetAllPrices()
        {
            return PriceRepository.GetAllPrices();
        }

        public static object[] GetPriceByServiceCode(string serviceCode)
        {
            return PriceRepository.GetPriceByServiceCode(serviceCode);
        }

        public static void InsertPrice(string serviceCode, string serviceDesc, decimal amount, decimal minCharge)
        {
            PriceRepository.InsertPrice(serviceCode, serviceDesc, amount, minCharge);
        }

        public static void UpdatePriceByServiceCode(string serviceCode, string serviceDesc, decimal amount, decimal minCharge)
        {
            PriceRepository.UpdatePriceByServiceCode(serviceCode, serviceDesc, amount, minCharge);
        }

        public static void DeletePriceByServiceCode(string serviceCode)
        {
            PriceRepository.DeletePriceByServiceCode(serviceCode);
        }
    }
}
