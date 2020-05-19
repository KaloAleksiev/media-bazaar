using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class DepartmentClass
    {
        //fields
        private int id;
        private string name;

        //Properties
        public int Id
        {get { return this.id; }}

        public string Name
        {
            get { return this.name; }
            set 
            { 
                if (value.Length < 0) 
                {
                    throw new ArgumentException("The name must not be empty") ;
                }
                else
                {
                    this.name = value;
                }
            }
        }

        //Constructor

        public DepartmentClass(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }
    }
}
