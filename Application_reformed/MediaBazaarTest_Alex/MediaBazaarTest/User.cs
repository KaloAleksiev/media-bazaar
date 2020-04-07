using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace MediaBazaarTest
{
    public class User
    {
        //instance variables         
        private int id;
        private string fName;
        private string lName;
        private Department dep;
        private Position pos;
        private string email;
        private string address;
        private string phone;
        private int rank;
        private double salary;
        private string password;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime bDay;

        //properties
        public int Id { get { return this.id; } private set { this.id = value; } }
        public string FName { get { return this.fName; } private set { this.fName = value; } }
        public string LName { get { return this.lName; }private set { this.lName = value; } }
        public Department Department { get { return this.dep; } private set { this.dep = value; } }
        public Position Position { get { return this.pos; } private set {this.pos = value; } }
        public string Email { get { return this.email; } private set {this.email = value; } }
        public string Address { get { return this.address; } private set { this.address = value; } }
        public string Phone { get { return this.phone; } private set {this.phone = value; } }
        public int Rank { get { return this.rank; } private set { this.rank = value; } }
        public double Salary { get { return this.salary; } private set { this.salary = value; } }
        public string Password { get { return this.password; } private set { this.password = value; } }
        public DateTime StartDate { get { return this.startDate; } private set { this.startDate = value; } }
        public DateTime EndDate { get { return this.endDate; } private set { this.endDate = value;} }
        public DateTime BDay { get { return this.bDay; } private set { this.bDay = value; } }


        //constructors
        public User(int id, string fname, string surname, int dep, string position, string email, string address, string phone, int rank, double salary, string password, DateTime startDate, DateTime endDate, DateTime bday)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = surname;
            this.Email = email;
            this.Address = address;
            this.Phone = phone;
            this.Rank = rank;
            this.Salary = salary;
            this.Password = password;
            this.StartDate = startDate;
            this.BDay = bday;
            if(endDate != null)
            {
                this.EndDate = endDate;
            }
            switch (dep)
            {
                case 1:                  
                    this.Department = Department.Computers;
                    break;
                case 2:
                    this.Department = Department.TVs;
                    break;
                case 3:
                    this.Department = Department.Phones;
                    break;
            }
            switch (position)
            {
                case "Administrator":
                    this.Position = Position.Administrator;
                    break;
                case "Manager":
                    this.Position = Position.Manager;
                    break;
                case "DepotWorker":
                    this.Position = Position.DepotWorker;
                    break;
                case "Employee":
                    this.Position = Position.Employee;
                    break;

            }
        }

        public User(int id,string fName, string surname, Department dep, Position pos, string email, string phone, string address, DateTime bday)
        {
            this.Id = id;
            this.FName = fName;
            this.LName = surname;
            this.Department = dep;
            this.Position = pos;
            switch (pos)
            {
                case Position.Administrator:
                    this.Salary = 5000;
                    break;
                case Position.Manager:
                    this.Salary = 4500;
                    break;
                case Position.DepotWorker:
                    this.Salary = 3500;
                    break;
                default:
                    this.Salary = 3000;
                    break;
            }
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Rank = 1;
            this.Password = Membership.GeneratePassword(4, 0);
            this.StartDate = DateTime.Now.Date;
            this.BDay = bday;
        }

        public string GetInfo()
        {
            return $"{this.fName} {this.lName}, department: {this.Department.ToString()}, ID: {this.Id}";
        }
    }
}
