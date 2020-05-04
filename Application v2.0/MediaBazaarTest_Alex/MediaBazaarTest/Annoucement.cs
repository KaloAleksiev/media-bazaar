using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
  public  class Annoucement
    { 
        private DateTime startDate;
        private DateTime endDate;
        private User author;
        private int authorID;
        private string title;
        private string text;
        public Annoucement(DateTime startDate, DateTime endDate, string title, string text, User author)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.title = title;
            this.author = author;
            this.text = text;
        }
        private void AddAnnoucemnt( )
        { 

        }
        private void EditAnnoucemnt()
        {

        }
        private void DeleteAnnoucemnt()
        {

        }
    }
}
