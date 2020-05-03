using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarTest
{
    public partial class StockForm : Form
    {
        Stock s;
        StockDataControl sdc;
        int j = 0;
        UserControl uc;

        public StockForm(UserControl userControl)
        {
            InitializeComponent();
            sdc = new StockDataControl();
            s = new Stock("this");
            uc = userControl;
            s.AddAllStock(sdc.GetStockFromDB());
            dgvStock.AutoGenerateColumns = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.MultiSelect = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStock.RowTemplate.MinimumHeight = 54;
            ShowStock();
        }

        public void ShowStock()
        {
            dgvStock.Rows.Clear();
            int k = 0;
            for (int i = 0; i < s.GetAllItems().Count; i++)
            {
                Item item = s.GetAllItems()[i];
                dgvStock.Rows.Add(new string[]
                                      {   item.Id.ToString(),
                                          item.Name,
                                          item.Description.Replace(",", ",\n"),
                                          item.Department,
                                          item.AmountInStock.ToString()
                                      });
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (Item i in s.GetAllItems())
            {
                if (i.Id == Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value))
                {
                    RestockForm frm = new RestockForm(i, s, uc.GetLoggedIn());
                    frm.Show();
                }
            }
        }
    }
}
