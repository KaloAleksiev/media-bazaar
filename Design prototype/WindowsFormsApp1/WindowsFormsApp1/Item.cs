using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace WindowsFormsApp1
{
    public class Item
    {
        private int id;
        //private static int idSeeder = 1000;
        //maybe the Seeder should be set based on the MAX_ID in the Database each time we start the app
        private string name;
        private string description;
        private int amountInStock;
        private bool autoRestock;
        private int arLimit;

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

        public string Name
        {
            get
            {
                return this.name;
            }
            private set { }
        }

        public Item(int id, string name, string description, int amountInStock, bool autoRestock, int arLimit)
        {
            this.name = name;
            this.description = description;
            this.amountInStock = amountInStock;
            this.autoRestock = autoRestock;
            this.arLimit = arLimit;
            this.Id = id;
            //this.Id = idSeeder;
            //idSeeder++;

        }

        public string GetInfo()
        {
            return $"{this.name}(ID - {this.Id}) - {this.description}: amount in stock:{this.amountInStock}";
        }

       
    }
}
