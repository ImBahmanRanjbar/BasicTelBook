using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.Title = "TelBook";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (2 != 3)
            {
                Console.Clear();
                Console.WriteLine($"Welcome To TelBook (Total Contacts : {book.ToTalConracts})");
                Console.WriteLine("-------------------");
                Console.WriteLine();
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Search by Name");
                Console.WriteLine("5. Search by Number");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Pelese Select an option ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.Write("Name : ");
                            string name = Console.ReadLine();
                            Console.Write("Number : ");
                            string phone = Console.ReadLine();
                            Console.Write("Email : ");
                            string email = Console.ReadLine();
                            Console.Write("Address : ");
                            string address = Console.ReadLine();
                            Contact p = new Contact();
                            p.Name = name; p.Phone = phone; p.Email = email; p.Address = address;
                            book.ADD(p);
                            break;
                        }
                    case "6":

                        return;

                    case "3":
                        {
                            Console.Write("Plese enter your phone Number to remove: ");
                            string tt = Console.ReadLine();
                            book.RemoveAtNum(tt);
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Plese enter your phone Number to Search: ");
                            string ttt = Console.ReadLine();
                            var r = book.findbyNum(ttt);
                            if (r != null)
                            {
                                Console.WriteLine("Name: " + r.Name);
                                Console.WriteLine("Number: " + r.Phone);
                                Console.WriteLine("Email: " + r.Email);
                                Console.WriteLine("Address: " + r.Address);
                            }
                            else
                            {
                                Console.WriteLine($"Contact with phone {ttt} was not found!");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Plese enter your Name to Search: ");
                            string tttt = Console.ReadLine();
                            var rrr = book.findbyName(tttt);
                            if (rrr != null)
                            {
                                Console.WriteLine("Name: " + rrr.Name);
                                Console.WriteLine("Number: " + rrr.Phone);
                                Console.WriteLine("Email: " + rrr.Email);
                                Console.WriteLine("Address: " + rrr.Address);
                            }
                            else
                            {
                                Console.WriteLine($"Contact with Name {tttt} was not found!");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {

                            Console.Write("Plese enter your phone Number to update: ");
                            string qqq = Console.ReadLine();
                            var yyy = book.findbyNum(qqq);
                            if (yyy != null)
                            {
                                Console.Write("Name : ");
                                string namet = Console.ReadLine();
                                Console.Write("Number : ");
                                string phonet = Console.ReadLine();
                                Console.Write("Email : ");
                                string emailt = Console.ReadLine();
                                Console.Write("Address : ");
                                string addresst = Console.ReadLine();
                                Contact pppppp = new Contact();
                                pppppp.Name = namet; pppppp.Phone = phonet; pppppp.Email = emailt; pppppp.Address = addresst;
                                book.Update(qqq, pppppp);
                            }
                            else
                            {
                                Console.WriteLine($"Contact with phone {qqq} was not found!");
                            }
                            Console.ReadKey();
                            break;
                        }

                }
            }
        }
    }
}
