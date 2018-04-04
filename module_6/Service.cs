using KKB.bank.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
namespace Bankomat
{

    public class Service
    {
        private static Random rnd = new Random();
        public static void createClient(ref Client c)
        {
            Generator gen = new Generator();
            c.Fullname = gen.GenerateDefault(Gender.woman);
            c.IIN = "123575344224";
            c.PhoneNumber = "454432131123";
            c.Dob = DateTime.Now;
            for (int i = 0; i < rnd.Next(1, 8); i++)
            {
                c.ListAccount.Add(createAccount());
            }

        }
        public static Account createAccount()
        {

            Account acc = new Account();
            acc.AccountName = "KZ" + rnd.Next(10000, 1000000000);
            acc.Balance = double.Parse(rnd.Next(100, 99999).ToString());
            acc.CreateDate = DateTime.Now.AddYears(-rnd.Next(1,30));

            return acc;
        }
    }
}
