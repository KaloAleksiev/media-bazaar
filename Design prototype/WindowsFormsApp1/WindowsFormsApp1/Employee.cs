using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee : User
    {
        public  int empNumber;
        private Department department;
        public double salary = 3000;
        private DateTime startDate;
        public Employee(int id, string firstName, string lastname, string email, string address, DateTime date, string phonenumber, Department department) : base(id, firstName, lastname, email, address, date, phonenumber)
        {
            empNumber++;
            this.department = department;
            this.salary = 3000;
        }
        public Employee(int id, int employee_number, string firstName, string lastname, string email, string address, string phonenumber, string department, double salary) : base(id, firstName, lastname, email, address, phonenumber)
        {
            this.empNumber = employee_number;
            switch (department)
            {
                case ("Computers"): this.department = Department.Computers; break;
                case ("TVs"): this.department = Department.TVs; break;
                case ("Phones"): this.department = Department.Phones; break;
            }
            this.salary = salary;

        }
        public Department Department
        { get; set; }

        public Item[] ViewStock()
        {
            return Stock.items.ToArray();
        }

        public string GetInfo()
        { return $"ID:{GetGottenID()}, Emp. №: {this.empNumber}. {base.firstName} {base.lastName}"; }
    }
}
