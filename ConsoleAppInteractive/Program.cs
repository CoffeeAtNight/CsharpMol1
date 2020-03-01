using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteractive
{
    class Program
    {
        const int WIEK_EMERYTALNY = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikacja Emerytura");

            Console.Write("Proszę podać imię: ");
            string name = Console.ReadLine().Trim();


            Console.Write("Proszę podać nazwisko: ");
            string nazwisko = Console.ReadLine().Trim().ToUpper();

            //Console.ReadKey();
            Console.WriteLine($"Witaj {name} {nazwisko}");

            Console.Write("Proszę podać wiek: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age) ;

            
            if(result)
            {
                if (age >= WIEK_EMERYTALNY)
                {
                    Console.WriteLine("Jesteś emerytem");
                } else
                {
                    Console.WriteLine($"Masz {age} lat \n Do emeryuty zostało Ci {WIEK_EMERYTALNY - age} lat");
                }
               

            } else
            {
                Console.WriteLine("Niewłaściwy wiek!");
            }

            
           

        }
    }
}
