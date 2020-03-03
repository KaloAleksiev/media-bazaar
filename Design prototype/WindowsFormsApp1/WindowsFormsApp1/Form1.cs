using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            pLogin.Visible = true;
            pEmplyee.Visible = false;
           pStatistics.Visible = false;
            pStock.Visible = false;
            // pLogin.Bounds = Screen.GetWorkingArea(this);
            pLogin.SetBounds(0, 0, 1280, 800);
            tbUsername.SetBounds(745,320,200,100);
            tbPassword.SetBounds(745, 373, 200, 100);
            btLogin.SetBounds(745, 405, 200, 30);

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            pLogin.Visible = false;
            pStatistics.Visible = true;
            pStatistics.SetBounds(0, 0, 1280, 800);
            label5.SetBounds(235, 176, 200, 100);
            tbNameStats.SetBounds(300, 170, 200, 100);
            label6.SetBounds(570, 176, 200, 100);
            cmbDepartmentStats.SetBounds(690, 170, 200, 100);
            btViewDepartmentStats.SetBounds(132, 230, 300, 50);
            btViewStatsOverall.SetBounds(450, 230, 300, 50);
            btViewEmployeeStats.SetBounds(770, 230, 300, 50);
            btEmployeeStats.SetBounds(150, 7, 150, 30);
            btLogoutStats.SetBounds(900, 7, 150, 30);
            btStockControlStats.SetBounds(650, 7, 150, 30);
            btStatisticsStats.SetBounds(400, 7, 150, 30);




            //  pEmplyee.Visible = true;
            //pEmplyee.SetBounds(0, 0,1280, 800);
            //btEmployeeE.SetBounds(150,7,150,30);
            //btStatisticsE.SetBounds(400, 7, 150, 30);
            //btStockE.SetBounds(650, 7, 150, 30);
            //btlogoutE.SetBounds(900, 7, 150, 30);
            //tbName.SetBounds(132, 170, 150, 100);
            //tbAddress.SetBounds(132, 230, 150, 100);
            //cmbDepartment.SetBounds(132, 290, 150, 100);
            //tbFunction.SetBounds(132, 350, 150, 100);
            //tbStartDay.SetBounds(132, 410, 150, 100);
            //btAddEmployee.SetBounds(150, 450, 400, 40);
            //tbPhoneNumber.SetBounds(420, 170, 150, 100);
            //tbEmailAddress.SetBounds(420, 230, 150, 100);
            //tbWorkLocation.SetBounds(420, 290, 150, 100);
            //tbSupervisor.SetBounds(420, 350, 150, 100);
            //tbSalary.SetBounds(420, 410, 150, 100);
            //textBox1.SetBounds(750, 170, 200, 100);
            //btSearchEmployee.SetBounds(960, 167, 200, 33);
            //comboBox1.SetBounds(750, 230, 150, 100);
            //dtpShiftDate.SetBounds(920, 230, 250, 100);
            //btAddToSchedule.SetBounds(790, 270, 350, 40);


        }

        private void btStatisticsE_Click(object sender, EventArgs e)
        {
            pStatistics.Visible = true;
        }

       
    }
}
