using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DepotWorker : User
    {
        public static int depoNumber;
        private double salary;
        private DateTime startDate;

        private Department department;

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public DepotWorker(string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            depoNumber++;
            this.Salary = 2000;
            this.Department = Department.DepotWorker;
        }

        public DepotWorker(int id, string firstName, string lastname, string email, string address, string phonenumber, double salary) : base(firstName, lastname, email, address, phonenumber)
        {
            depoNumber++;
            this.Salary = salary;
            this.Department = Department.DepotWorker;
        }

        public DepotWorker(int id, string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            depoNumber++;
            this.Salary = 2000;
            this.Department = Department.DepotWorker;
        }

        public string GetInfo()
        { return $"ID:{GetGottenID()},{base.firstName} {base.lastName}"; }
    }
}
