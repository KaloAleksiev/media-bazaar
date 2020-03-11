using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RestockRequest
    {
        private int id;
        private static int idSeeder = 1000;
        private Item item;
        private int amount;
        private DepotWorker depotWorker; //Person who made the request.
        private DateTime date;

        public int Id
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }

        public RestockRequest(Item item, int amount, DepotWorker depotWorker, DateTime date)
        {
            this.item = item;
            this.amount = amount;
            this.depotWorker = depotWorker;
            this.date = date;
            this.Id = idSeeder;
            idSeeder++;
        }

        public string GetInfo()
        {
            return $"Restock Request {this.Id}, {this.item} x{this.amount}, made by {this.depotWorker} on {this.date}.";
        }
    }
}
