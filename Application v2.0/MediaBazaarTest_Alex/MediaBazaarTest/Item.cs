using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class Item
    {
        private int id;
        private string name;
        private string description;
        private string department;
        private int amountInStock;
        private bool autoRestock;
        private int arLimit;
        private double sellingPrice;
        private double restockPrice;

        public int Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { name = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public string Department
        {
            get { return department; }
            private set { department = value; }
        }

        public int AmountInStock
        {
            get { return amountInStock; }
            set { amountInStock = value; }
        }

        public bool AutoRestock
        {
            get { return autoRestock; }
            private set { autoRestock = value; }
        }
        public int ARLimit
        {
            get { return arLimit; }
            private set { arLimit = value; }
        }

        public double Sprice { get { return this.sellingPrice; } }
        public double Rprice{ get { return this.restockPrice; }}


        public Item(int id, string name, string description, string department, int amountInStock, bool autoRestock, int arLimit, double sellingPrice, double restockPrice)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.AmountInStock = amountInStock;
            this.Department = department;
            this.autoRestock = autoRestock;
            this.ARLimit = arLimit;
            this.sellingPrice = sellingPrice;
            this.restockPrice = restockPrice;
        }
        public Item(int id, string name, string description, string department, int amountInStock, bool autoRestock, int arLimit)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.AmountInStock = amountInStock;
            this.Department = department;
            this.autoRestock = autoRestock;
            this.ARLimit = arLimit;            
        }

        public string GetInfo()
        { return $"x{this.amountInStock} \t {this.name}"; }

        public string GetItemNames()
        { return $"{this.name}"; }

        public void ToggleAutoRequest()
        { AutoRestock = !AutoRestock; }

        public void ChangeARLimit(int arLimit)
        { this.ARLimit = arLimit; }

        public void UpdateItem(string name, string desc, string dept)
        {
            this.Name = name;
            this.Description = desc;
            this.Department = dept;
        }

        public string GetDetailedInfo()
        { return $"x{this.amountInStock} \t {this.name} \t {this.description} \t Auto-restock limit: {this.arLimit}"; }
    }
}
