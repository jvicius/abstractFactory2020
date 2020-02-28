using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factory
{
    public class SpanishFactory : IFactoryLanguage
    {
        public ILanguage GetLanguageManager()
        {
            return new SpanishLanguage();
        }
    }
}
