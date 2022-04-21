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
			//Version 1.0.0

			int amt = 10000, a, current, pin = 4040, pin1, pin2;

			//read PIN
			boxxClass boxPass = new boxxClass(false, "Welcome to bank bank Write password", 23, 21, 3, 10);
			pin1 = int.Parse(Console.ReadLine());
			Console.Clear();
			//compare PIN
			if (pin1 == pin)
			{

				boxxClass box1 = new boxxClass(false, "[1] Check balance   ", 0, 15, 3, 3);
				boxxClass box2 = new boxxClass(false, "[2] Withdraw money   ", 0, 15, 25, 3);
				boxxClass box3 = new boxxClass(false, "[3] Deposit money", 0, 15, 47, 3);
				boxxClass box4 = new boxxClass(false, "[4] Change your password", 0, 15, 69, 3);
				boxxClass box5 = new boxxClass(false, "[5] Exit      ", 0, 15, 100, 3);

				/*Console.WriteLine("1.Check balance");
				Console.WriteLine("2.Withdraw money");
				Console.WriteLine("3.Deposit money");
				Console.WriteLine("4.Change your password");
				*/
				int choice = int.Parse(Console.ReadLine());
				bool correct = false;
				do
				{
					switch (choice)
					{
						case 1:
							Console.WriteLine("The current balance in your account is " + amt);
							Console.ReadKey();
							break;

						case 2:
							Console.WriteLine("How much would you like to withdraw?");
							{
								a = (int)double.Parse(Console.ReadLine());
								if (amt >= a)
								{
									if (a % 100 == 0)
									{
										Console.WriteLine("Please collect the cash" + a);
										current = amt - a;
										Console.WriteLine("The current balance is now" + current);
									}
									else
										Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
								}
								else
									Console.WriteLine("Your account does not have sufficient balance");
							}

							break;

						case 3:
							Console.WriteLine("Enter the amount you wish to deposit");
							a = (int)double.Parse(Console.ReadLine());
							current = amt + a;
							Console.WriteLine("The current balance is " + current);
							Console.ReadKey();
							break;

						case 4:
							Console.WriteLine("Want to change your password");
							Console.WriteLine("Enter your previous password");
							int prepin = int.Parse(Console.ReadLine());
							if (prepin == pin)
							{
								Console.WriteLine("Enter your new password");
								pin2 = int.Parse(Console.ReadLine());
								pin1 = pin2;
								Console.WriteLine("Your password is changed");
								Console.ReadKey();
							}
							else
								Console.WriteLine("Enter your correct password");
							correct = true;
							break;
						case 5:
							Console.WriteLine("Thanks for using Bank Bank");
							break;
						default:
							Console.WriteLine("Error: Wrong choice");
							Console.ReadKey();
							correct = true;

							break;
                    }

				} while (correct);

			} else
            {
				Console.WriteLine("Wrong Password");
				Console.ReadLine();
            }
		}
	}
}

