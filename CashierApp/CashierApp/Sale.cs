using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class Sale
    {
        private int id;
        private double totalPrice;
        private int userId;
        private DateTime date;
        private Dictionary<Item, int> items;

        public int Id { get { return this.id; } }
        public double Price { get { return this.totalPrice; } }
        public int UserId { get { return this.userId; } }
        public DateTime Date {get { return this.date; } }
        

        public Sale(int id, int userId, Dictionary<Item, int> s)
        {
            items = new Dictionary<Item, int>();
            this.id = id;
            this.userId = userId;
            foreach(KeyValuePair<Item, int> entry in s)
            {
                this.items.Add(entry.Key, entry.Value);
                entry.Key.reduceAmount(entry.Value);
                totalPrice += entry.Key.Price * entry.Value;
            }
            this.date = DateTime.Now;
        }

        public Dictionary<Item, int> GetItems()
        {
            return this.items;
        }

    }
}
