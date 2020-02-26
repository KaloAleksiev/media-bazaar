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
            pEmplyee.Visible = true;
            pEmplyee.SetBounds(0, 0,1280, 800);
            btEmployeeE.SetBounds(150,7,150,30);
            btStatisticsE.SetBounds(400, 7, 150, 30);
            btStockE.SetBounds(650, 7, 150, 30);
            btlogoutE.SetBounds(900, 7, 150, 30);

            
        }

    }
}
