using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Models
{
    public class EnglishLanguage : ILanguage
    {
        private decimal _total;
        public int Menu()
        {
            var result = -1;
            while (result==-1)
            {
                Console.Clear();
                Console.WriteLine("Welcome!!!");
                Console.WriteLine("1. Buy Ticket(s)");
                Console.WriteLine("2. Change Language");
                var key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    if (int.Parse(key.KeyChar.ToString()) == 1 || int.Parse(key.KeyChar.ToString()) == 2)
                    {
                        result = int.Parse(key.KeyChar.ToString());
                        break;
                    }
                }
            }
            return result;
        }

        public int MenuLanguage()
        {
            var result = -1;
            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("Select Language:");
                Console.WriteLine("1. English");
                Console.WriteLine("2. Spanish");
                var key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    if (int.Parse(key.KeyChar.ToString()) == 1 || int.Parse(key.KeyChar.ToString()) == 2)
                    {
                        result = int.Parse(key.KeyChar.ToString());
                        break;
                    }
                }
            }

            return result;
        }

        public int MenuTicketOptions()
        {
            var result = -1;
            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("Select Ticket Option:");
                Console.WriteLine("1. One Way ($5)");
                Console.WriteLine("2. Two way ($9)");
                Console.WriteLine("3. All day pass ($50)");
                Console.WriteLine("4. Done...");
                Console.WriteLine($"Total: ${_total}");
                var key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    switch (int.Parse(key.KeyChar.ToString()))
                    {
                        case 1:
                            _total += 5;
                            break;
                        case 2:
                            _total += 9;
                            break;
                        case 3:
                            _total += 50;
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Thaks for your purchase!!!");
                            Console.WriteLine("Printing Ticket(s)");
                            Task.Delay(2000).Wait();
                            return 4;
                    }
                }
            }

           

            return result;
        }
    }
}
