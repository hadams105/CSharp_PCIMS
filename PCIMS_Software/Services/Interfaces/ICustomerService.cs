using PCIMS_Software.Models;
using System.Data;

namespace PCIMS_Software.Services.Interfaces
{
	public interface ICustomerService
	{
		DataTable GetAllCustomers();
		CustomerObject GetCustomerById(int id);
		string InsertCustomerInfo(CustomerObject customerObject);
		string UpdateCustomerById(CustomerObject customerObject);
		string DeleteCustomerById(int id);
	}
}
