using System;

namespace NewTeam3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            boxxClass box1 = new boxxClass(23,21);

            // Withdraw, Deposit, check balance, exit 

            Console.ReadKey();
            Console.WriteLine("Hello Jens!");
            BankATM bankATM = new BankATM();
            BankATM.requestPIN();
        }
    }
}
