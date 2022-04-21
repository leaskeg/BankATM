using System;

namespace NewTeam3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jens!");
            BankATM bankATM = new BankATM();
            BankATM.requestPIN();

            // Withdraw, Deposit, check balance, exit 
            while (true)
            {
                boxxClass box1 = new boxxClass(false, "[W] Withdraw", 23, 21);
                boxxClass box2 = new boxxClass(false, "[D] Deposit", 23, 21);
                boxxClass box3 = new boxxClass(false, "[C] Check balance", 23, 21);
                boxxClass box4 = new boxxClass(false, "[C] Check balance", 23, 21);
                Console.ReadKey();
                Console.Clear();
            }



            

            

            Console.ReadKey();
            Console.WriteLine("Hello Jens!");
            BankATM bankATM = new BankATM();
        }
    }
}
