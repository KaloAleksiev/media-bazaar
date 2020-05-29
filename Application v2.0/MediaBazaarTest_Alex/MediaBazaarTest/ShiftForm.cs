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
    public partial class ShiftForm : Form
    {
        DateTime dt;
        Month month;
        int year;
        int days;
        Position pos;
        ShiftType type;
        KeyValuePair<string, int> dep;
        DepartmentDictionary dd;
        Dictionary<int, ListBox> listBoxes;
        Dictionary<int, List<int>> usersInShift;
        Dictionary<ListBox, Label> listBoxesToLabels;
        ShiftDataControl sdc;
        UserControl uc;

        public ShiftForm(DateTime dt, KeyValuePair<string, int> dep, Position pos, ShiftType type, UserControl uc)
        {
            InitializeComponent();
            this.dt = dt;
            month = (Month)dt.Month;
            year = dt.Year;
            days = DateTime.DaysInMonth(year, (int)month);
            this.dep = dep;
            this.type = type;
            this.pos = pos;
            listBoxes = new Dictionary<int, ListBox>();
            usersInShift = new Dictionary<int, List<int>>();
            listBoxesToLabels = new Dictionary<ListBox, Label>();
            sdc = new ShiftDataControl();
            this.uc = uc;
            lblInfo.Text = $"Schedule for {month.ToString()} {year} for {pos.ToString()}s of {dep.Key} department, {type.ToString()} shifts.";
            CreateListBoxDict();
            FillOutShifts(type);
        }

        public void CreateListBoxDict()
        {
            foreach (Control obj in Controls)
            {
                if (obj is ListBox)
                { listBoxes.Add(Convert.ToInt32(obj.Name.TrimStart("lbDay".ToCharArray())), (ListBox)obj); } 
            }
            AssignLabelToListBox();
        }

        public void AssignLabelToListBox()
        {
            foreach (KeyValuePair<int, ListBox> lb in listBoxes)
            {
                foreach (Control obj in Controls)
                {
                    if (obj is Label && obj.Name.TrimStart("lblDay".ToCharArray()) == lb.Value.Name.TrimStart("lbDay".ToCharArray()))
                    { listBoxesToLabels.Add(lb.Value, (Label)obj); }
                }
            }
            AssignMethodsToLabels();
        }

        public void FillOutShifts(ShiftType type)
        {
            if (days < listBoxes.Count)
            {
                for (int i = days; i <= listBoxes.Count; i++)
                { 
                    listBoxes[i].Visible = false;
                    listBoxes[i].Enabled = false;
                    listBoxesToLabels[listBoxes[i]].Visible = false;
                    listBoxesToLabels[listBoxes[i]].Enabled = false;
                }
            }
            foreach (KeyValuePair<int, ListBox> lb in listBoxes)
            {
                DateTime shiftDate = dt.AddDays(lb.Key - 1);
                KeyValuePair<int, int> shiftIdToNr = sdc.GetAmntOfUsersInShift(shiftDate, type, pos, dep.Value);
                lb.Value.Items.Add(CreateFirstLine(pos, shiftIdToNr.Value));
                ChangeLabelColor(pos, shiftIdToNr.Value, lb.Value);
                List<int> indexes = sdc.GetIdOfUsersInShift(shiftIdToNr.Key, shiftIdToNr.Value);
                foreach (int i in indexes)
                {
                    User u = uc.GetUserByID(i);
                    lb.Value.Items.Add($"ID: {u.Id}, {u.FName} {u.LName}");
                }
                usersInShift.Add(lb.Key, indexes);
            }
        }

        public void AssignMethodsToLabels()
        {
            foreach (KeyValuePair<ListBox, Label> lbl in listBoxesToLabels)
            { lbl.Value.Click += new EventHandler(EditShift); }
        }

        public void EditShift(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            DateTime selDT = new DateTime(year, (int)month, Convert.ToInt32(lbl.Text));
            //ListBox lb = listBoxesToLabels.FirstOrDefault(x => x.Value == lbl).Key;
            KeyValuePair<int, int> shiftIdToNr = sdc.GetAmntOfUsersInShift(selDT, type, pos, dep.Value);
            int nrOfPeople = usersInShift[Convert.ToInt32(lbl.Text)].Count;
            ShiftAssignmentForm frm;
            if (shiftIdToNr.Key != 0)
            { frm = new ShiftAssignmentForm(uc, selDT, dep, pos, type, nrOfPeople, shiftIdToNr.Key); }
            else { frm = new ShiftAssignmentForm(uc, selDT, dep, pos, type, nrOfPeople); }
            frm.FormClosed += new FormClosedEventHandler(UpdateAllListBoxes);
            frm.Show();
        }

        public void UpdateAllListBoxes(object sender, EventArgs e)
        {
            usersInShift.Clear();
            foreach (KeyValuePair<int, ListBox> lb in listBoxes)
            {
                lb.Value.Items.Clear();
                DateTime shiftDate = dt.AddDays(lb.Key - 1);
                KeyValuePair<int, int> shiftIdToNr = sdc.GetAmntOfUsersInShift(shiftDate, type, pos, dep.Value);
                lb.Value.Items.Add(CreateFirstLine(pos, shiftIdToNr.Value));
                ChangeLabelColor(pos, shiftIdToNr.Value, lb.Value);
                List<int> indexes = sdc.GetIdOfUsersInShift(shiftIdToNr.Key, shiftIdToNr.Value);
                foreach (int i in indexes)
                {
                    User u = uc.GetUserByID(i);
                    lb.Value.Items.Add($"ID: {u.Id}, {u.FName} {u.LName}");
                }
                usersInShift.Add(lb.Key, indexes);
            }
        }

        public string CreateFirstLine(Position pos, int n)
        {
            string text;
            if (pos == Position.Employee)
            { text = $"{n} / 3"; }
            else if (pos == Position.DepotWorker)
            { text = $"{n} / 2"; }
            else { text = $"{n} / 1"; }
            return text;
        }

        public void ChangeLabelColor(Position pos, int n, ListBox lb)
        {
            Label lbl = listBoxesToLabels[lb];
            switch(pos)
            {
                case Position.Employee:
                    if (n == 0)
                    { lbl.BackColor = Color.LimeGreen; }
                    else if (n == 3)
                    { lbl.BackColor = Color.Red; }
                    else { lbl.BackColor = Color.Yellow; }
                    break;
                case Position.DepotWorker:
                    if (n == 0)
                    { lbl.BackColor = Color.LimeGreen; }
                    else if (n == 2)
                    { lbl.BackColor = Color.Red; }
                    else { lbl.BackColor = Color.Yellow; }
                    break;
                default:
                    if (n == 0)
                    { lbl.BackColor = Color.LimeGreen; }
                    else { lbl.BackColor = Color.Red; }
                    break;
            }
        }
    }
}
