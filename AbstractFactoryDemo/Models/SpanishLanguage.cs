using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo.Models
{
    public class SpanishLanguage : ILanguage
    {
        private decimal _total;
        public int Menu()
        {
            var result = -1;
            while (result == -1)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido!!!");
                Console.WriteLine("1. Comprar Boleto(s)");
                Console.WriteLine("2. Cambiar Lenguaje");
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
                Console.WriteLine("Seleccionar Lenguage:");
                Console.WriteLine("1. Ingles");
                Console.WriteLine("2. Español");
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
                Console.WriteLine("Selecciona una opcion:");
                Console.WriteLine("1. Ida ($5)");
                Console.WriteLine("2. Ida y vuelta ($9)");
                Console.WriteLine("3. Pase de todo el dia ($50)");
                Console.WriteLine("4. Finalizar...");
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
                            Console.WriteLine("Gracias por su compra!!!");
                            Console.WriteLine("Imprimiendo Boletos(s)");
                            Task.Delay(2000).Wait();
                            return 4;
                    }
                }
            }

          

            return result;
        }
    }
}
