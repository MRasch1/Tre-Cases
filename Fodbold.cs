using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases
{
    internal class Fodbold
    {
        internal void Run()
        {
            string Mål, input;
            int Afleveringer;

            

                Console.Clear();
                Console.WriteLine("Velkommen til Fodbold case");
                Console.ReadKey();
                Console.WriteLine("Skriv (mål) hvis der er mål: ");
                Mål = Console.ReadLine().ToLower();
                Console.WriteLine("Skriv antal afleveringer: ");
                input = Console.ReadLine();

                bool StringProof = int.TryParse(input, out Afleveringer);

                if (Afleveringer >= 0)
                {

                       ClassLibrary1.Fodbold Fodbold_Objekt = new ClassLibrary1.Fodbold();
                       string FodboldResultat = Fodbold_Objekt.ErDerMålOgAfleveringer(Mål, Afleveringer);
                       Console.WriteLine(FodboldResultat);
                    
                }

                else
                {
                    Console.WriteLine("Fejl indtast");
                    Console.ReadKey();
                }

            Console.ReadKey();
            
        }
    }
}
