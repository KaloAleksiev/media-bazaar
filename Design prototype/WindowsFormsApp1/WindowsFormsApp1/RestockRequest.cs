using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RestockRequest
    {
        private int id;
        private Item item;
        private int amount;
        private DepotWorker depotWorker; //Person who made the request.
        private DateTime date;
    }
}
