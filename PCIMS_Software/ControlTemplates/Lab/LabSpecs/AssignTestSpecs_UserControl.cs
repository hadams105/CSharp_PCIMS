using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCIMS_Software.Services;

namespace PCIMS_Software.ControlTemplates.Lab.LabSpecs
{
    public partial class AssignTestSpecs_UserControl : UserControl
    {
        MainInvoiceForm mainInvoice;
        DataTable dataTable = new DataTable();

        public AssignTestSpecs_UserControl(MainInvoiceForm mainInvoice)
        {
            InitializeComponent();
            this.mainInvoice = mainInvoice;
        }

        private void FillTestSpecs_UserControl_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Product", typeof(string));
            dataTable.Columns.Add("Specs", typeof(string));
            dataTable.Columns.Add("TestId", typeof(int));
            dataTable.Columns.Add("Astm", typeof(string));
            dataTable.Columns.Add("Min", typeof(string));
            dataTable.Columns.Add("Max", typeof(string));

            dataTable.Columns["Product"].ReadOnly = true;
            dataTable.Columns["TestId"].ReadOnly = true;
            dataTable.Columns["Astm"].ReadOnly = true;

            labspecs_datagridview.DataSource = dataTable;

            List<object[]> specs = LabService.GetAllLabSpecsByCustomerId(mainInvoice.GetWorkingJob().CustomerId);

            foreach(object[] spec in specs)
            {
                dataTable.Rows.Add(spec);
            }
        }

        private void labspecs_save_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in labspecs_datagridview.Rows)
            {
                LabService.UpdateLabSpec(row.Cells["Product"].Value.ToString(),
                                         mainInvoice.GetWorkingJob().CustomerId,
                                         row.Cells["Specs"].Value.ToString(),
                                         Convert.ToInt32(row.Cells["TestId"].Value),
                                         row.Cells["Astm"].Value.ToString(),
                                         row.Cells["Min"].Value.ToString(),
                                         row.Cells["Max"].Value.ToString());
            }
        }
    }
}
