using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee : User
    {
        private int empNumber;
        private Department department;
        private double salary;
        private DateTime startDate;
        public Employee(string firstName, string lastname, string email, string address, string phonenumber, Department department,double salary):base(firstName, lastname,email, address, phonenumber)
        {
            this.department = department;
            this.salary = salary;
        }
        public Item[] ViewStock()
        {
            return Stock.items.ToArray();
        }
    }
}
