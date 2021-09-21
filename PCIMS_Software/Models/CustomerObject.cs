using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIMS_Software.Models
{
	public class CustomerObject
	{
		public string CompanyName { get; set; }
		public int CustomerId { get; set; }
		public string ContactFirstName { get; set; }
		public string ContactLastName { get; set; }
		public string CompanyOrDepartment { get; set; }
		public string SortOrder { get; set; }
		public string BillingAddress { get; set; }
		public string BillingAddress2 { get; set; }
		public string City { get; set; }
		public string StateOrProvince { get; set; }
		public string PostalCode { get; set; }
		public string Country { get; set; }
		public string ContactTitle { get; set; }
		public string PhoneNumber { get; set; }
		public string Extension { get; set; }
		public string FaxNumber { get; set; }
		public string EmailAddress { get; set; }
		public string Notes { get; set; }
	}
}
