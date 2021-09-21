using PCIMS_Software.ControlTemplates.Invoice;
using PCIMS_Software.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCIMS_Software.Forms
{
    public partial class PriceSelectForm : Form
    {
        DataTable PriceTable = new DataTable();
        Invoice_UserControl invoice;

        public PriceSelectForm(Invoice_UserControl invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
        }

        private void PriceSelectForm_Load(object sender, EventArgs e)
        {
            PriceTable.Columns.Add("ServiceCode", typeof(string));
            PriceTable.Columns.Add("ServiceDesc", typeof(string));
            PriceTable.Columns.Add("Amount", typeof(decimal));
            PriceTable.Columns.Add("MinCharge", typeof(decimal));

            priceselect_datagridview.DataSource = PriceTable;

            priceselect_datagridview.Columns[2].DefaultCellStyle.Format = "c";
            priceselect_datagridview.Columns[3].DefaultCellStyle.Format = "c";

            LoadData();
        }

        private void LoadData()
        {
            PriceTable.Clear();

            List<object[]> prices = PriceService.GetAllPrices();

            foreach (object[] price in prices)
            {
                PriceTable.Rows.Add(price);
            }
        }

        private void priceselect_add_btn_Click(object sender, EventArgs e)
        {
            List<object[]> pricesToAdd = new List<object[]>();
            foreach (DataGridViewRow row in priceselect_datagridview.SelectedRows)
            {
                List<object> values = new List<object>();
                foreach (DataGridViewCell cell in row.Cells)
                    values.Add(cell.Value);

                pricesToAdd.Add(values.ToArray());
            }

            invoice.AddPricesToTable(pricesToAdd);

            this.Close();
        }
    }
}
