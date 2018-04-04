using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.bank.Module
{
    public class Client
    {
        public Client()
        {
            ListAccount = new List<Account>();
        }
        string Fullname_;
        public string Fullname
        {
            get
            {
                return Fullname_;
            }
            set
            {
                Fullname_ = value
                   .Replace("<center><b><font size=7>", "")
                   .Replace("</font></b></center>", "");

            }
        }
        private string IIN_;
        public string IIN
        {
            get
            {
                return IIN_;
            }
            set
            {
                if (value.Length == 12)
                {
                    IIN_ = value;
                }
                else
                {
                    throw new Exception("Incorrect IIN");
                }
            }
        }
        public DateTime Dob { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public List<Account> ListAccount;
        public bool isBlocked { get; set; }
        private int WrongField_;
        public int WrongField
        {
            get
            {
                return WrongField_;
            }
            set
            {
                if (value >= 3)
                    isBlocked = true;

                WrongField_ = value;

            }
        }

        public void ClientInfoPrint()
        {
            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n", Fullname, IIN, Login, Password, PhoneNumber, Dob);
        }
        public void PrintAccountInfo()
        {
            double sumBalance = 0;
            foreach (Account item in ListAccount)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("0000122: {0}", item.AccountName);
                Console.WriteLine("2502112: {0}", item.Balance);
                Console.WriteLine("2015: {0}", item.CreateDate);
                Console.WriteLine("Exp: {0}", item.CloseDate);
                Console.WriteLine("-------------------------------------------------------");
                sumBalance+= item.Balance;
            }
            Console.WriteLine("-------------**************************----------------");
            Console.WriteLine("                   Total sum:{0} ", sumBalance);
            Console.WriteLine("-------------**************************----------------");
        }

    }
}
