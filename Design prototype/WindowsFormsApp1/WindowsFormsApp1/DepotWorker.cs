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
        public static double salary ;
        private DateTime startDate;
        public DepotWorker(string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            depoNumber++;
            salary = 2000;
        }

        public DepotWorker(int id, string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {
            depoNumber++;
            salary = 2000;
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
