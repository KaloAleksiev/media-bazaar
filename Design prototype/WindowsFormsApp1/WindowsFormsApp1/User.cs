using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class User
    {
<<<<<<< HEAD
        public int id =0;
        private string firstName;
        private string lastName;
=======
        public static int id = 0;
        private int gottenID;
        protected string firstName;
        protected string lastName;
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
        private string email;
        private string address;
        private string password;
        private string phoneNumber;

        //public static int Id
        //{ get; set; }

        public User(string firstName, string lastname, string email, string address, string phonenumber)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.email = email;
            this.address = address;
            this.phoneNumber = phonenumber;
            id++;
        }
<<<<<<< HEAD
        public int ID()
        { return id; }

=======
        public User(int id, string firstName, string lastname, string email, string address, string phonenumber)
        {
            this.firstName = firstName;
            this.lastName = lastname;
            this.email = email;
            this.address = address;
            this.phoneNumber = phonenumber;
            this.gottenID = id;
        }
        public int ID()
        { return id; }
        public int GetGottenID()
        { return gottenID; }
>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
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

<<<<<<< HEAD
=======


>>>>>>> c37f1e4a1700676bf83ab4232a7478dc9466a9a2
    }
}
