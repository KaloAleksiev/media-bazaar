using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using S22.Imap;
using System.Net;

namespace CashierApp
{
    public class CashierControl
    {
        private CashierDataControl cdc;

        private Cashier loggedIn;
        private Dictionary<Item, int> currentItems;
        //private List<Order> orders;

        public CashierControl()
        {
            this.cdc = new CashierDataControl();
            currentItems = new Dictionary<Item, int>(); 
        }

        public bool AddItemToSale(Item i, int amount)
        {
            if (currentItems.ContainsKey(i))
            {
                return false;
            }
            else
            {
                currentItems.Add(i, amount);
                return true;
            }
            
        }

        public bool RemoveItemFromSale(string s)
        {
            foreach(KeyValuePair<Item, int> i in currentItems)
            {
                if($"{i.Key.Name} X {i.Value}" == s)
                {
                    currentItems.Remove(i.Key);
                    return true;
                }
            }
            return false;
        }

        public string CompleteSale()
        {
            string reciept = "------------------HELLO------------------";
            int saleId = cdc.GetMaxSaleId();
            Sale s = new Sale(saleId, this.loggedIn.Id, currentItems);
            cdc.AddSaleToDB(s);
            foreach(KeyValuePair<Item, int> i in currentItems)
            {
                reciept += $"\n-----------------------------------------\n";
                reciept += $"{i.Key.Name} X {i.Value} \n";
                reciept += $"{i.Key.Price.ToString("C")} X {i.Value} = {(i.Key.Price * i.Value).ToString("C")}";
                reciept += $"\n-----------------------------------------\n";
            }
            reciept += $"\n TOTAL: {s.Price.ToString("C")}";
            currentItems.Clear();
            return reciept;
            
        }

        public Dictionary<Item, int> GetCurrentItems()
        {
            return this.currentItems;
        }

        #region LOGIN
        public bool Login(string password, string email)
        {
            if (cdc.CheckCredentials(password, email) == null && CheckEmail(email))
            {
                return false;
            }
            else
            {
                loggedIn = cdc.CheckCredentials(password, email);                 
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

        public bool GetForgottenPass(string email, string fName)
        {
            string pass = cdc.GetForgottenPassword(email, fName);
            if (pass != "")
            {
                //Send an email about it
                MailMessage message = new MailMessage();
                message.From = new MailAddress("mediabazaar.management@gmail.com");
                message.To.Add(email);

                message.Subject = "Forgotten password";
                message.Body = $"Greetings, {fName}, \n your password is: \n {pass} " +

                    $"\n Kind ragards," +
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

        public Cashier GetLoggedIn()
        {
            return this.loggedIn;
        }
        #endregion
    }
}
