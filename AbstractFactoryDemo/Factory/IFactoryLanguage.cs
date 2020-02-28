using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factory
{
    public interface IFactoryLanguage
    {
        ILanguage GetLanguageManager();
    }
}
