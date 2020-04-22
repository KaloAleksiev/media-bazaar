using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using S22.Imap;
using System.Net;

namespace MediaBazaarTest
{
    public class UserControl
    {
        private List<User> users;
        private UserDataControl udc;
        private User loggedIn;

        public UserControl()
        {
            users = new List<User>();
            udc = new UserDataControl();
            foreach (User u in udc.GetAllUsers())
            {
                users.Add(u);
            }
        }

        public bool Login(string password, string email)
        {
            if (udc.CheckCredentials(password, email) == null)
            {
                return false;
            }
            else
            {
                loggedIn = udc.CheckCredentials(password, email);
                //remove the logged in person from the list
                for (int i = 0; i < users.Count; i++)
                {
                    if(users[i].Id == loggedIn.Id)
                    {
                        users.RemoveAt(i);
                    }
                }
            }
            return true;
        }

        public void Logout()
        {
            this.loggedIn = null;
        }

        public bool CheckEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        public void AddUser(string fname, string surname, Department dep, Position pos, string email, string phone, string city, string zipcode, string address, DateTime bDate, string gender)
        {
            User sashko = new User(udc.GetMaxId(), fname, surname, dep, pos, email, phone, city, zipcode, address, bDate, gender);
            users.Add(sashko);
            udc.AddUserToDB(sashko);

            MailMessage message = new MailMessage();
            message.From = new MailAddress("mediabazaar.management@gmail.com");
            message.To.Add(email);

            message.Subject = "Welcome to MediaBazaar";
            message.Body = $"Greetings, {fname} {surname}, \n In this email you can find the password you have to use in order to access your firm account. " +
                $"\n Your Password is:\n " +
                $"\n {sashko.Password} \n" +
                $"\n Welcome on board," +
                $"\n Management.";

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
        }

        public List<User> GetUsers()
        {
            return this.users;
        }

        public User GetUserByID(int id)
        {
            foreach (User u in users)
            {
                if (u.Id == id)
                {
                    return u;
                }
            }
            return null;
        }

        public User GetLoggedIn()
        {
            return this.loggedIn;
        }

        #region FIRE/PROMOTE EMPLOYEE
        public bool FireUser(int id)
        {
            if (GetUserByID(id) != null)
            {
                User u = GetUserByID(id);
                DateTime date = DateTime.Now.Date;
                u.FireEmployee(date);
                udc.FireEmployeeDB(id, date);

                //Send an email about it
                MailMessage message = new MailMessage();
                message.From = new MailAddress("mediabazaar.management@gmail.com");
                message.To.Add(u.Email);

                message.Subject = "Your contract has been terminated";
                message.Body = $"Greetings, {u.FName} {u.LName}, \n we regret to inform you that your contract with MediaBazaar has been terminated. You will recieve a follow up email with more information. " +
                    $"\n Thank you for being part of our team! We wish you all the best in your future endevours!"+
                    $"\n Kind ragards," +
                    $"\n {loggedIn.FName} {loggedIn.LName}," +
                    $" Management.";
                using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
                users.Remove(u);
                return true;
            }
            return false;
        }

        public bool ChangeDepartment(int id, Department dep)
        {
            if (GetUserByID(id) != null)
            {
                User u = GetUserByID(id);
                if (u.Department != dep)
                {
                    u.ChangeDepartment(dep);
                    udc.ChangeEmployeeDepartment(id, dep);

                    //Send an email about it
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("mediabazaar.management@gmail.com");
                    message.To.Add(u.Email);

                    message.Subject = "Department changed";
                    message.Body = $"Greetings, {u.FName} {u.LName}, \n we would like to inform you that your have been assigned to work in the {dep} department starting next week. " +

                        $"\n Kind ragards," +
                        $"\n {loggedIn.FName} {loggedIn.LName}," +
                        $"\n Management.";
                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                    {
                        mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                        mailer.EnableSsl = true;
                        mailer.Send(message);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool ChangePosition(int id, Position pos)
        {
            if (GetUserByID(id) != null)
            {
                User u = GetUserByID(id);
                if (u.Position != pos)
                {
                    u.ChangePosition(pos);
                    udc.ChangeEmployeePosition(id, pos);

                    //Send an email about it
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("mediabazaar.management@gmail.com");
                    message.To.Add(u.Email);

                    message.Subject = "Position changed";
                    message.Body = $"Greetings, {u.FName} {u.LName}, \n we would like to inform you that your position has been changed.Starting next week, your new position is {pos}. " +

                        $"\n Kind ragards," +
                        $"\n {loggedIn.FName} {loggedIn.LName}," +
                        $"\n Management.";
                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                    {
                        mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                        mailer.EnableSsl = true;
                        mailer.Send(message);
                    }
                    return true;
                }
            }
            return false;
        }

        public bool ChangeRank(int id, int rank)
        {
            if (GetUserByID(id) != null)
            {
                User u = GetUserByID(id);
                if (u.Rank != rank)
                {
                    u.ChangeRank(rank);
                    udc.ChangeEmployeeRank(id, rank);

                    //Send an email about it
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("mediabazaar.management@gmail.com");
                    message.To.Add(u.Email);

                    message.Subject = "Rank changed";
                    message.Body = $"Greetings, {u.FName} {u.LName}, \n we would like to inform you that your rank has been changed.Starting next month, your new rank will be {rank}. " +

                        $"\n Kind ragards," +
                        $"\n {loggedIn.FName} {loggedIn.LName}," +
                        $"\n Management.";
                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                    {
                        mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                        mailer.EnableSsl = true;
                        mailer.Send(message);
                        
                    }
                    return true;
                }
            }
            return false;
        }

        public bool ChangeSalary(int id, double salary)
        {
            if (GetUserByID(id) != null)
            {
                User u = GetUserByID(id);
                if (u.Salary != salary)
                {
                    u.ChangeSalary(salary);
                    udc.ChangeEmployeeSalary(id, salary);

                    //Send an email about it
                    MailMessage message = new MailMessage();
                    message.From = new MailAddress("mediabazaar.management@gmail.com");
                    message.To.Add(u.Email);

                    message.Subject = "Salary changed";
                    message.Body = $"Greetings, {u.FName} {u.LName}, \n we would like to inform you that your salary has been changed.Starting next month, your new salary will be {salary.ToString("C2")}. " +

                        $"\n Kind ragards," +
                        $"\n {loggedIn.FName} {loggedIn.LName}," +
                        $"\n Management.";
                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                    {
                        mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                        mailer.EnableSsl = true;
                        mailer.Send(message);                        
                    }
                    return true;
                }
            }
            return false;
        }

        #endregion

        public bool GetForgottenPass(string email, string fName)
        {
            string pass = udc.GetForgottenPassword(email, fName);
            if (pass != "")
            {
                //Send an email about it
                MailMessage message = new MailMessage();
                message.From = new MailAddress("mediabazaar.management@gmail.com");
                message.To.Add(email);

                message.Subject = "Forgotten password";
                message.Body = $"Greetings, {fName}, \n your password is: \n {pass} " +

                    $"\n Kind ragards,"+
                    $"\n Alexa.";
                using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential("mediabazaar.management@gmail.com", "MediaB420");
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
                return true;
            }
            return false;
        }
    }
}
