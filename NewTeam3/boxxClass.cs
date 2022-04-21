using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    internal class boxxClass
    {
        public boxxClass(int BoxxHeight, int BoxxLength)
        {
            boxxBox(BoxxHeight, BoxxLength);
        }
        public void boxxBox(int BoxxHeight, int BoxxLength)
        {
            Console.WriteLine($"Størrelsen på æsken er {BoxxHeight}x{BoxxLength}");
            for (int i = 0; i < BoxxLength; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Black;
                // en mindre kommentar

            }
        }
    }
}
