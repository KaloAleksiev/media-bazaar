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
        private Stock s;
        public Form1()
        {
            InitializeComponent();

            //Navigation Bar buttons Bounds
            btEmployee.SetBounds(130, 7, 200, 40);
            btSchedule.SetBounds(340, 7, 200, 40);
            btStatistics.SetBounds(540, 7, 200, 40);
            btStock.SetBounds(740, 7, 300, 40);
            btlogout.SetBounds(1040, 7, 200, 40);

            pLogin.Visible = true;
            pEmplyee.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            //pLogin.Bounds = Screen.GetWorkingArea(this);

            //Bounds of Login form and its controls
            pLogin.SetBounds(0, 0, 1280, 800);
            tbUsername.SetBounds(745,320,200,100);
            tbPassword.SetBounds(745, 373, 200, 100);
            btLogin.SetBounds(745, 405, 200, 30);

            //variable initialization
            s = new Stock("Stock");
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

            label2.SetBounds(180, 70, 80, 60);
            tbName.SetBounds(132, 90, 150, 100);
            label8.SetBounds(170, 120, 150, 100);
            tbAddress.SetBounds(132, 140, 150, 100);
            label9.SetBounds(165, 170, 150, 100);
            cmbDepartment.SetBounds(132, 190, 150, 100);

            label12.SetBounds(430, 70, 150, 100);
            tbLastName.SetBounds(420, 90, 150, 100);
            label16.SetBounds(430, 120, 150, 100);
            tbEmailAddress.SetBounds(420, 140, 150, 100);
            label13.SetBounds(430, 170, 230, 100);
            tbPhoneNumber.SetBounds(420, 190, 150, 100);

            btAddEmployee.SetBounds(150, 220, 400, 40);

            label4.SetBounds(200, 280, 400, 40);
            textBox1.SetBounds(160, 300, 200, 100);
            label1.SetBounds(430, 280, 150, 100);
            comboBox1.SetBounds(410, 300, 150, 100);
            btAssignToDepartment.SetBounds(150, 340, 400, 40);

            label10.SetBounds(210, 390,100,40);
            tbNamePromote.SetBounds(150, 410, 200, 40);
            btPromote.SetBounds(150, 440,400,40);
            lbEmployee.SetBounds(700, 50, 400, 550);

        }

        private void btEmployee_Click(object sender, EventArgs e)
        {
            //Hides all panels and dispaly the only the employee panel
            EmployeePanel();
            pLogin.Visible = false;
            pStatistics.Visible = false;
            pStock.Visible = false;
            pEmplyee.Visible = true;
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
        }

        #region Stock
        private void btCheckAvailability_Click(object sender, EventArgs e)
        {           
            try{
                

            }
            catch
            {

            }
        }

        private void btViewStockEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btSendRestockRequest_Click(object sender, EventArgs e)
        {
            try{
                RestockRequestForm r = new RestockRequestForm(Convert.ToInt32(tbItemIDRestock.Text));
                r.Show(this);
            }
            catch
            {
                MessageBox.Show("Please enter an Intager value for ID");
            }
           
        }
        #endregion

        private void btAddEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btSchedule_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int third = 1;
            if (dt.Day > 0 && dt.Day <= 10)
            { third = 1; }
            else if (dt.Day > 10 && dt.Day <= 20)
            { third = 2; }
            else if (dt.Day > 20 && dt.Day <= 32)
            { third = 3; }
            CreateScheduleForm(dt.AddDays(-(dt.Day - 1) + 10 * (third - 1)), third);
        }

        public static void CreateScheduleForm(DateTime dt, int third)
        {
            ScheduleForm frm = new ScheduleForm(dt, third);
            frm.Show();
        }
    }

}
