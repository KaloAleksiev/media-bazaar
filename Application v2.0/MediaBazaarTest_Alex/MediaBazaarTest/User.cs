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
        private string gender;
        private string dep;
        private string department;
        private Position pos;
        private string email;
        private string city;
        private string zipcode;
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
        public string LName { get { return this.lName; } private set { this.lName = value; } }
        public string Department { get { return this.dep; } private set { this.dep = value; } }
        public Position Position { get { return this.pos; } private set { this.pos = value; } }
        public string Email { get { return this.email; } private set { this.email = value; } }
        public string Address { get { return this.address; } private set { this.address = value; } }
        public string City { get { return this.city; } private set { this.city = value; } }
        public string Zipcode { get { return this.zipcode;} private set { this.zipcode = value; } }
        public string Phone { get { return this.phone; } private set { this.phone = value; } }
        public int Rank { get { return this.rank; } private set { this.rank = value; } }
        public double Salary { get { return this.salary; } private set { this.salary = value; } }
        public string Password { get { return this.password; } private set { this.password = value; } }
        public DateTime StartDate { get { return this.startDate; } private set { this.startDate = value; } }
        public DateTime EndDate { get { return this.endDate; } private set { this.endDate = value; } }
        public DateTime BDay { get { return this.bDay; } private set { this.bDay = value; } }
        public string Gender { get { return this.gender; } private set { this.gender = value; } }


        //constructors
        public User(int id, string fname, string surname, string dep, string position, string email, string city, string zipcode, string address, string phone, int rank, double salary, string password, DateTime startDate, DateTime bday, string gender)
        {
            this.Id = id;
            this.FName = fname;
            this.LName = surname;
            this.Email = email;
            this.Address = address;
            this.City = city;
            this.Zipcode = zipcode;
            this.Phone = phone;
            this.Rank = rank;
            this.Salary = salary;
            this.Password = password;
            this.StartDate = startDate;
            this.BDay = bday;
            this.Gender = gender;
            this.Department = dep;            

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

        public User(int id, string fName, string surname, string dep, Position pos, string email, string phone, string city, string zipcode, string address, DateTime bday, string gender)
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
            this.City = city;
            this.Zipcode = zipcode;
            this.Gender = gender;
            this.Rank = 1;
            this.Password = GenerateRandomPass();
            this.StartDate = DateTime.Now.Date;
            this.BDay = bday;
        }
        public string GetInfo()
        {
            return $"{this.fName} {this.lName}:\nDepartment: {this.Department}, Position: {this.Position}, Rank: {this.Rank}, Salary: {this.Salary}";
        }

        public void FireEmployee(DateTime date)
        {
            this.EndDate = date;
        }

        public void ChangeDepartment(string dep)
        {
            this.Department = dep;
        }

        public void ChangePosition(Position pos)
        {
            this.Position = pos;
        }

        public void ChangeRank(int rank)
        {
            this.Rank = rank;
        }

        public void ChangeSalary(double salary)
        {
            this.salary = salary;
        }

        private string GenerateRandomPass()
        {
            int length = 4;
            const string valid = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                User other = (User)obj;
                return (Id == other.Id);
            }
            return false;
        }
    }
}
