using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Employee : User
    {
<<<<<<< HEAD
        public static int empNumber;
        private Department department;
        public static double salary = 3000;
=======
        public  int empNumber;
        private Department department;
        public double salary = 3000;
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
        private DateTime startDate;
        public Employee(string firstName, string lastname, string email, string address, string phonenumber, Department department):base(firstName, lastname,email, address, phonenumber)
        {
            empNumber++;
            this.department = department;
            salary = 3000;
<<<<<<< HEAD
=======
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

>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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
