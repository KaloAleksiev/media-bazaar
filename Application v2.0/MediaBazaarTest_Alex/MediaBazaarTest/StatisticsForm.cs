//using CashierApp;
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
    public partial class StatisticsForm : Form
    {
        private StatsDataControl sdc;
        private Stock stock;
        private DepartmentDictionary dd;

        public StatisticsForm()
        {
            InitializeComponent();
            sdc = new StatsDataControl();
            stock = new Stock("Lmao");
            dd = new DepartmentDictionary();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            //Add data to the CMBs
            //cmbDepSalary.DataSource = Enum.GetValues(typeof(Department));
            //cmbDepCount.DataSource = Enum.GetValues(typeof(Department));
            foreach(KeyValuePair<string, int> d in dd.GetAllDepartments())
            {
                cmbDepCount.Items.Add(d.Key);
                cmbDepSalary.Items.Add(d.Key);
                cmbDepSalesStats.Items.Add(d.Key);
            }

            //Empty the CMBs
            cmbDepCount.SelectedItem = null;
            cmbDepSalary.SelectedItem = null;

            //Handle Panels
            pDepStats.Visible = false;
            pItemStats.Visible = false;

            //loadStock            
            UpdateItemsListBox();

        }
        #region DepartmentStats
        private void btShowAvgSalaryPerDep_Click(object sender, EventArgs e)
        {
            string dep = null;
            if (cmbDepSalary.SelectedItem != null)
            {               
                dep = cmbDepSalary.SelectedValue.ToString();
                int depId = dd.GetIdByName(dep);
                double salary = sdc.GetAvgSalaryPerDepartment(depId);
                MessageBox.Show($"Avarage salary for {dep} department is {salary.ToString("C2")}");
                cmbDepSalary.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Please select a department!");
            }           
        }

        private void btAvgSalaryOverall_Click(object sender, EventArgs e)
        {
            double salary = sdc.GetAvarageSalaryOverall();
            MessageBox.Show($"Avarage salary for the store is {salary.ToString("C2")}");
        }

        private void btShowEmpCountPerDep_Click(object sender, EventArgs e)
        {
            ClearDepChart();
            string dep = null;
            if (cmbDepCount.SelectedItem != null)
            {
                //Enum.TryParse<Department>(cmbDepCount.SelectedValue.ToString(), out dep);
                dep =cmbDepCount.SelectedValue.ToString();
                int depId = dd.GetIdByName(dep);
                List<int> count = sdc.GetPostitionCountPerDep(depId);
                chartEmployees.Series["Employee count"].Points.AddXY("Administrator", count[0]);
                chartEmployees.Series["Employee count"].Points.AddXY("Manager", count[1]);
                chartEmployees.Series["Employee count"].Points.AddXY("DepotWorker", count[2]);
                chartEmployees.Series["Employee count"].Points.AddXY("Employee", count[3]);
                
            }
            else
            {
                MessageBox.Show("Please select a department!");
            }
            cmbDepCount.SelectedItem = null;
        }
        #endregion

        #region Navigation
        private void DepartmentStats_Click(object sender, EventArgs e)
        {
            if(pDepStats.Visible == false)
            {
                pDepStats.Visible = true;
                pItemStats.Visible = false;
            }
            else
            {
                pDepStats.Visible = false;
                ClearDepChart();
            }
        }

        private void ItemStats_Click(object sender, EventArgs e)
        {
            if(pItemStats.Visible == false)
            {
                pItemStats.Visible = true;
                pDepStats.Visible = false;
                //load chart
                List<int> count = sdc.GetItemsCountPerDepartment();
                chartItems.Series["count"].Points.AddXY("Phones", count[0]);
                chartItems.Series["count"].Points.AddXY("Computers", count[0]);
                chartItems.Series["count"].Points.AddXY("TVs", count[0]);
            }
            else
            {
                pItemStats.Visible = false;
                ClearItemChart();
            }
        }

        private void btSalesStats_Click(object sender, EventArgs e)
        {
            if(pSalesStats.Visible == false)
            {
                pSalesStats.Visible = true;
                pItemStats.Visible = false;
                pDepStats.Visible = false;
                //load chart
                UserControl uc = new UserControl();
                Dictionary<User, int> users = new Dictionary<User, int>();
                foreach (KeyValuePair<int, int> pair in sdc.GetBestEmployees())
                {
                    users.Add(uc.GetUserByID(pair.Key), pair.Value);
                }
                for (int i = 0; i < 5; i++)
                {
                    if(users.Count > i)
                    {
                        chTopEmpSales.Series["sales"].Points.AddXY($"{users.ElementAt(i).Key.FName} {users.ElementAt(i).Key.LName}",users.ElementAt(i).Value);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                pSalesStats.Visible = false;
                ClearEmpChart();
            }
        }
        #endregion

        #region Controls
        private void ClearDepChart()
        {
            foreach (var series in chartEmployees.Series)
            {
                series.Points.Clear();
            }
        }

        private void ClearItemChart()
        {
            foreach (var series in chartItems.Series)
            {
                series.Points.Clear();
            }
        }

        private void ClearEmpChart()
        {
            foreach (var series in chTopEmpSales.Series)
            {
                series.Points.Clear();
            }
        }

        private void UpdateItemsListBox()
        {
            lbItemStats.Items.Clear();
            foreach(Item i in stock.GetAllItems())
            {
                lbItemStats.Items.Add(i.Name);
            }
        }

        #endregion

        #region SaleStats
        private void btShowItemStats_Click(object sender, EventArgs e)
        {
            if(lbItemStats.SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                Item i = stock.GetItemByName(lbItemStats.SelectedItem.ToString());
                MessageBox.Show(sdc.GetItemStats(i));
            }
        }

        

        private void btShowRevenue_Click(object sender, EventArgs e)
        {           
            if (cmbDepSalesStats.SelectedItem == null)
            {
                MessageBox.Show("Please select a department!");
            }
            else
            {
                string dep = cmbDepSalesStats.SelectedItem.ToString();
                int depId = dd.GetIdByName(dep);
                string info = $"Revenue for {dep} department is {(sdc.GetRevenuePerDep(depId)).ToString("C2")}";
                MessageBox.Show(info);
            }
        }

        private void btTopItemsSold_Click(object sender, EventArgs e)
        {
            Dictionary<Item, int> topItems = new Dictionary<Item, int>();
            foreach (KeyValuePair<int, int> pair in sdc.GetBestSellingItems())
            {
                topItems.Add(stock.GetItemById(pair.Key), pair.Value);
            }
            string info = "";
            for (int i = 0; i < 5; i++)
            {               
                info += $"\n{topItems.ElementAt(i).Key.Name} - amount: {topItems.ElementAt(i).Value}";
                info += $"\n_____________________________";
            }
            MessageBox.Show(info);
        }
        #endregion
    }
}
