using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Manager : User
    {
        private int managerId;
        private double salary;
        private Department department;

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public int ManagerId
        { 
            get { return managerId; }
            set { managerId = value; }
        }

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

        public Manager(int id, string firstName, string lastname, string email, string address, string phonenumber, double salary) : base(id, firstName, lastname, email, address, phonenumber)
        {
            managerId++;
            this.salary = salary;
            this.Department = Department.Manager;
        }

        public Manager(int id, int manager_id, string firstName, string lastname, string email, string address, string phonenumber, double salary) : base(id, firstName, lastname, email, address, phonenumber)
        {
            ManagerId = manager_id;
            this.salary = salary;
            this.Department = Department.Manager;
        }

        public string GetInfo()
        { return $"ID:{GetGottenID()},{base.firstName} {base.lastName}"; }


    }
}
