using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Statistics
    {
        List<RestockRequest> restockRequests;

        public Statistics()
        {
            restockRequests = new List<RestockRequest>();
        }

        public void AddRequest(RestockRequest request)
        {
            restockRequests.Add(request);
        }

        public List<RestockRequest> GetAllRequests()
        {
            return restockRequests;
        }
    }
}
