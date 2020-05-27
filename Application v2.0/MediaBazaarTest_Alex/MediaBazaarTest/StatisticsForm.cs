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
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            //Add data to the CMBs
            //cmbDepSalary.DataSource = Enum.GetValues(typeof(Department));
            //cmbDepCount.DataSource = Enum.GetValues(typeof(Department));
            foreach(KeyValuePair<string, int> d in dd.GetAllDepartmentsFromDB())
            {
                cmbDepCount.Items.Add(d.Key);
                cmbDepSalary.Items.Add(d.Key);
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
                //Enum.TryParse<Department>(cmbDepSalary.SelectedValue.ToString(), out dep);
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

        private void UpdateItemsListBox()
        {
            lbItemStats.Items.Clear();
            foreach(Item i in stock.GetAllItems())
            {
                lbItemStats.Items.Add(i.Name);
            }
        }

        #endregion

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
    }
}
