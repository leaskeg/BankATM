using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    //version 1.0.0
    public class boxxClass
    {
        public boxxClass(bool info, string data, int BoxxHeight, int BoxxLength, int posX, int posY)
        {
            boxxBox(info,data, BoxxHeight, BoxxLength, posX, posY);
        }
        public void boxxBox(bool info,string data, int BoxxHeight, int BoxxLength, int posX, int posY)
        {
            //varibles
            int dataLength = data.Length + 2;
            if (BoxxLength >= dataLength)
            {
                dataLength = BoxxLength;
            }

            string startTopValue = "┌";
            string endTopValue = "┐";
            string Wall = "│";
            string startButValue = "└";
            string endButValue = "┘";
            string stringEgdeLine = new string('─', dataLength);
            string stringBetweenLine = new string(' ', dataLength);
            String topLine = startTopValue + stringEgdeLine + endTopValue;
            String butLine = startButValue + stringEgdeLine + endButValue;
            string betweenLine = Wall + stringBetweenLine + Wall;
        
            string betweenData = Wall + " " + data + " " + Wall;

            if (BoxxLength >= dataLength)
            {
                string betweenWalldataWall = new string(' ', ((BoxxLength-2-data.Length)/2));
                betweenData = Wall + betweenWalldataWall + data + betweenWalldataWall + Wall;

            }

            //box info
            if (info==true)
            {
                Console.WriteLine($"Størrelsen på æsken er {BoxxHeight}x{BoxxLength}");
            }

            //box generator
            Console.CursorLeft = posX;
            Console.CursorTop = posY;

            Console.WriteLine(topLine);
            Console.CursorLeft = posX;

            Console.WriteLine(betweenLine);
            Console.CursorLeft = posX;

            Console.WriteLine(betweenData);
            Console.CursorLeft = posX;

            Console.WriteLine(betweenLine);
            Console.CursorLeft = posX;

            Console.WriteLine(butLine);
            Console.CursorLeft = posX;

        }
    }
}
