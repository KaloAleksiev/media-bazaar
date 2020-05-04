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
        private string conectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
        public void AddAnnoucemntToDB(DateTime startDate, DateTime endDate, string title, string text, int authorId)
        {
            MySqlConnection connection = new MySqlConnection(conectionString);
            string query = $"INSERT INTO announcement( title, author_id, start_date, end_date, text)" +
                $"VALUES (@title, @author_id, @start_date, @end_date, @text)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author_id", text);
            cmd.Parameters.AddWithValue("@start_date", startDate);
            cmd.Parameters.AddWithValue("@end_date", endDate);
            cmd.Parameters.AddWithValue("@text", authorId);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ReturnAnnoucemntFromDB(string title)
        {
            MySqlConnection connection = new MySqlConnection(conectionString);
            string AddEndDate = $"UPDATE user SET end_date = @end_date WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(AddEndDate, connection);
            //cmd.Parameters.AddWithValue("@end_date", date);
            //cmd.Parameters.AddWithValue("@id", id);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void ReturnAllAnnoucemntFromDB(string title)
        {
            MySqlConnection connection = new MySqlConnection(conectionString);
            string AddEndDate = $"UPDATE user SET end_date = @end_date WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(AddEndDate, connection);
            //cmd.Parameters.AddWithValue("@end_date", date);
            //cmd.Parameters.AddWithValue("@id", id);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }

}
