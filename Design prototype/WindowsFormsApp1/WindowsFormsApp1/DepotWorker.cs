using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DepotWorker : User
    {
        private double salary;
        public static int depoNumber;
        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public DepotWorker(int id, string firstName, string lastname, string email, string address, DateTime date, string phonenumber) : base(id, firstName, lastname, email, address, date, phonenumber)
        {
            this.Salary = 2000;
        }
        public Item[] ViewStock()
        {
            return Stock.items.ToArray();
        }
        public void SendRestockRequest(Item item, int amount, DepotWorker depotWorker, DateTime date)
        {
            RestockRequest request = new RestockRequest( item, amount, depotWorker, date);
        }

    }
}
