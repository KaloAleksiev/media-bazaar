using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarTest
{
    public class AnnoucementControl
    {
        Annoucement toedit;
        AnnoucemntDataControl dc;
        List<Annoucement> list = new List<Annoucement>();
        public AnnoucementControl()
        {
            dc = new AnnoucemntDataControl();
            list = GetAllAnnoucemnts();
           
        }
        public List<Annoucement> GetAllAnnoucemnts()
        {
            list= dc.ReturnAllAnnoucemntFromDB();
            return list;
        }
        public string GetToEditTitle()
        {
            return toedit.Title;
        }
        public void NewAnnoucement(DateTime startDate, DateTime endDate, string title, string text, User author, int department)
        {
            Annoucement annoucement = new Annoucement( startDate,  endDate,  title,  text,  author,  department);
            dc.AddAnnoucemntToDB(annoucement);
        }
        public void DeleteAnnoucemnt(string title)
        {
            dc.DeleteAnnoucement(title);
        }

       public void EditAnnoucement(string title, string text, DateTime startdate, DateTime enddate, int department)
        {
            toedit.ChangeTitle(title);
            toedit.ChangeText(text);
            toedit.ChangeStartDate(startdate);
            toedit.ChangeEndDate(enddate);
            toedit.ChangeDepartment(department);
            dc.UpdateAnnoucemnt(toedit);
        }
        public Annoucement GetToBeEditedAnnoucemnt(string title)
        {
            toedit = dc.ReturnAnnoucemntFromDB(title);
            return toedit;
        }
        
    }
}
