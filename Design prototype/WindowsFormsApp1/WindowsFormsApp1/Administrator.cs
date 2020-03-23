using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Administrator : User
    {
        Statistics stats = new Statistics();
        private int adminNumber;
        public Administrator(string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {

        }

        public Administrator(int id, string firstName, string lastname, string email, string address, string phonenumber) : base(firstName, lastname, email, address, phonenumber)
        {

        }


        public RestockRequest[] ViewRestockREquest()
        {
            return stats.GetAllRequests().ToArray();   
        }
        public void AssignToDepartment()
        {
            
        }
        public void EditSchedule()
        {
            
        }
    }
}
