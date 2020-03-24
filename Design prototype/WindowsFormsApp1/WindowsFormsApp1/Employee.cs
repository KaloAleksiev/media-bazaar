using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee : User
    {
        private  int empNumber;
        private Department department;
        public double salary = 3000;
        private DateTime startDate;
        public Employee(string firstName, string lastname, string email, string address, string phonenumber, Department department):base(firstName, lastname,email, address, phonenumber)
        {
            empNumber++;
            this.department = department;
            salary = 3000;
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
        { get; private set; }

        public int EmpNumber
        {
            get { return empNumber; }
            private set { empNumber = value; }
        }

        public string GetInfo()
        { return $"ID:{GetGottenID()}, Emp. №: {this.empNumber}. {base.firstName} {base.lastName}"; }
    }
}
