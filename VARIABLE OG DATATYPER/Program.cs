using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARIABLE_OG_DATATYPER
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opg a
            int a = 16;

            double b = 5.1;
            Console.WriteLine(a + b);
            Console.ReadKey(); //brugt til testing af program så programmet ikke lukket ned



            //opg b
            int c = a + b; //dette kan ikke lade sig gøre da en int ikke kan indholde variabler der indeholder et komatal deraf (integer (heltal))

            //opg c
            double d = a + b; //her virker den fordi en double godt kan indeholde heltal også


            Console.ReadKey();
        }
    }
}
