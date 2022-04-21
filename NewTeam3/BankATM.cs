using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTeam3
{
    internal class BankATM
    {

        public BankATM()
        {

            Console.Title = "Bank ATM";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter your 4 digit password");



            Console.ReadKey();
        }

        public static string requestPIN()
        {
            StringBuilder sb = new StringBuilder();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);

                if (!char.IsControl(keyInfo.KeyChar))
                {
                    sb.Append(keyInfo.KeyChar);
                    Console.Write("*");
                }

            } while (true);
        }
    }
}
