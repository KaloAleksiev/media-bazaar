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
    public partial class ShiftHubForm : Form
    {
        DepartmentDictionary dd;
        Dictionary<string, int> deps;
        Month month;
        UserControl uc;
        ShiftDataControl sdc;
        LoadInfoForm frm;

        Dictionary<int, int> shiftTokenDictionary;
        Dictionary<int, Shift[]> allShifts;

        public ShiftHubForm(UserControl uc)
        {
            InitializeComponent();
            this.uc = uc;
            dd = new DepartmentDictionary();
            shiftTokenDictionary = new Dictionary<int, int>();
            allShifts = new Dictionary<int, Shift[]>();
            sdc = new ShiftDataControl();
            deps = dd.GetAllDepartments();
            FillOutDepCB();
            AppendEvents();
            PrepareWindow();
        }

        public void FillOutDepCB()
        {
            foreach (KeyValuePair<string, int> dep in deps)
            { cbDepartment.Items.Add(dep.Key); }
        }

        public void PrepareWindow()
        {
            if (DateTime.Now.Day < 15)
            { cbMonth.SelectedIndex = DateTime.Now.Month - 1; }
            else { cbMonth.SelectedIndex = DateTime.Now.Month; }
            tbYear.Text = DateTime.Now.Year.ToString();
        }

        public void UpdateInfoLabel(object sender, EventArgs e)
        {
            if (tbYear.Text == "" || cbDepartment.SelectedIndex == -1 || cbMonth.SelectedIndex == -1 || cbPosition.SelectedIndex == -1)
            { 
                lblFinalInfo.Text = "";
                btnViewSchedule.Enabled = false;
            }
            else {
                string type;
                if (rbMorning.Checked)
                { type = "Morning"; }
                else if (rbNoon.Checked)
                { type = "Noon"; }
                else { type = "Evening"; }
                lblFinalInfo.Text = $"View schedule for {(Month)(cbMonth.SelectedIndex + 1)} {tbYear.Text} " +
                                    $" for {(Position)(cbPosition.SelectedIndex + 1)}s " +
                                    $"\n of {cbDepartment.SelectedItem} department," +
                                    $" {type} shifts.";
                btnViewSchedule.Enabled = true;
            }
        }

        public void AppendEvents()
        {
            cbMonth.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            cbDepartment.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            cbPosition.SelectedIndexChanged += new EventHandler(UpdateInfoLabel);
            tbYear.TextChanged += new EventHandler(UpdateInfoLabel);
            rbMorning.CheckedChanged += new EventHandler(UpdateInfoLabel);
            rbNoon.CheckedChanged += new EventHandler(UpdateInfoLabel);
            rbEvening.CheckedChanged += new EventHandler(UpdateInfoLabel);
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            ShiftType type;
            if (rbEvening.Checked)
            { type = ShiftType.Evening; }
            else if (rbNoon.Checked)
            { type = ShiftType.Noon; }
            else { type = ShiftType.Morning; }
            DateTime dt = new DateTime(Convert.ToInt32(tbYear.Text), cbMonth.SelectedIndex + 1, 1);
            KeyValuePair<string, int> dep = new KeyValuePair<string, int>((string)cbDepartment.SelectedItem, cbDepartment.SelectedIndex + 1);
            ShiftForm frm = new ShiftForm(dt, dep, (Position)(cbPosition.SelectedIndex + 1), type, uc);
            frm.Show();
        }

        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            CreateStatusForm();
        }

        public void CreateStatusForm()
        {
            ShiftType type;
            if (rbMorning.Checked)
            { type = ShiftType.Morning; }
            else if (rbNoon.Checked)
            { type = ShiftType.Noon; }
            else { type = ShiftType.Evening; }

            frm = new LoadInfoForm(sdc, uc, (Month)cbMonth.SelectedIndex + 1, Convert.ToInt32(tbYear.Text),
                (string)cbDepartment.SelectedItem, cbDepartment.SelectedIndex + 1, type, (Position)(cbPosition.SelectedIndex + 1));
            frm.Show(this);

            frm.FormClosed += new FormClosedEventHandler(btnViewSchedule_Click);
        }
    }
}
