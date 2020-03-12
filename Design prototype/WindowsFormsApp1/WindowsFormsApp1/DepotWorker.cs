using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DepotWorker : User
    {
        private int empNumber;
        private double salary;
        private DateTime startDate;
        public DepotWorker(string firstName, string lastname, string email, string address, string phonenumber, double salary) : base(firstName, lastname, email, address, phonenumber)
        {
            this.salary = salary;
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
