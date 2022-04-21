using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    internal class boxxClass
    {
        public boxxClass(bool info, string data, int BoxxHeight, int BoxxLength)
        {
            boxxBox(info,data, BoxxHeight, BoxxLength);
        }
        public void boxxBox(bool info,string data, int BoxxHeight, int BoxxLength)
        {
            //varibles
            string startTopValue = "┌";
            string endTopValue = "┐";
            string Wall = "│";
            string startButValue = "└";
            string endButValue = "┘";
            string total;
            string stringEgdeLine = new string('─', BoxxLength);
            string stringBetweenLine = new string(' ', BoxxLength);
            String topLine = startTopValue + stringEgdeLine + endTopValue;
            String butLine = startButValue + stringEgdeLine + endButValue;
            string betweenLine = Wall + stringBetweenLine + Wall;
            string betweenData = Wall + data + Wall;

            //box info
            if (info==true)
            {
                Console.WriteLine($"Størrelsen på æsken er {BoxxHeight}x{BoxxLength}");
            }

            //box generator
            Console.WriteLine(topLine);
            Console.WriteLine(betweenLine);
            Console.WriteLine(betweenData);
            Console.WriteLine(betweenLine);
            Console.WriteLine(butLine);

            //lav en grønstreg
            /*
            for (int i = 0; i < BoxxLength; i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");

                Console.BackgroundColor = ConsoleColor.Black;
                // en mindre kommentar
            

            }
            */
        }
    }
}
