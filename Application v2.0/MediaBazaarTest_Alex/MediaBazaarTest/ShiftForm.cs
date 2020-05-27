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
        Position pos;
        KeyValuePair<string, int> dep;
        DepartmentDictionary dd;
        Dictionary<int, ListBox> listBoxes;
        Dictionary<int, List<int>> usersInShift;
        ShiftDataControl sdc;
        UserControl uc;

        public ShiftForm(DateTime dt, KeyValuePair<string, int> dep, Position pos, ShiftType type)
        {
            InitializeComponent();
            this.dt = dt;
            month = (Month)dt.Month;
            this.dep = dep;
            this.pos = pos;
            listBoxes = new Dictionary<int, ListBox>();
            usersInShift = new Dictionary<int, List<int>>();
            sdc = new ShiftDataControl();
            uc = new UserControl();
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
        }

        public void FillOutShifts(ShiftType type)
        {
            foreach (KeyValuePair<int, ListBox> lb in listBoxes)
            {
                DateTime shiftDate = dt.AddDays(lb.Key - 1);
                KeyValuePair<int, int> shiftIdToNr = sdc.GetAmntOfUsersInShift(shiftDate, type, pos, dep.Value);
                lb.Value.Items.Add(CreateFirstLine(pos, shiftIdToNr.Value));
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
    }
}
