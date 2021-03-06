using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{

    class AnnoucemntDataControl
    {
        UserControl uc = new UserControl();
        private string conectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";

        public void AddAnnoucemntToDB(Annoucement a)
        {
            int id = a.Author.Id;
            MySqlConnection connection = new MySqlConnection(conectionString);
            string query = $"INSERT INTO announcement( title, author_id, start_date, end_date, text, DeparmentID)" +
                  $"VALUES (@title, @author_id, @start_date, @end_date, @text, @DeparmentID)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", a.Title);
            cmd.Parameters.AddWithValue("@author_id", id);
            cmd.Parameters.AddWithValue("@start_date", a.StartDate);
            cmd.Parameters.AddWithValue("@end_date", a.EndDate);
            cmd.Parameters.AddWithValue("@text", a.Text);
            cmd.Parameters.AddWithValue("@DeparmentID", a.DepartmentId);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public Annoucement ReturnAnnoucemntFromDB(string title)
        {
            Annoucement a;
            MySqlConnection connection = new MySqlConnection(conectionString);
            MySqlCommand cmd = new MySqlCommand($"SELECT announcement_id, title, author_id, start_date, end_date, text, DeparmentID  FROM announcement WHERE title = '{title}' ;", connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                int id = Convert.ToInt32(reader["announcement_id"]);
                string aTitle = Convert.ToString(reader["title"]);
                int author_id = Convert.ToInt32(reader["author_id"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime end_date = Convert.ToDateTime(reader["end_date"]);
                string text = Convert.ToString(reader["text"]);
                int department = Convert.ToInt32(reader["DeparmentID"]);
                reader.Close();
                connection.Close();
                a = new Annoucement(startDate, end_date, aTitle, text, author_id, id, department);
                return a;
            }
            reader.Close();
            connection.Close();
            return null;

        }
        public List<Annoucement> ReturnAllAnnoucemntFromDB()
        {
            List<Annoucement> annoucements = new List<Annoucement>();
            MySqlConnection connection = new MySqlConnection(conectionString);
            string query = $"SELECT announcement_id, title, author_id, start_date, end_date, text, DeparmentID FROM announcement ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["announcement_id"]);
                string aTitle = Convert.ToString(reader["title"]);
                int author_id = Convert.ToInt32(reader["author_id"]);
                DateTime startDate = Convert.ToDateTime(reader["start_date"]);
                DateTime end_date = Convert.ToDateTime(reader["end_date"]);
                string text = Convert.ToString(reader["text"]);
                User user = uc.GetUserByID(author_id);
                int department = Convert.ToInt32(reader["DeparmentID"]);
                Annoucement a = new Annoucement(startDate, end_date, aTitle, text, user, department);
                annoucements.Add(a);
            }
            reader.Close();
            connection.Close();
            return annoucements;

        }

        public void UpdateAnnoucemnt(Annoucement a)
        {
            MySqlConnection conn = new MySqlConnection(conectionString);
            string update = $"UPDATE announcement SET title = @title, author_id = @authorid, start_date = @startdate, end_date = @enddate, text = @text, DeparmentID = @department  WHERE announcement_id = @id";
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@title", a.Title);
            cmd.Parameters.AddWithValue("@authorid", a.AuthorID);
            cmd.Parameters.AddWithValue("@startdate", a.StartDate);
            cmd.Parameters.AddWithValue("@enddate", a.EndDate);
            cmd.Parameters.AddWithValue("@text", a.Text);
            cmd.Parameters.AddWithValue("@id", a.ID);
            cmd.Parameters.AddWithValue("@department", a.DepartmentId);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void DeleteAnnoucement(string title)
        {
            MySqlConnection conn = new MySqlConnection(conectionString);
            string update = $"DELETE FROM announcement  WHERE title = @title";
            MySqlCommand cmd = new MySqlCommand(update, conn);
            cmd.Parameters.AddWithValue("@title", title);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
