using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager : User
    {       
        private double salary;
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public Manager(int id, string firstName, string lastname, string email, string address, DateTime date, string phonenumber) : base(id, firstName, lastname, email, address, date, phonenumber)
        {
            this.Salary = 4000;
        }
        //public Item[] ViewStock()
        //{
        //    return Stock.items.ToArray();
        //}
        //public Employee[] ViewEmplyee()
        //{
        //    List<Employee> emplyees = new List<Employee>();
        //    foreach (Employee emplyee in ControlClass.users.OfType<Employee>())
        //    {
        //        emplyees.Add(emplyee);
        //    }
        //    return emplyees.ToArray();
        //}
    }
}
