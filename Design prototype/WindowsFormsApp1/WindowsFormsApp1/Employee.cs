using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee : User
    {
        public static int empNumber;
        private Department department;
        public static double salary = 3000;
        private DateTime startDate;
        public Employee(string firstName, string lastname, string email, string address, string phonenumber, Department department):base(firstName, lastname,email, address, phonenumber)
        {
            empNumber++;
            this.department = department;
            salary = 3000;
        }
        public Item[] ViewStock()
        {
            return Stock.items.ToArray();
        }
    }
}
