using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    class Preference
    {
        public int UserId { get; private set; }
        public string Type { get; private set; }
        public string[] Days { get; private set; }

        public Preference(int userId, string type, string[] days)
        {
            this.Type = type;
            this.Days = days;
            this.UserId = userId;
        }
    }
}
