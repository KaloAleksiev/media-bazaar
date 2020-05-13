using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
  public  class Annoucement
    {
        private AnnoucemntDataControl adc = new AnnoucemntDataControl();
        private DateTime startDate;
        private DateTime endDate;
        private User author;
        private string title;
        private string text;
        private int id;
        private int authorId;
        public Annoucement(DateTime startDate, DateTime endDate, string title, string text, User author)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.title = title;
            this.author = author;
            this.text = text;
        }
        public Annoucement(DateTime startDate, DateTime endDate, string title, string text, int authorid, int id)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.title = title;
            this.authorId = authorid;
            this.text = text;
            this.id = id;
        }
        public DateTime StartDate
        {
            get { return this.startDate; }
            private set { this.startDate = value; }
        }
    
        
        public DateTime EndDate
        {
            get { return this.endDate; }
            private set { this.endDate = value; }
        }
        public User Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }
        public string Title
        {
            get { return this.title; }
            private set { this.title = value; }
        }
        public string Text
        {
            get { return this.text; }
            private set { this.text = value; }
        }
        public int ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }
        public int AuthorID
        {
            get { return this.authorId; }
            private set { this.authorId = value; }
        }

        public void ChangeTitle(string title)
        {
            this.Title = title;
        }
        public void ChangeText(string text)
        {
            this.Text = text;
        }
        public void ChangeStartDate(DateTime start)
        {
            this.StartDate = start;
        }
        public void ChangeEndDate(DateTime end)
        {
            this.EndDate = end;
        }
       


        public string ToString()
        {
            return $"{title} : {startDate.ToString("dd MMMM yyyy")} - {endDate.ToString("dd MMMM yyyy")}";

        }

    }
}
