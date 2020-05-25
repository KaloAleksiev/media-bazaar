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
        DepartmentClass dc;
        Position pos;
        Dictionary<int, ListBox> listBoxes;
        Dictionary<int, List<int>> usersInShift;
        ShiftDataControl sdc;
        UserControl uc;

        public ShiftForm(DateTime dt, DepartmentClass dc, Position pos)
        {
            InitializeComponent();
            this.dt = dt;
            month = (Month)dt.Month;
            this.dc = dc;
            this.pos = pos;
            sdc = new ShiftDataControl();
            uc = new UserControl();
            CreateListBoxDict();
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
                KeyValuePair<int, int> shiftIdToNr = sdc.GetAmntOfUsersInShift(dt, type, pos, dc.Id);
                if (shiftIdToNr.Key == 0)
                {
                    if (pos == Position.Employee)
                    { lb.Value.Items.Add("0 / 3"); }
                    else if (pos == Position.DepotWorker)
                    { lb.Value.Items.Add("0 / 2"); }
                    else { lb.Value.Items.Add("0 / 1"); }
                }
                else 
                {
                    List<int> indexes = sdc.GetIdOfUsersInShift(shiftIdToNr.Key, shiftIdToNr.Value);
                    foreach (int i in indexes)
                    {
                        User u = uc.GetUserByID(i);
                        lb.Value.Items.Add($"ID: {u.Id}, {u.FName} {u.LName}");
                    }
                    usersInShift.Add(lb.Key, indexes);
                }
            }
        }
    }
}
