using System;
using AbstractFactoryDemo.Factory;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryLanguage factoryLanguage = new EnglishFactory();
            var res1 = -1;
            var res2 = -1;
            var res3 = -1;
            while (true)
            {
                res1 = factoryLanguage.GetLanguageManager().Menu();
                switch (res1)
                {
                   case 2:
                       res2 = factoryLanguage.GetLanguageManager().MenuLanguage();

                       switch (res2)
                       {
                            case 1: factoryLanguage = new EnglishFactory(); break;
                            case 2: factoryLanguage = new SpanishFactory(); break;
                        }
                       break;
                    case 1:
                        res3 = factoryLanguage.GetLanguageManager().MenuTicketOptions();
                        break;
                }
            }
        }
    }
}
