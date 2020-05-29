using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp
{
    public class Stock
    {
        public List<Item> items;

        //Alex
        private StockDataControl sdc;
        public Stock()
        {
            items = new List<Item>();
            //Alex
            sdc = new StockDataControl();
            items = sdc.GetStockFromDB();
        }

        public void AddItem(Item item)
        { items.Add(item); }

        public List<Item> GetAllItems()
        { return this.items; }

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

    }
}

