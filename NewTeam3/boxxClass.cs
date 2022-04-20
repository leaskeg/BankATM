using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    internal class boxxClass
    {
        public boxxClass()
        {
            Console.WriteLine("test");
            Console.WriteLine("hemmelig");
            Console.WriteLine("ff");
            boxxBox(2, 4);
        }
        public void boxxBox(int BoxxHeight, int BoxxLength)
        {
            Console.WriteLine($"Størrelsen på æsken er {BoxxHeight}x{BoxxLength}");
        }
    }
}
