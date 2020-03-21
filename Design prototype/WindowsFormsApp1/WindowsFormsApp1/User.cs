using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
        public int id =0;
        private string firstName;
        private string lastName;
        private string email;
        private string address;
        private string password;
        private string phoneNumber;
      public User(string firstName, string lastname, string email, string address, string phonenumber)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.email = email;
            this.address = address;
            this.phoneNumber = phonenumber;
            id++;
        }
        public int ID()
        { return id; }

        public string FirstName()
        { return firstName; }

        public string LastName()
        { return lastName; }
        public string Email()
        { return email; }
        public string Address()
        { return address; }
        public string PhoneNumber()
        {  return phoneNumber; }

    }
}
