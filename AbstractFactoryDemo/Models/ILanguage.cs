using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo.Models
{
    public interface ILanguage
    {
        int Menu();
        int MenuLanguage();
        int MenuTicketOptions();
    }
}
