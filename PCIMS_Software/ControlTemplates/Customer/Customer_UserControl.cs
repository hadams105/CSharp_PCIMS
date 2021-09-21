using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PCIMS_Software.Models;
using PCIMS_Software.ControlTemplates.Base;
using PCIMS_Software.Services;
using PCIMS_Software.Services.Utilities;

namespace PCIMS_Software.ControlTemplates.Customer
{
	public partial class Customer_UserControl : UserControl //: Base_UserControl
	{
		private bool isEditing = false;
		private int currentIndex;

		public Customer_UserControl()
		{
			InitializeComponent();
		}

		private void Customer_UserControl_Load(object sender, EventArgs e)
		{
            RefreshDataGridView();
		}

		private void customer_clear_btn_Click(object sender, EventArgs e)
		{
			ClearForm(customer_form_panel);
			Utilities.ClearSelections(customer_datagridview);
		}

		private void customer_add_btn_Click(object sender, EventArgs e)
		{
			CustomerObject customerObject = new CustomerObject();

			customerObject.CompanyName = customer_companyname.Text;

			string[] name_arr = SplitName(customer_name.Text);
			if(name_arr == null) { return; } 

			customerObject.ContactFirstName = name_arr[0];
			customerObject.ContactLastName = name_arr[1];

			customerObject.CompanyOrDepartment = customer_companydepartment.Text;
			customerObject.SortOrder = customer_sortorder.Text;
			customerObject.BillingAddress = customer_billingaddress.Text;
			customerObject.BillingAddress2 = customer_billingaddress2.Text;
			customerObject.City = customer_city.Text;
			customerObject.StateOrProvince = customer_stateprovince.Text;
			customerObject.PostalCode = customer_postalcode.Text;
			customerObject.Country = customer_country.Text;
			customerObject.ContactTitle = customer_title.Text;
			customerObject.PhoneNumber = customer_phonenumber.Text;
			customerObject.Extension = customer_extension.Text;
			customerObject.FaxNumber = customer_faxnumber.Text;
			customerObject.EmailAddress = customer_emailaddress.Text;
			customerObject.Notes = customer_notes.Text;

			CustomerService.InsertCustomerInfo(customerObject);
            RefreshDataGridView();

			ClearForm(customer_form_panel);
		}

		private void customer_delete_btn_Click(object sender, EventArgs e)
		{
			if (customer_datagridview.SelectedRows.Count == 1)
			{
				DialogResult dialogResult = MessageBox.Show("Would you like to delete row: " + customer_datagridview.SelectedRows[0].Cells["customerID"].Value.ToString() + 
															" " + customer_datagridview.SelectedRows[0].Cells["companyName"].Value.ToString() + "?", 
															"Delete Customer Information?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					foreach (DataGridViewRow row in customer_datagridview.SelectedRows)
					{
						CustomerService.DeleteCustomerById(int.Parse(row.Cells["customerID"].Value.ToString()));
					}

                    RefreshDataGridView();
				}
			}
			else
			{
				DialogResult dialogResult = MessageBox.Show("Would you like to delete " + customer_datagridview.SelectedRows.Count + " rows?",
					"Delete Customer Information?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					foreach (DataGridViewRow row in customer_datagridview.SelectedRows)
					{
						CustomerService.DeleteCustomerById(int.Parse(row.Cells["customerID"].Value.ToString()));
					}

                    RefreshDataGridView();
				}
			}
		}

		private void customer_edit_btn_Click(object sender, EventArgs e)
		{
			if(customer_datagridview.SelectedRows.Count == 1)
			{
				isEditing = true;

				DataGridViewRow row = customer_datagridview.SelectedRows[0];
				currentIndex = row.Index;

				customer_companyname.Text = row.Cells["companyName"].Value.ToString();
				customer_name.Text = row.Cells["contactFirstName"].Value.ToString() + " " + row.Cells["contactLastName"].Value.ToString();
				customer_companydepartment.Text = row.Cells["companyOrDepartment"].Value.ToString();
				customer_sortorder.Text = row.Cells["sortOrder"].Value.ToString();
				customer_billingaddress.Text = row.Cells["billingAddress"].Value.ToString();
				customer_billingaddress2.Text = row.Cells["billingAddress2"].Value.ToString();
				customer_city.Text = row.Cells["city"].Value.ToString();
				customer_stateprovince.Text = row.Cells["stateOrProvince"].Value.ToString();
				customer_postalcode.Text = row.Cells["postalCode"].Value.ToString();
				customer_country.Text = row.Cells["country"].Value.ToString();
				customer_title.Text = row.Cells["contactTitle"].Value.ToString();
				customer_phonenumber.Text = row.Cells["phoneNumber"].Value.ToString();
				customer_extension.Text = row.Cells["extension"].Value.ToString();
				customer_faxnumber.Text = row.Cells["faxNumber"].Value.ToString();
				customer_emailaddress.Text = row.Cells["emailAddress"].Value.ToString();
				customer_notes.Text = row.Cells["notes"].Value.ToString();

				customer_add_btn.Enabled = false;
				customer_delete_btn.Enabled = false;
				customer_save_btn.Enabled = true;
			}
		}

