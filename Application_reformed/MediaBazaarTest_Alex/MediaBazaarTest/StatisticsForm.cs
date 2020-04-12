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
        public StatisticsForm()
        {
            InitializeComponent();
            sdc = new StatsDataControl();           
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            //Add data to the CMBs
            cmbDepSalary.DataSource = Enum.GetValues(typeof(Department));
            cmbDepCount.DataSource = Enum.GetValues(typeof(Department));

            //Empty the CMBs
            cmbDepCount.SelectedItem = null;
            cmbDepSalary.SelectedItem = null;

            //Handle Panels
            pDepStats.Visible = false;
        }

        private void btShowAvgSalaryPerDep_Click(object sender, EventArgs e)
        {
            Department dep;
            if (cmbDepSalary.SelectedItem != null)
            {
                Enum.TryParse<Department>(cmbDepSalary.SelectedValue.ToString(), out dep);
                double salary = sdc.GetAvgSalaryPerDepartment(dep);
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
            ClearChart();
            Department dep;
            if (cmbDepCount.SelectedItem != null)
            {
                Enum.TryParse<Department>(cmbDepCount.SelectedValue.ToString(), out dep);
                List<int> count = sdc.GetPostitionCountPerDep(dep);
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

        private void DepartmentStats_Click(object sender, EventArgs e)
        {
            if(pDepStats.Visible == false)
            {
                pDepStats.Visible = true;
            }
            else
            {
                pDepStats.Visible = false;
                ClearChart();
            }
        }

        private void ClearChart()
        {
            foreach (var series in chartEmployees.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
