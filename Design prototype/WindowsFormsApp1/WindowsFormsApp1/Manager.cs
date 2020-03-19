using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager : User
    {
        public Manager(string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
         
        }
        public int ManagerId
        { get; set; }
        public Item[] ViewStock()
        {
            return Stock.items.ToArray();
        }
        public Employee[] ViewEmplyee()
        {
            List<Employee> emplyees = new List<Employee>();
            foreach (Employee emplyee in ControlClass.users.OfType<Employee>())
            {
                emplyees.Add(emplyee);
            }
            return emplyees.ToArray();
        }
      
        //public string ViewEmplyeeStats()
        //{
        //    string emplyeestats = "";
        //    return emplyeestats;
        //}

    }
}
