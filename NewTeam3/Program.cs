using System;

namespace NewTeam3
{
    internal class Program
    {
        static void Main(string[] args)
        {//                                                                     H,  L,  X   Y
            boxxClass box1 = new boxxClass(false, "[1] Withdraw   ",               0, 15 ,3 , 3);
            boxxClass box2 = new boxxClass(false, "[2] Deposit   ",                0, 15, 25 ,3);
            boxxClass box3 = new boxxClass(false, "[3] Check balance",          0, 15,47, 3);
            boxxClass box4 = new boxxClass(false, "[4] Change your password",   0, 15,69 ,3);
            boxxClass box5 = new boxxClass(false, "[5] Exit      "                  , 0, 15, 100, 3);

            boxxClass boxPass = new boxxClass(false, "Welcome to bank bank Write password", 23, 21,3,10);
            BankATM bankATM = new BankATM();

            // Withdraw, Deposit, check balance, exit 
            while (true)
            {

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
