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
            //Navigation Bar buttons Bounds
            btEmployee.SetBounds(300, 7, 200, 40);
            btStatistics.SetBounds(500, 7, 200, 40);
            btStock.SetBounds(700, 7, 300, 40);
            btlogout.SetBounds(1000, 7, 200, 40);

            pLogin.Visible = true;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            //pLogin.Bounds = Screen.GetWorkingArea(this);

            //Bounds of Login form and its controls
            pLogin.SetBounds(0, 0, 1280, 800);
            pLogin.BackgroundImage = Image.FromFile(".\\backgroundImages\\login.jpg");
            tbUsername.SetBounds(745,320,200,100);
            tbPassword.SetBounds(745, 373, 200, 100);
            btLogin.SetBounds(745, 405, 200, 30);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Hides all panels and dispaly the only the login panel
            pLogin.Visible = false;
            pStatistics.Visible = false;
            pEmplyee.Visible = true;
            EmployeePanel();
        }

        public void EmployeePanel()
        {
            //Bounds of Employee form and its controls
            pEmplyee.SetBounds(0, 60, 1280, 740);

            label2.SetBounds(180, 150, 80, 60);
            tbName.SetBounds(132, 170, 150, 100);

            label8.SetBounds(170, 210, 150, 100);
            tbAddress.SetBounds(132, 230, 150, 100);

            label9.SetBounds(165, 270, 150, 100);
            cmbDepartment.SetBounds(132, 290, 150, 100);

            label10.SetBounds(160, 330, 150, 100);
            tbFunction.SetBounds(132, 350, 150, 100);

            label11.SetBounds(160, 390, 150, 100);
            tbStartDay.SetBounds(132, 410, 150, 100);

            label12.SetBounds(430, 150, 150, 100);
            tbPhoneNumber.SetBounds(420, 170, 150, 100);

            label16.SetBounds(430, 210, 150, 100);
            tbEmailAddress.SetBounds(420, 230, 150, 100);

            label13.SetBounds(430, 270, 150, 100);
            tbWorkLocation.SetBounds(420, 290, 150, 100);

            label14.SetBounds(450, 330, 150, 100);
            tbSupervisor.SetBounds(420, 350, 150, 100);

            label15.SetBounds(470, 390, 150, 100);
            tbSalary.SetBounds(420, 410, 150, 100);

            label4.SetBounds(700, 175, 200, 100);
            textBox1.SetBounds(750, 170, 200, 100);

            label1.SetBounds(700, 235, 150, 100);
            comboBox1.SetBounds(750, 230, 150, 100);
            btSearchEmployee.SetBounds(960, 167, 200, 33);
            btAddEmployee.SetBounds(150, 450, 400, 40);
            dtpShiftDate.SetBounds(920, 230, 250, 100);
            btAddToSchedule.SetBounds(790, 270, 350, 40);


        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            //Hides all panels and dispaly the only the employee panel
            EmployeePanel();
            pLogin.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
        }
    

        private void btStatistics_Click(object sender, EventArgs e)
        {
            //Hides all panels and displays the only the Statistic panel
            pLogin.Visible = false;
            pEmplyee.Visible = false;
            pStatistics.Visible = true;
            pStock.Visible = false;
            pStatistics.SetBounds(0, 50, 1280, 750);
            //Bounds of Statistics form and its controls
            label5.SetBounds(235, 176, 200, 100);
            tbNameStats.SetBounds(300, 170, 200, 100);
            label6.SetBounds(570, 176, 200, 100);
            cmbDepartmentStats.SetBounds(690, 170, 200, 100);
            btViewDepartmentStats.SetBounds(132, 230, 300, 50);
            btViewStatsOverall.SetBounds(450, 230, 300, 50);
            btViewEmployeeStats.SetBounds(770, 230, 300, 50);

            //btEmployeeStats.SetBounds(150, 7, 150, 30);
          //  btLogoutStats.SetBounds(900, 7, 150, 30);
           // btStockControlStats.SetBounds(650, 7, 150, 30);
          //  btStatisticsStats.SetBounds(400, 7, 150, 30);




            //pEmplyee.Visible = true;
            //pEmplyee.SetBounds(0, 0, 1280, 800);
            //btEmployeeE.SetBounds(150, 7, 150, 30);
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

        private void btStock_Click(object sender, EventArgs e)
        {
            //Hides all panels and display the only the Stock Control panel
            pLogin.Visible = false;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = true;
            pStock.SetBounds(0, 50, 1280, 750);
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            //Hides all panels and takes you back to Login panel
            pLogin.Visible = true;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            pLogin.SetBounds(0, 0, 1280, 800);
           pLogin.BackgroundImage = Image.FromFile(".\\backgroundImages\\login.jpg");
         
        }
    }
    
}
