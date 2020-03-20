using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Stock
    {
        private string name;
        public static List<Item> items;

        public Stock(string name)
        {
            items = new List<Item>();
            this.name = name;
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public List<Item> GetAllItems()
        {
            return items;
        }

        public Item GetItemById(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id == id)
                {
                    return items[i];
                }
            }
            return null;
        }

        public string GetStockInfo()
        {
            string returnStr = "";
            foreach (Item i in items)
            {
                returnStr += $"{i.GetInfo()} \n";
            }
            return returnStr;
        }


    }
}
