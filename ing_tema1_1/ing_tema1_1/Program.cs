using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ing_tema1_1
{
    class Program
    {
        static string planet = "planet";
        static string name = "name";

        //C# 6 nameof
        public static void Foo(string par)
        {
            if (par == null) throw new ArgumentNullException(nameof(par));
        }

        static void Main(string[] args)
        {
            //String interpolation

            //Before C# 6.0
            Console.WriteLine("Before C# 6.0 -- {0} is actually named after {1}", planet, name);

            Console.WriteLine($"After C# 6.0 -- {planet} is actually named after {name}");


            //nameof expression

            /*
             * Throws exception
             * 
            String nullString = null;
            Foo(nullString);
            */
          

        }
    }


    public class Persoana
    {
        //Auto-Property Initializers

        /* Getter only property with inline initialization */
        public string Name { get; } = "Petru Ritivoiu";

        /* Property with inline initialization */
        public decimal Salary { get; set; } = 10000;

        /* Expression bodied function */
        private static double AddNumbers(double x, double y) => x + y;

        /* Expression bodied computed property */
        public string NameAndSalary => Name + " " + Salary;
    }

}
