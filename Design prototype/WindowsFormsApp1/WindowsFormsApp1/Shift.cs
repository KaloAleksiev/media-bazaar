using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Shift
    {
        private int shiftId;
        private DateTime date;
        List<Employee> employees;
        List<DepotWorker> dws;
        Manager mngr;

        public Shift(DateTime date, ShiftType type, Department department)
        {
            this.date = date;
            this.Type = type;
            this.Department = department;

            employees = new List<Employee>();
            dws = new List<DepotWorker>();
            mngr = null;
        }

        public Shift(int shiftId, DateTime date, ShiftType type, Department department)
        {
            ShiftId = shiftId;
            this.date = date;
            this.Type = type;
            this.Department = department;

            employees = new List<Employee>();
            dws = new List<DepotWorker>();
            mngr = null;
        }

        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }

        public Department Department
        { get; set; }

        public ShiftType Type
        { get; set; }

        public void AddEmployee(Employee person)
        { employees.Add(person); }
        public void AddDepotWorker(DepotWorker dw)
        { dws.Add(dw); }
        public void AddMng(Manager m)
        { mngr = m; }

        public void AddShiftToDB()
        {
            //See if a shift with the ID already exists.
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand CheckForShift = new MySqlCommand("SELECT COUNT(*) AS cnt FROM shift WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
            conn.Open();
            MySqlDataReader reader = CheckForShift.ExecuteReader();
            reader.Read();
            int o = Convert.ToInt32(reader["cnt"]);
            reader.Close();
            conn.Close();
            //If it exists, just add people to the shift_user table with the correct shift ID. Might have to delete all the rows for the shift first, because they could repeat.
            if (o > 0)
            {
                MySqlCommand GetAmountOfPeople = new MySqlCommand("SELECT COUNT(employee_id) AS EN, shift_id AS shift_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader1 = GetAmountOfPeople.ExecuteReader();
                reader1.Read();
                int n = Convert.ToInt32(reader1["EN"]);
                reader1.Close();
                conn.Close();
                switch (this.Department)
                {
                    case (Department.Manager):
                        MySqlCommand GetIDsOfPeople = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                        conn.Open();
                        MySqlDataReader reader2 = GetIDsOfPeople.ExecuteReader();
                        reader2.Read();
                        int mngId = Convert.ToInt32(reader2["employee_id"]);
                        reader2.Close();
                        conn.Close();
                        //List<int> toDelete = new List<int>();
                        if (mngr == null)
                        {
                            MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift_user WHERE employee_id = '" + mngId.ToString() + "'", conn);
                            conn.Open();
                            int j = DeleteShift.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO shift_user (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                            AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", mngr.GetGottenID().ToString());
                            AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                            conn.Open();
                            int k = AddPersonToShiftDB.ExecuteNonQuery();
                            conn.Close();
                        }
                        break;
                    case (Department.DepotWorker):
                        List<int> indexes = new List<int>();
                        MySqlCommand GetIDOfPeople = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                        conn.Open();
                        MySqlDataReader reader4 = GetIDOfPeople.ExecuteReader();
                        for (int i = 0; i < n; i++)
                        {
                            reader4.Read();
                            int empId = Convert.ToInt32(reader4["employee_id"]);
                            indexes.Add(empId);
                        }
                        reader4.Close();
                        conn.Close();
                        //List<int> toDelete = new List<int>();
                        if (n > dws.Count)
                        {
                            for (int i = 0; i < indexes.Count; i++)
                            {
                                bool flag = true;
                                for (int j = 0; j < dws.Count; j++)
                                {
                                    if (dws[j].GetGottenID() == indexes[i])
                                    {
                                        flag = false;
                                    }
                                }
                                if (flag)
                                {
                                    MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift_user WHERE employee_id = '" + indexes[i].ToString() + "'", conn);
                                    conn.Open();
                                    int j = DeleteShift.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < dws.Count; i++)
                            {
                                bool flag = true;
                                for (int j = 0; j < indexes.Count; j++)
                                {
                                    if (dws[i].GetGottenID() == indexes[j])
                                    {
                                        flag = false;
                                    }
                                }
                                if (flag)
                                {
                                    MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO shift_user (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                                    AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", dws[i].GetGottenID().ToString());
                                    AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                                    conn.Open();
                                    int k = AddPersonToShiftDB.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                        
                        break;
                    default: 
                        List<int> indexe = new List<int>();
                        MySqlCommand GetIDsOfPeopl = new MySqlCommand("SELECT employee_id FROM shift_user WHERE shift_id = '" + this.shiftId.ToString() + "'", conn);
                        conn.Open();
                        MySqlDataReader reader3 = GetIDsOfPeopl.ExecuteReader();
                        for (int i = 0; i < n; i++)
                        {
                            reader3.Read();
                            int empId = Convert.ToInt32(reader3["employee_id"]);
                            indexe.Add(empId);
                        }
                        reader3.Close();
                        conn.Close();
                        //List<int> toDelete = new List<int>();
                        if (n > employees.Count)
                        {
                            for (int i = 0; i < indexe.Count; i++)
                            {
                                bool flag = true;
                                for (int j = 0; j < employees.Count; j++)
                                {
                                    if (employees[j].GetGottenID() == indexe[i])
                                    { 
                                        flag = false;
                                    }
                                }
                                if (flag)
                                {
                                    MySqlCommand DeleteShift = new MySqlCommand("DELETE FROM shift_user WHERE employee_id = '" + indexe[i].ToString() + "'", conn);
                                    conn.Open();
                                    int j = DeleteShift.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < employees.Count; i++)
                            {
                                bool flag = true;
                                for (int j = 0; j < indexe.Count; j++)
                                {
                                    if (employees[i].GetGottenID() == indexe[j])
                                    {
                                        flag = false;
                                    }
                                }
                                if (flag)
                                {
                                    MySqlCommand AddPersonToShiftDB = new MySqlCommand("INSERT INTO shift_user (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                                    AddPersonToShiftDB.Parameters.AddWithValue("@employee_id", employees[i].GetGottenID().ToString());
                                    AddPersonToShiftDB.Parameters.AddWithValue("@shift_id", this.shiftId);
                                    conn.Open();
                                    int k = AddPersonToShiftDB.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                        break;
                }
            }
            else
            {
                //If the shift doesn't exist, create it.
                MySqlCommand AddShiftToDB = new MySqlCommand("INSERT INTO shift (date, type, department) VALUES (@date, @type, @department)", conn);
                AddShiftToDB.Parameters.AddWithValue("@date", this.date.ToString("yyyy-MM-dd"));
                AddShiftToDB.Parameters.AddWithValue("@type", this.Type);
                AddShiftToDB.Parameters.AddWithValue("@department", this.Department.ToString());
                conn.Open();
                int i = AddShiftToDB.ExecuteNonQuery();
                conn.Close();
                //Get the shifts ID. (Redundant, since I added shiftID as an input parameter, but I'm scared that removing this might mess up the code.)
                MySqlCommand GetShiftID = new MySqlCommand("SELECT shift_id FROM shift WHERE date = '" + this.date.ToString("yyyy=-MM-dd") + "' AND type = '" + this.Type.ToString() + "' AND department = '" + this.Department.ToString() + "'", conn);
                conn.Open();
                MySqlDataReader reader1 = GetShiftID.ExecuteReader();
                reader1.Read();
                this.shiftId = Convert.ToInt32(reader1["shift_id"]);
                reader1.Close();
                conn.Close();
                string table = null;
                //Add each user from the people list into the shift_user table.
                switch (this.Department)
                {
                    case Department.Manager:
                        table = "shift_user";
                        MySqlCommand AddPersonToShiftDB1 = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                        AddPersonToShiftDB1.Parameters.AddWithValue("@employee_id", mngr.GetGottenID());
                        AddPersonToShiftDB1.Parameters.AddWithValue("@shift_id", this.shiftId);
                        conn.Open();
                        int k = AddPersonToShiftDB1.ExecuteNonQuery();
                        conn.Close();
                        break;
                    case Department.DepotWorker:
                        foreach (DepotWorker dw in dws)
                        {
                            table = "shift_user";
                            MySqlCommand AddPersonToShiftDB2 = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                            AddPersonToShiftDB2.Parameters.AddWithValue("@employee_id", dw.GetGottenID());
                            AddPersonToShiftDB2.Parameters.AddWithValue("@shift_id", this.shiftId);
                            conn.Open();
                            int b = AddPersonToShiftDB2.ExecuteNonQuery();
                            conn.Close();
                        }
                        break;
                    default:
                        foreach (Employee user in employees)
                        {
                            table = "shift_user";
                            MySqlCommand AddPersonToShiftDB3 = new MySqlCommand("INSERT INTO " + table + " (employee_id, shift_id) VALUES (@employee_id, @shift_id)", conn);
                            AddPersonToShiftDB3.Parameters.AddWithValue("@employee_id", user.GetGottenID());
                            AddPersonToShiftDB3.Parameters.AddWithValue("@shift_id", this.shiftId);
                            conn.Open();
                            int h = AddPersonToShiftDB3.ExecuteNonQuery();
                            conn.Close();
                        }
                        break;
                }
            }
        }

        public List<Employee> GetAllEmps()
        {
            List<Employee> emps = new List<Employee>();
            foreach (Employee emp in employees)
            {
                emps.Add(emp);
            }
            return emps;
        }

        public Manager GetAllMng()
        { return mngr; }

        public List<DepotWorker> GetAllDW()
        {
            List<DepotWorker> dw = new List<DepotWorker>();
            foreach (DepotWorker dwr in dws)
            { dw.Add(dwr); }
            return dw;

        }

        public void RemoveEmployee(Employee e)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].GetGottenID() == e.GetGottenID())
                { employees.Remove(employees[i]); }
            }
        }
        public void RemoveDepotWorker(DepotWorker dw)
        {
            for (int i = 0; i < dws.Count; i++)
            {
                if (dws[i].GetGottenID() == dw.GetGottenID())
                { dws.Remove(dws[i]); }
            }
        }
        public void RemoveManager(Manager m)
        {
            if (mngr.GetGottenID() == m.GetGottenID())
            { mngr = null; }
        }
    }
}
