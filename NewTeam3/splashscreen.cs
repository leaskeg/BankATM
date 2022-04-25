using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    internal class splashscreen
    {
        public splashscreen()
        {

            boxxClass box1 = new boxxClass(false, "[1] Check balance   ", 0, 11, 2, 21);
            boxxClass box2 = new boxxClass(false, "[2] Withdraw money   ", 0, 13, 26, 21);
            boxxClass box3 = new boxxClass(false, "[3] Deposit money", 0, 15, 51, 21);
            boxxClass box4 = new boxxClass(false, "[4] Change password", 0, 15, 72, 21);
            boxxClass box5 = new boxxClass(false, "[5] Exit      ", 0, 15, 95, 21);
            Console.SetCursorPosition(0, 0);
            //Console.ReadKey();





        }

    }
}
