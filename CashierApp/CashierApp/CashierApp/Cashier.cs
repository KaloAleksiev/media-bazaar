using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class Cashier
    {
        //fields
        private int id;
        private string name;
        private string surname;
        private string email;
        private string password;

        //properties
        public int Id { get { return this.id; } }
        public string Name { get {return this.name; } }
        public string Surname { get { return this.surname; } }

        //constructor
        public Cashier(int id, string name, string surname, string email, string pass)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = pass;
        }
    }
}
