using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTest
{
    class RestockRequest
    {
        public int Id
        { get; private set; }
        public Item Item
        { get; private set; }
        public int Amount
        { get; private set; }
        public int UserID
        { get; private set; }
        public DateTime Date
        { get; private set; }

        public RestockRequest(Item item, int amount, int userId)
        {
            this.Item = item;
            this.Amount = amount;
            this.UserID = userId;
        }

        public RestockRequest(Item item, int amount, int userId, int id)
        {
            this.Item = item;
            this.Amount = amount;
            this.UserID = userId;
            this.Id = id;
            this.Date = DateTime.Now;
        }
    }
}
