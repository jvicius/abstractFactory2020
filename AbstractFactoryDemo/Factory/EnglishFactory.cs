using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Factory
{
    public class EnglishFactory : IFactoryLanguage
    {
        public ILanguage GetLanguageManager()
        {
            return new EnglishLanguage();
        }
    }
}
