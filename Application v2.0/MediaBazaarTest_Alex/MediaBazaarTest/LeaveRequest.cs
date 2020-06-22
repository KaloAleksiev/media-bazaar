using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class LeaveRequest
    {
        private int id;
        private int userId;
        private DateTime startDate;
        private DateTime endDate;
        private bool accepted;

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
        
        public int UserId
        {
            get
            {
                return this.userId;
            }
            private set
            {
                this.userId = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            private set
            {
                this.startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return this.endDate;
            }
            private set
            {
                this.endDate = value;
            }
        }

        public bool Accepted
        {
            get
            {
                return this.accepted;
            }
            private set
            {
                this.accepted = value;
            }
        }

        public LeaveRequest(int id, int userId, DateTime startDate, DateTime endDate, bool accepted)
        {
            this.UserId = userId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Accepted = accepted;
        }

        public void AcceptRequest()
        {
            this.Accepted = true;
        }

        public void DenyRequest()
        {
            this.Accepted = false;
        }
    }
}
