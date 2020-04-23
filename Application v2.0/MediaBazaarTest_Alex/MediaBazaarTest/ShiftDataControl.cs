using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MediaBazaarTest
{
    class ShiftDataControl
    {
        string connStr;
        MySqlConnection conn;

        public ShiftDataControl()
        {
            connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            conn = new MySqlConnection(connStr);
        }

        public int[] GetAmntOfUsersInShift(DateTime dt, ShiftType st, Position pos, int dep = 9999)
        {
            int[] toReturn = new int[2];
            MySqlCommand GetAmountOfPeople;
            if (dep == 9999)
            { GetAmountOfPeople = new MySqlCommand("SELECT COUNT(user_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND position = '" + pos.ToString() + "')", conn); }
            else { GetAmountOfPeople = new MySqlCommand("SELECT COUNT(user_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = (SELECT shift_id FROM shift WHERE date = '" + dt.ToString("yyyy-MM-dd") + "' AND type = '" + st.ToString() + "' AND position = '" + pos.ToString() + "' AND department_id = '" + dep + "')", conn); }
            conn.Open();
            MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
            reader1.Read();
            toReturn[1] = Convert.ToInt32(reader1["EN"]);
            toReturn[2] = Convert.ToInt32(reader1["shift_id"]);
            reader1.Close();
            conn.Close();
            return toReturn;
        }
        
        public List<int> GetIdOfUsersInShift(int shiftId, int n)
        {
            List<int> indexes = new List<int>();
            MySqlCommand getEmpId = new MySqlCommand("SELECT user_id FROM shift_user WHERE shift_id = '" + shiftId.ToString() + "'", conn);
            conn.Open();
            MySqlDataReader reader1 = getEmpId.ExecuteReader();
            for (int i = 1; i <= n; i++)
            {
                reader1.Read();
                int empId = Convert.ToInt32(reader1["user_id"]);
                indexes.Add(empId);
            }
            reader1.Close();
            return indexes;
        }

        public void DeleteShift(int shiftId)
        {
            MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift WHERE shift_id = '" + shiftId + "'", conn);
            conn.Open();
            int j = DeleteShift.ExecuteNonQuery();
            conn.Close();
        }
    }
}
