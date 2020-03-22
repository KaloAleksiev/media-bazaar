using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public class ControlClass
    {
        public static List<User> users = new List<User>();

        public static List<User> workers = new List<User>();
        string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";


        public string AssignToDepotTW(string name)
        {
            int id = ReturnWorkerID(name);
            int emp_id = DepotWorker.depoNumber;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'depotworker'); INSERT INTO depotworker( id, salary) VALUES ( @id,'2500')";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return "Depot Worker Added Succesfully!";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }

        }
        public string AssignToEmployee(string name, Department department)
        {

            int id = ReturnWorkerID(name);
            string dep = department.ToString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'employee'); INSERT INTO employee(id,department, salary) VALUES (@id, @department,'3000')";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@department", dep);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return "Employee Added Succesfully!";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }

        }
        public string AssignToManager(string name)
        {
            int id = ReturnWorkerID(name);
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string insertData = "INSERT INTO workers(id, function) VALUES(@id, 'manager');INSERT INTO manager(id, salary) VALUES(@id, '4000');";
                    MySqlCommand command = new MySqlCommand(insertData, connection);

                    command.Parameters.AddWithValue("@id", id);
                    // command1.Parameters.AddWithValue("@id", id);
                    // command.Parameters.AddWithValue("@manager_id", manager_id);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    // int result1 = command1.ExecuteNonQuery();
                    return "yey";

                }
                catch (Exception ex)
                {
                    return "Failed to connect to database due to" + ex.ToString();
                }
            }
        }
        public void ShowAllUsers(IList<string> names)
        {
            string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            string sqlStatement = "SELECT concat(firstName,' ', lastName) as name FROM user";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand(sqlStatement, connection);
            MySqlDataReader reader = null;
            try
            {
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    names.Add(name);
                }
            }
            finally
            {
                connection.Close();
            }

        }
        public int ReturnWorkerID(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string sql = "SELECT id FROM user where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            conn.Open();
            Object result = cmd.ExecuteScalar();
            int id = -1;
            if (result != null)
            {
                id = Convert.ToInt32(result);
            }
            conn.Close();
            return id;
        }
        public string ReturnWorkerInfo(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT u.id as id, u.firstName as firstName, u.lastName as lastName, w.function as function FROM user u INNER JOIN workers w on u.id = w.id where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["id"]);
            string firstname = Convert.ToString(reader["firstName"]);
            string lastname = Convert.ToString(reader["lastName"]);
            string function = Convert.ToString(reader["function"]);
            return $"{id }  {firstname }  {lastname }  {function }";
        }

        public User ReturnUser(string name)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT u.id as id, u.firstName as firstName, u.lastName as lastName, u.email as email ,u.address as address,u.phone_number as phonenumber,w.function as function FROM user u INNER JOIN workers w on u.id = w.id where concat(firstName,' ', lastName) = @name;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@name", name);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = Convert.ToInt32(reader["id"]);
            string firstname = Convert.ToString(reader["firstName"]);
            string lastname = Convert.ToString(reader["lastName"]);
            string function = Convert.ToString(reader["function"]);
            string email = Convert.ToString(reader["email"]);
            string address = Convert.ToString(reader["address"]);
            string phonenumber = Convert.ToString(reader["phonenumber"]);
            User u = new User(firstname, lastname, email, address, phonenumber);
            return u;
        }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> emps = new List<Employee>();
            string connectionString = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string sql = "SELECT u.firstname, u.lastname, u.email, u.password, u.address, u.start_date, u.phone_number, e.id, e.emp_number, e.department, e.salary FROM user AS u INNER JOIN employee AS e ON u.id = e.id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                int empid = Convert.ToInt32(reader["emp_number"]);
                string firstname = Convert.ToString(reader["firstName"]);
                string lastname = Convert.ToString(reader["lastName"]);
                string email = Convert.ToString(reader["email"]);
                string address = Convert.ToString(reader["address"]);
                string phonenumber = Convert.ToString(reader["phone_number"]);
                string department = Convert.ToString(reader["department"]);
                double salary = Convert.ToDouble(reader["salary"]);
                Employee e = new Employee(id, empid, firstname, lastname, email, address, phonenumber, department, salary);
                emps.Add(e);
            }
            return emps;
        }

        public string GetItemStats(Item i)
        {
            string info = $"{i.Name}";
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand GetRestockRequests = new MySqlCommand($"SELECT request_id AS id, amount AS amount FROM restockrequest WHERE item_id = {i.Id};", conn);
            MySqlDataReader reader = GetRestockRequests.ExecuteReader();

            while (reader.Read())
            {
                info += $"\n-------------------------------\n";
                info += $"Request ID: {Convert.ToString(reader["id"])}; Amount: {Convert.ToString(reader["amount"])}";
                info += $"\n-------------------------------\n";
            }
            conn.Close();
            return info;
        }

        public string GetStatsPerDepartment(string department)
        {
            string table = "";
            switch (department)
            {
                case "Depot Worker":
                    table = "depotworker";
                    break;
                case "Manager":
                    table = "manager";
                    break;
                case "Employee":
                    table = "employee";
                    break;
            }
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM {table};", conn);
            MySqlDataReader reader2 = GetAvarageSalary.ExecuteReader();
            reader2.Read();
            double avgSalary = Convert.ToDouble(reader2["avarageSalary"]);
            conn.Close();
            return $"Avarage salary for the {department} department is {avgSalary.ToString("n2")}.";
        }

        public string GetStatsOverall()
        {
            List<string> departments = new List<string>() { "depotworker", "manager", "employee" };
            double avgSalary = 0;
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();
            foreach (string s in departments)
            {
                MySqlCommand GetAvarageSalary = new MySqlCommand($" SELECT AVG(salary) AS avarageSalary FROM {s};", conn);
                MySqlDataReader reader2 = GetAvarageSalary.ExecuteReader();
                reader2.Read();
                avgSalary += Convert.ToDouble(reader2["avarageSalary"]);
                reader2.Close();
            }
            avgSalary /= 3;
           
            return $"Avarage salary for all the departments is {avgSalary.ToString("n2")} euros";
        }

        public string CheckFunction(int id)
        {
            List<string> departments = new List<string>() { "depotworker", "manager", "employee", "administrator" };
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            foreach(string s in departments)
            {
                MySqlCommand GetType = new MySqlCommand($"SELECT id AS id FROM {s}", conn);
                MySqlDataReader reader2 = GetType.ExecuteReader();
                while(reader2.Read())
                {
                    if (id == Convert.ToInt32(reader2["id"]))
                    {
                        return s;
                    }
                }
                reader2.Close();
            }
            conn.Close();
            return "unsucc";           
        }

        public void CreateUser(string fname, string lname, string email, string address, DateTime date, string phone_number, string type)
        {
            string connStr = @"Server=studmysql01.fhict.local; Uid=dbi427262; Database=dbi427262; Pwd=parola1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand getMaxID = new MySqlCommand($"SELECT MAX(id) AS id FROM user;", conn);
            conn.Open();
            MySqlDataReader reader2 = getMaxID.ExecuteReader();
            reader2.Read();
            int id = Convert.ToInt32(reader2["id"]) + 1;
            conn.Close();
            reader2.Close();

            string insertData = "insert into user(id, firstname,lastname,email,password,address,start_date,phone_number)  VALUES (@id, @firstname,@lastname,@email,@password,@address,@start_date,@phone_number)";
            MySqlCommand command = new MySqlCommand(insertData, conn);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@firstname", fname);
            command.Parameters.AddWithValue("@lastname", lname);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@password", id);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@start_date", date);
            command.Parameters.AddWithValue("@phone_number", phone_number);
            conn.Open();
            int result = command.ExecuteNonQuery();
            conn.Close();

            string query = "";
            Department dep = Department.Computers;
            MySqlCommand addToDepartment;
            switch (type)
            {
                case "Manager":
                    query = "INSERT INTO manager(id, salary) VALUES (@id, @salary)";
                    addToDepartment = new MySqlCommand(query, conn);
                    addToDepartment.Parameters.AddWithValue("@id", id);
                    addToDepartment.Parameters.AddWithValue("@salary", 4000);
                    conn.Open();
                    addToDepartment.ExecuteNonQuery();
                    conn.Close();
                    //dep = Department.Manager;
                    break;
                case "Depot Worker":
                    query = "INSERT INTO manager(id, salary) VALUES (@id, @salary)";
                    addToDepartment = new MySqlCommand(query, conn);
                    addToDepartment.Parameters.AddWithValue("@id", id);
                    addToDepartment.Parameters.AddWithValue("@salary", 2500);
                    conn.Open();
                    addToDepartment.ExecuteNonQuery();
                    conn.Close();
                    //newUser = new DepotWorker(id, fname, lname, email, address, date, phone_number);
                    // dep = Department.DepotWorker;
                    break;
                case "Employee - TVs":
                    query = "employee";
                    dep = Department.TVs;
                    query = "INSERT INTO employee(id, salary, department) VALUES (@id, @salary)";
                    addToDepartment = new MySqlCommand(query, conn);
                    addToDepartment.Parameters.AddWithValue("@id", id);
                    addToDepartment.Parameters.AddWithValue("@salary", 3000);
                    addToDepartment.Parameters.AddWithValue("@department", "TVs");
                    conn.Open();
                    addToDepartment.ExecuteNonQuery();
                    conn.Close();
                    //newUser = new Employee(id, fname, lname, email, address, date, phone_number, dep);
                    break;
                case "Employee - Phones":
                    query = "employee";
                    dep = Department.Phones;
                    query = "INSERT INTO employee(id, salary, department) VALUES (@id, @salary)";
                    addToDepartment = new MySqlCommand(query, conn);
                    addToDepartment.Parameters.AddWithValue("@id", id);
                    addToDepartment.Parameters.AddWithValue("@salary", 3000);
                    addToDepartment.Parameters.AddWithValue("@department", "Phones");
                    conn.Open();
                    addToDepartment.ExecuteNonQuery();
                    conn.Close();
                    //newUser = new Employee(id, fname, lname, email, address, date, phone_number, dep);
                    break;
                case "Employee - Computers":
                    query = "employee";
                    dep = Department.Computers;
                    query = "INSERT INTO employee(id, salary, department) VALUES (@id, @salary)";
                    addToDepartment = new MySqlCommand(query, conn);
                    addToDepartment.Parameters.AddWithValue("@id", id);
                    addToDepartment.Parameters.AddWithValue("@salary", 3000);
                    addToDepartment.Parameters.AddWithValue("@department", "Computers");
                    conn.Open();
                    addToDepartment.ExecuteNonQuery();
                    conn.Close();
                    //newUser = new Employee(id, fname, lname, email, address, date, phone_number, dep);
                    break;
            }


        }
    }
}

