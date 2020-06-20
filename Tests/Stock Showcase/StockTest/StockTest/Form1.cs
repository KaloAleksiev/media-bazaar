using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StockTest
{
    public partial class Form1 : Form
    {
        Stock s;
        StockDataControl sdc;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
            sdc = new StockDataControl();
            s = new Stock("this");
            s.AddAllStock(sdc.GetStockFromDB());
            dgvStock.AutoGenerateColumns = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.MultiSelect = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStock.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStock.RowTemplate.MinimumHeight = 54;
            ShowStock(j);
        }

        public void ShowStock(int n)
        {
            dgvStock.Rows.Clear();
            int k = 0;
            if (5 + n * 5 > s.GetAllItems().Count)
            { k = s.GetAllItems().Count; }
            else { k = 5 + 5 * n; }
            for (int i = 1 + 5 * n; i <= k; i++)
            {
                Item item = s.GetAllItems()[i - 1];
                dgvStock.Rows.Add(new string[] 
                                      {   item.Id.ToString(),
                                          item.Name, 
                                          item.Description.Replace(",", ",\n"),
                                          item.Department, 
                                          item.AmountInStock.ToString()
                                      });
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt32(tbNr.Text);
            j++;
            tbNr.Text = j.ToString();
            if (5 + Convert.ToInt32(tbNr.Text) * 5 > s.GetAllItems().Count)
            { btnNext.Enabled = false; }
            btnBack.Enabled = true;
            ShowStock(j - 1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            j = Convert.ToInt32(tbNr.Text);
            j--;
            tbNr.Text = j.ToString();
            if (tbNr.Text == "1")
            { btnBack.Enabled = false; }
            btnNext.Enabled = true;
            ShowStock(j - 1);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            foreach (Item i in s.GetAllItems())
            {
                if (i.Id == Convert.ToInt32(dgvStock.SelectedRows[0].Cells[0].Value))
                {
                    RestockForm frm = new RestockForm(i, s);
                    frm.Show();
                }
            }
        }
    }
}
