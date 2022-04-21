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
            boxxBox(false, BoxxHeight, BoxxLength);
        }
        public void boxxBox(bool info, int BoxxHeight, int BoxxLength)
        {
            //varibles
            string startTopValue = "┌";
            string endTopValue = "┐";
            string Wall = "│";
            string startButValue = "└";
            string endButValue = "┘";
            string total;
            string stringMidLine = new string('─', BoxxLength - 2);

            //box info
            if (true)
            {
                Console.WriteLine($"Størrelsen på æsken er {BoxxHeight}x{BoxxLength}");
            }

            //box generator
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
