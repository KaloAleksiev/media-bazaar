﻿using System;
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

namespace WindowsFormsApp1
{
    public partial class ScheduleForm : Form
    {
        int b = 15;
        int posX = 15;
        int posY = 102;
        int allHeight = 26;
        int lbWidth = 35;
        int btnWidth = 50;
        List<Label> dynamicLabels;
        List<Button> dynamicButtons;
        DateTime dt;
        string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        MySqlConnection conn;
        List<Shift> shifts;
        List<User> AllPpl;
        List<User> InShift;


        public ScheduleForm(DateTime dt)
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);
            this.dt = dt;
            dynamicLabels = new List<Label>();
            dynamicButtons = new List<Button>();
            lblMonth.Text = dt.ToString("dd.MM.yy");
            AlignAll();
            shifts = new List<Shift>();
            AllPpl = new List<User>();
            InShift = new List<User>();
            createSchedule(dt);
        }

        public void createSchedule(DateTime dt)
        {
            posX += lbWidth;
            for (int j = 0; j < b; j++)
            {
                Button dynamicButton = new Button();
                dynamicButton.Location = new Point(posX, posY);
                dynamicButton.Height = allHeight;
                dynamicButton.Width = btnWidth;
                dynamicButton.BackColor = Color.White;
                dynamicButton.ForeColor = Color.Black;
                dynamicButton.FlatStyle = FlatStyle.Flat;

                int n = 1;

                if (j >= 0 && j < 3)
                {
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    Department dep = Department.Manager;
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    reader1.Close();
                    conn.Close();
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else { dynamicButton.BackColor = Color.Red; }
                    shifts.Add(new Shift(dt, st, dep));
                    dynamicButton.Text = n + " / 1";
                }
                else if (j >= 3 && j < 6)
                {
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    Department dep = Department.DepotWorker;
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    reader1.Close();
                    conn.Close();
                    dynamicButton.Text = n + " / 2";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 2)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(dt, st, dep));
                }
                else if (j >= 6 && j < b)
                {
                    ShiftType st = ShiftType.Morning;
                    if (j % 3 == 0)
                    { st = ShiftType.Morning; }
                    else if (j % 3 == 1)
                    { st = ShiftType.Noon; }
                    else if (j % 3 == 2)
                    { st = ShiftType.Evening; }
                    Department dep = Department.Phones;
                    if (j >= 6 && j < 9)
                    { dep = Department.Phones; }
                    else if (j >= 9 && j < 12)
                    { dep = Department.Computers; }
                    else if (j >= 15 && j < b)
                    { dep = Department.Phones; }
                    MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND department = '" + dep.ToString() + "')", conn);
                    conn.Open();
                    MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                    reader1.Read();
                    n = Convert.ToInt32(reader1["EN"]);
                    reader1.Close();
                    conn.Close();
                    dynamicButton.Text = n + " / 3";
                    if (n == 0)
                    { dynamicButton.BackColor = Color.Green; }
                    else if (n == 3)
                    { dynamicButton.BackColor = Color.Red; }
                    else { dynamicButton.BackColor = Color.Yellow; }
                    shifts.Add(new Shift(dt, st, dep));
                }
                dynamicButton.Name = "j" + j;
                dynamicButton.Font = new Font("Microsoft Sans Serif", 8);
                dynamicButton.Click += new EventHandler(DynamicButton_Click);
                dynamicButtons.Add(dynamicButton);
                Controls.Add(dynamicButton);
                posX += btnWidth;
            }
            posX = 15;
            posY += allHeight;

            posX = 15;
            posY = 102;
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            char[] arBtnName = clickedButton.Name.ToCharArray();
            MessageBox.Show(clickedButton.Name);
            ShiftPicked(dt, GetIdOutOfBtn(arBtnName));
        }

        public void ShiftPicked(DateTime dt, int j)
        {
            lbShiftInfo.Text = $"{shifts[j].Type} shift in the {shifts[j].Department} department. Date: {dt.ToString("dd.MM.yyyy")}";
            FillDBByDept(shifts[j].Department);
            pShift.Visible = true;
        }

        public void FillDBByDept(Department dep)
        {
            lbAllPpl.Items.Clear();
            List<User> emps = new List<User>();
            foreach (Employee emp in AllPpl)
            {
                if (emp.Department == dep)
                { emps.Add(emp); }
            }
            foreach (Employee emp in emps)
            { lbAllPpl.Items.Add(emp.GetInfo()); }
            AllPpl = emps;
        }

        public int GetIdOutOfBtn(char[] arBtnName)
        {
            int first = 0;
            for (int i = 0; i < arBtnName.Length; i++)
            {
                if (arBtnName[i] == 'j')
                {
                    string l = null;
                    int j = i + 1;
                    while (j < arBtnName.Length)
                    {
                        l += arBtnName[j].ToString();
                        j++;
                    }
                    first = Convert.ToInt32(l);
                }
            }
            return first;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(1);
            Form1.CreateScheduleForm(dt); ;
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            dt = dt.AddDays(-1);
            Form1.CreateScheduleForm(dt); ;
            this.Close();
        }

        public Month GetMonth(DateTime dt)
        {
            Month month = Month.January;
            switch (dt.Month)
            {
                case (1): month = Month.January; break;
                case (2): month = Month.February; break;
                case (3): month = Month.March; break;
                case (4): month = Month.April; break;
                case (5): month = Month.May; break;
                case (6): month = Month.June; break;
                case (7): month = Month.July; break;
                case (8): month = Month.August; break;
                case (9): month = Month.September; break;
                case (10): month = Month.October; break;
                case (11): month = Month.November; break;
                case (12): month = Month.December; break;
            }
            return month;
        }

        public void AlignAll()
        {
            this.Width = 870;
            this.Height = 500;
            btnNext.Width = 150;
            btnNext.Height = 27;
            btnNext.Location = new Point(500, 9);
            btnPrevious.Width = 150;
            btnPrevious.Height = 27;
            btnPrevious.Location = new Point(200, 9);
            lblMonth.Width = 150;
            lblMonth.Height = 27;
            lblMonth.Location = new Point(350, 9);

            int posYfixed = 50;

            List<Label> labels = new List<Label>();
            foreach (Control obj in Controls)
            {
                if (obj is Label)
                {
                    if (obj.Name != "lblMonth")
                    { labels.Add((Label)obj); }
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                labels[i].Location = new Point(150 + ((i - 1) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 6; i <= 10; i++)
            {
                labels[i].Location = new Point(100 + ((i - 6) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 11; i <= 15; i++)
            {
                labels[i].Location = new Point(50 + ((i - 11) * 150), posYfixed + 26);
                labels[i].Height = 26;
                labels[i].Width = 50;
            }
            for (int i = 16; i < 21; i++)
            {
                labels[i].Location = new Point(50 + ((i - 16) * 150), posYfixed);
                labels[i].Height = 26;
                labels[i].Width = 150;
            }

            pShift.Size = new Size(751, 272);
            pShift.Location = new Point(50, 169);

            lbShiftInfo.Location = new Point(20, 14);

            lbAllPpl.Size = new Size(230, 188);
            lbAllPpl.Location = new Point(20, 75);

            lbInShift.Size = new Size(230, 188);
            lbInShift.Location = new Point(500, 75);

            btnAdd.Size = new Size(150, 27);
            btnAdd.Location = new Point(300, 129);

            btnCancel.Size = new Size(150, 27);
            btnCancel.Location = new Point(300, 228);

            btnConfirm.Size = new Size(150, 27);
            btnConfirm.Location = new Point(300, 195);

            btnRemove.Size = new Size(150, 27);
            btnRemove.Location = new Point(300, 162);

            label22.Location = new Point(17, 55);
            label23.Location = new Point(497, 55);
        }

        public void FillChosenShift()
        {
            lbInShift.Items.Clear();
            foreach (Employee emp in InShift)
            { lbAllPpl.Items.Add(emp.GetInfo()); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InShift.Add(AllPpl[lbAllPpl.SelectedIndex]);
            AllPpl.RemoveAt(lbAllPpl.SelectedIndex);
            foreach (Employee emp in AllPpl)
            { lbAllPpl.Items.Add(emp.GetInfo()); }
            FillChosenShift();
        }
    }
}
