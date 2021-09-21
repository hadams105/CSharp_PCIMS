using PCIMS_Software.Models;
using PCIMS_Software.Repositories;
using PCIMS_Software.Services.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace PCIMS_Software.Services
{
	public static class CustomerService
	{

		public static DataTable GetAllCustomers()
		{
			return CustomerRepository.GetAllCustomers();
		}

		public static CustomerObject GetCustomerById(int id)
		{
			return CustomerRepository.GetCustomerById(id);
		}

		public static DataTable GetAllCompanyNames()
		{
			return CustomerRepository.GetAllCompanyNames();
		}

        public static string GetCompanyNameById(int id)
        {
            return CustomerRepository.GetCompanyNameById(id);
        }

        public static string InsertCustomerInfo(CustomerObject customerObject)
		{
			return CustomerRepository.InsertCustomerInfo(customerObject);
		}

		public static string UpdateCustomerById(CustomerObject customerObject)
		{
			return CustomerRepository.UpdateCustomerById(customerObject);
		}

		public static string DeleteCustomerById(int id)
		{
			return CustomerRepository.DeleteCustomerById(id);
		}
	}
}
