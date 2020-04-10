using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class Stock
    {
        private string name;
        public List<Item> items;
        public List<RestockRequest> rrs;
        public Stock(string name)
        {
            items = new List<Item>();
            rrs = new List<RestockRequest>();
            this.name = name;
        }

        public void AddItem(Item item)
        { items.Add(item); }

        public List<Item> GetAllItems()
        { return items; }

        public List<RestockRequest> GetAllRequests()
        { return rrs; }

        public Item GetItemById(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == id)
                { return items[i]; }
            }
            return null;
        }

        public Item GetItemByName(string name)
        {
            foreach (Item i in items)
            {
                if (i.Name == name)
                { return i; }
            }
            return null;
        }

        public string GetStockInfo()
        {
            string returnStr = "";
            foreach (Item i in items)
            { returnStr += $"{i.GetInfo()} \n"; }
            return returnStr;
        }

        public void AddAllStock(List<Item> i)
        { items = i; }

        public RestockRequest CreateRequest(Item item, int amount, int userId)
        {
            RestockRequest rr = new RestockRequest(item, amount, userId);
            rrs.Add(rr);
            return rr;

        }
    }
}
