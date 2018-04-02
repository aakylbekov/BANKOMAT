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
        public string Fullname { get
            {
                return Fullname_;
            }
            set
            {
                Fullname_ = value.Replace("<center><tb><font size = 7>").Replace();
            }
        }
        private string IIN_;
        public string IIN { get
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
        List<Account> ListAccount;
        public void ClientInfoPrint()
        {
            Console.WriteLine("{0}\n {1}\n {2}\n {3}\n {4}\n {5}\n", Fullname, Dob, Login, Password, PhoneNumber);
        }
    }
}
