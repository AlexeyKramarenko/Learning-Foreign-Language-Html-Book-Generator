using AssimilGenerator.Utils;
using System.Collections.Generic;

namespace AssimilGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            new List<string>
            {
                "EnglishFrench.Advanced",
                "FrenchGerman.Advanced",
                "RussianEnglish",
                "RussianFrench",
                "RussianGerman"
            }
            .ForEach(name => AssimilBook.Generate(name));
        }
    }
}
