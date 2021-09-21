using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCIMS_Software.Services.Utilities
{
	public static class Utilities
	{
		public static Control FindControlByName(Form form, string name)
		{
			if (form.Controls.Find(name, true).Length == 1)
				return form.Controls.Find(name, true)[0];
			else
				return null;
		}

		public static void ClearForm(Control control)
		{
			if (control.HasChildren)
			{
				foreach (Control subControl in control.Controls)
				{
					ClearForm(subControl);
				}
			}
			switch (control.GetType().Name)
			{
				case "TextBox":
					TextBox textBox = (TextBox)control;
					textBox.Text = null;
					break;

				case "ComboBox":
					ComboBox comboBox = (ComboBox)control;
					if (comboBox.Items.Count > 0)
						comboBox.SelectedIndex = 0;
					break;

				case "CheckBox":
					CheckBox checkBox = (CheckBox)control;
					checkBox.Checked = false;
					break;

				case "ListBox":
					ListBox listBox = (ListBox)control;
					listBox.ClearSelected();
					break;

				case "NumericUpDown":
					NumericUpDown numericUpDown = (NumericUpDown)control;
					numericUpDown.Value = 0;
					break;

				case "DateTimePicker":
					DateTimePicker dateTimePicker = (DateTimePicker)control;
					dateTimePicker.Value = DateTime.Now;
					break;
			}
		}

		//public static void RefreshDataGridView(DataGridView datagridview)
		//{
		//	datagridview.DataSource = CustomerService.GetAllCustomers();
		//}

		public static void ClearSelections(DataGridView datagridview)
		{
			foreach (DataGridViewRow row in datagridview.SelectedRows)
			{
				row.Selected = false;
			}
		}
	}
}
