using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    class PreferenceDataControl
    {
        private string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";

        public PreferenceDataControl() { }

        public List<Preference> GetAllPreferences()
        {
            List<Preference> prefs = new List<Preference>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            string getPref = $"SELECT user_id, pref_shift, pref_day_1, pref_day_2, pref_day_3 FROM user_preference";
            MySqlCommand cmd = new MySqlCommand(getPref, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int userId = Convert.ToInt32(reader["user_id"]);
                string type = reader["pref_shift"].ToString();
                string[] days = new string[3];
                days[0] = reader["pref_day_1"].ToString();
                days[1] = reader["pref_day_2"].ToString();
                days[2] = reader["pref_day_3"].ToString();
                prefs.Add(new Preference(userId, type, days));
            }
            reader.Close();
            conn.Close();
            return prefs;
        }
    }
}
