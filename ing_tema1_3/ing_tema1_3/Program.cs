using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_3
{
    class Program
    {
        public static string introduceYourself(string yourName)
        {
            return "Hi, my name is " + yourName + " and i'm speaking from a stored function";
        }

        //Delegate pentru functie stocata
        delegate string introduceDelegate_1(string yourName);

        //Delegat pentru fucntie inline
        delegate string introduceDelegate_2(string yourName);

        static void Main(string[] args)
        {
            introduceDelegate_1 delegate1 = introduceYourself;
            introduceDelegate_2 delegate2 = delegate (string yourName)
            {
                return "Hi, my name is " + yourName + " and i'm speaking from an inline function";
            };

            //Apel functie stocata
            Console.WriteLine(introduceYourself("Petru"));

            //Apel delegat catre functie stocata
            Console.WriteLine(delegate1.Invoke("Mihai"));

            //Apel delegat catre functie inline
            Console.WriteLine(delegate2.Invoke("Cristina"));

        }
    }
}
