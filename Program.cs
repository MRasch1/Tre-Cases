using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string indtast;

            Console.WriteLine("Starten af programmet");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Vælg en case");
            Console.WriteLine("Fodbold");
            Console.WriteLine("Dans");
            Console.WriteLine("Password");
            Console.Write(": ");
            indtast = Console.ReadLine().ToLower();

            if(indtast == "fodbold")
            {
                var OpeningAfFodbold = new Fodbold();
                OpeningAfFodbold.Run();
            }

            else if (indtast == "dans")
            {
                var OpeningAfDans = new Dans();
                OpeningAfDans.Run();
            }

            else if (indtast == "password")
            {
                var OpeningAfPassword = new Password();
                OpeningAfPassword.Run();
            }

        }
    }
}
