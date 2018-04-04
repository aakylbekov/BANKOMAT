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
            string login = "";
            string password = "";
            try
            {
                Client client = new Client();
                Service.createClient(ref client);
                client.Login = "admin";
                client.Password = "admin";

                while (!client.isBlocked)
                {
                    Console.Clear();
                    Console.Write("Enter your login: ");
                    login = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    password = Console.ReadLine();

                    if (login != client.Login && password != client.Password)
                        client.WrongField++;
                    else break;
                }
                #region
                if (login == client.Login && password == client.Password)
                {
                    do
                    {
                        if (client.isBlocked)
                        {
                            Console.WriteLine("USer Blocked ");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("1) Accounts");
                            Console.WriteLine("2) Create account");
                            Console.WriteLine("3) Add balance");
                            Console.WriteLine("6) Exit");
                            int menu = 0;
                            Int32.TryParse(Console.ReadLine(), out menu);
                            if (menu > 2 || menu < 1)
                            {
                                throw new Exception("invalid choice");
                            }
                            else
                            {
                                switch (menu)
                                {
                                    case 1:
                                        {
                                            client.PrintAccountInfo();
                                        }
                                        break;
                                    case 2:
                                        {
                                            Account acc = Service.createAccount();
                                            client.ListAccount.Add(acc);
                                            Console.WriteLine("Account created");
                                        }
                                        break;
                                    case 3:
                                        {
                                            Console.WriteLine("Account number: ");
                                            string accountNumber = Console.ReadLine();
                                            Console.WriteLine("");
                                        }
                                        break;
                                    case 6:
                                        break;            
                                }

                            }

                        }

                    }
                    while (true);

                }
                #endregion
                else
                {
                    //client.WrongField++;
                    throw new Exception("Invalid login");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




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





            //  c1.ClientInfoPrint();


        }
    }
}
