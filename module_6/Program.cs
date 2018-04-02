using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using KKB;
using KKB.bank.Module;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Client> ListClient = new List<Client>();
                GeneratorName.Generator g = new Generator();
                Client c1 = new Client();

                c1.Dob = DateTime.Now.AddYears(-60);
                c1.Fullname = g.GenerateDefault(Gender.man);
                c1.IIN = "970556122112";
                c1.Login = "Qwerty";
                c1.Password = "123";
                c1.PhoneNumber = "7544541155430";
                ListClient.Add(c1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }

        }
    }
}
