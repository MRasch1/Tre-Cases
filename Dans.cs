using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tre_Cases
{
    internal class Dans
    {
        internal void Run()
        {
            string navn1, navn2, input1, input2;
            int point1, point2;
            

            Console.Clear();
            Console.WriteLine("Velkommen til case Dans");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Indtast navn på den første danser: ");
            navn1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Indtast navn på den anden danser: ");
            navn2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Indtast point for den første danser: ");
            input1 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Indtast point for den anden danser: ");
            input2 = Console.ReadLine();

            bool StringProof1 = int.TryParse(input1, out point1);
            bool StringProof2 = int.TryParse(input2, out point2);


            ClassLibrary1.Dans Dans_Objekt = new ClassLibrary1.Dans();
            string DansResultat = Dans_Objekt.NavnOgPointTilDansere(navn1, navn2, point1, point2);
            Console.WriteLine(DansResultat);


            Console.ReadKey();
        }
    }
}
