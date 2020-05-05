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
        public DateTime StartDate
        {
            get { return this.startDate; }
        }
        public DateTime EndDate
        {
            get { return this.endDate; }
        }
        public User Author
        {
            get { return this.author; }
        }
        public string Title
        {
            get { return this.title; }
        }
        public string Text
        {
            get { return this.text; }
        }
        
        private void EditAnnoucemnt(string title)
        {

        }
        private void DeleteAnnoucemnt()
        {

        }
        public string ToString()
        {
            return $"{title} : {startDate.ToString("dd MMMM yyyy")} - {endDate.ToString("dd MMMM yyyy")}";

        }

    }
}
