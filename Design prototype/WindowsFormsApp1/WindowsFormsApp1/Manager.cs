using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager : User
    {
        public static int managerId ;
        public static double salary;
        public Manager(string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            managerId++;
            salary = 4000;
        }

        public Manager(int id, string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            managerId++;
            salary = 4000;
        }
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
    }
}
