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
        }

        public bool Login(string password, string email)
        {
            if(udc.CheckCredentials(password, email) == null)
            {
                return false;
            }
            else
            {
                loggedIn = udc.CheckCredentials(password, email);
            }
            return true;   
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
        public void AddUser(string fname, string surname, Department dep, Position pos,string email, string phone, string address, DateTime bDate)
        {
            User sashko = new User(udc.GetMaxId(),fname, surname, dep, pos, email, phone, address, bDate);
            users.Add(sashko);
            udc.AddUserToDB(sashko);

            MailMessage message = new MailMessage();
            message.From = new MailAddress("alexeto69@gmail.com");
            message.To.Add(email);

            message.Subject = "Welcome to MediaBazaar";
            message.Body = $"Greetings, {fname} {surname}, \n In this email you can find the password you have to use in order to access your firm account. " +
                $"\n Your Password is:\n " +
                $"\n {sashko.Password} \n" +
                $"\n Welcome on board," +
                $"\n Management.";

            using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
            {
                mailer.Credentials = new NetworkCredential("alexeto69@gmail.com", "Bigears69");
                mailer.EnableSsl = true;
                mailer.Send(message);
            }
        }
    }
}