		private void customer_save_btn_Click(object sender, EventArgs e)
		{
			int customerId = int.Parse(customer_datagridview.SelectedRows[0].Cells["customerID"].Value.ToString());

			CustomerObject customerObject = new CustomerObject();

			customerObject.CustomerId = customerId;
			customerObject.CompanyName = customer_companyname.Text;

			string[] name_arr = SplitName(customer_name.Text);
			if (name_arr == null) { return; }

			customerObject.ContactFirstName = name_arr[0];
			customerObject.ContactLastName = name_arr[1];

			customerObject.CompanyOrDepartment = customer_companydepartment.Text;
			customerObject.SortOrder = customer_sortorder.Text;
			customerObject.BillingAddress = customer_billingaddress.Text;
			customerObject.BillingAddress2 = customer_billingaddress2.Text;
			customerObject.City = customer_city.Text;
			customerObject.StateOrProvince = customer_stateprovince.Text;
			customerObject.PostalCode = customer_postalcode.Text;
			customerObject.Country = customer_country.Text;
			customerObject.ContactTitle = customer_title.Text;
			customerObject.PhoneNumber = customer_phonenumber.Text;
			customerObject.Extension = customer_extension.Text;
			customerObject.FaxNumber = customer_faxnumber.Text;
			customerObject.EmailAddress = customer_emailaddress.Text;
			customerObject.Notes = customer_notes.Text;

			CustomerService.UpdateCustomerById(customerObject);
            RefreshDataGridView();

			ClearForm(customer_form_panel);
			customer_add_btn.Enabled = true;
			customer_save_btn.Enabled = false;

			isEditing = false;
		}

		private void customer_datagridview_SelectionChanged(object sender, EventArgs e)
		{
			if (!isEditing)
			{ 
				if (customer_datagridview.SelectedRows.Count == 0)
				{
					customer_edit_btn.Enabled = false;
					customer_delete_btn.Enabled = false;
				}
				else if (customer_datagridview.SelectedRows.Count == 1)
				{
					customer_edit_btn.Enabled = true;
					customer_delete_btn.Enabled = true;
				}
				else
				{
					customer_edit_btn.Enabled = false;
					customer_delete_btn.Enabled = true;
				}
			}
			else
			{
				foreach(DataGridViewRow row in customer_datagridview.Rows)
				{
					if (!row.Index.Equals(currentIndex))
						row.Selected = false;
					else
						row.Selected = true;
				}				
			}
		}

		private void customer_search_btn_Click(object sender, EventArgs e)
		{
			//string searchValue = customer_searchbar.Text;
			//customer_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			//try
			//{
			//	bool valueResult = false;
			//	foreach (DataGridViewRow row in customer_datagridview.Rows)
			//	{
			//		for (int i = 0; i < row.Cells.Count; i++)
			//		{
			//			if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Equals(searchValue))
			//			{
			//				int rowIndex = row.Index;
			//				customer_datagridview.Rows[rowIndex].Selected = true;
			//				valueResult = true;
			//				break;
			//			}
			//		}

			//	}
			//	if (!valueResult)
			//	{
			//		MessageBox.Show("Unable to find " + customer_searchbar.Text, "Not Found");
			//		return;
			//	}
			//}
			//catch (Exception exc)
			//{
			//	MessageBox.Show(exc.Message);
			//}
		}

		/*
			Potential generic utilies methods
			 */

		private void ClearForm(Control control)
		{
			Utilities.ClearForm(control);

			customer_add_btn.Enabled = true;
			customer_edit_btn.Enabled = false;
			customer_delete_btn.Enabled = false;
			customer_save_btn.Enabled = false;
		}

		private bool? ValidateForm()
		{
			// TO-DO
			return null;
		}

        public void RefreshDataGridView()
        {
            customer_datagridview.DataSource = CustomerService.GetAllCustomers();
        }

        private string[] SplitName(string _name)
		{
			string name = _name.Trim();
			string[] name_arr = name.Split(' ');
			string[] result = new string[2];

			if (name_arr.Length == 2)
			{
				return name_arr;
			}
			else if (name_arr.Length > 2)
			{
				string fname = "";

				for (int i = 0; i < name_arr.Length - 1; i++)
				{
					fname += name_arr[i] + " ";
				}
				result[0] = fname;
				result[1] = name_arr[name_arr.Length - 1];

				return result;
			}
			else
			{
				MessageBox.Show("Please enter a valid name.", "Invalid Name");
				return null;
			}

		}
	}
}
