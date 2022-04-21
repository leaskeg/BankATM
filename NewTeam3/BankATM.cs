using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace NewTeam3
{
	internal class BankATM
	{

		public BankATM()
		{
			//Version 1.0.2

			int amt = 10000, a, current, pin = 4040, pin1, pin2;

			//read PIN
			boxxClass boxPass = new boxxClass(false, "Welcome to bank bank, please type your password", 25, 5, 35, 1);
			pin1 = int.Parse(Console.ReadLine());
			Console.Clear();
			//compare PIN
			if (pin1 == pin)
			{

				bool correct = false;
				while (correct == false)
                {
				
					boxxClass box1 = new boxxClass(false, "[1] Check balance   ", 0, 11, 2, 21);
					boxxClass box2 = new boxxClass(false, "[2] Withdraw money   ", 0, 13, 26, 21);
					boxxClass box3 = new boxxClass(false, "[3] Deposit money", 0, 15, 51, 21);
					boxxClass box4 = new boxxClass(false, "[4] Change password", 0, 15, 72, 21);
					boxxClass box5 = new boxxClass(false, "[5] Exit      ", 0, 15, 95, 21);
					Console.SetCursorPosition(0, 0);
					string choice = Console.ReadLine();

					switch (choice)
					{
						case "1":
							Console.WriteLine($"The current balance in your account is {amt}");
							Console.ReadKey();
							correct = true;
							break;

						case "2":
							Console.WriteLine("How much would you like to withdraw?");
							{
								a = (int)double.Parse(Console.ReadLine());
								if (amt >= a)
								{
									if (a % 100 == 0)
									{
										Console.WriteLine($"Please collect the cash {a}");
										current = amt - a;
										Console.WriteLine($"The current balance is now {current}");
									}
									else
										Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
								}
								else
									Console.WriteLine("Your account does not have sufficient balance");
							}
							correct = true;
							break;
						case "3":
							Console.WriteLine("Enter the amount you wish to deposit");
							a = (int)double.Parse(Console.ReadLine());
							current = amt + a;
							Console.WriteLine($"The current balance is {current}");
							Console.ReadKey();
							correct = true;
							break;
						case "4":
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
								correct = true;
							}
							else
								Console.WriteLine("Enter your correct password");
							correct = false;
							break;
						case "5":
							Console.WriteLine("Thanks for using Bank Bank");
							correct = true;
							break;
						default:
							Console.WriteLine("Error: Wrong choice");
							Console.ReadKey();
							Console.Clear();
							correct = false;
							break;
                    }
                }
            }
			else
			{
				Console.WriteLine("Wrong Password");
				Console.ReadLine();
			}
		}
	}
}

