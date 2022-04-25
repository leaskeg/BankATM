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
			//Version 1.0.3

			int amt = 10000, a, current, pin = 4040, pin1, pin2;

			//read PIN
			boxxClass boxPass = new boxxClass(false, "Welcome to bank bank, please enter your password", 25, 5, 35, 1);
			pin1 = int.Parse(Console.ReadLine());
			Console.Clear();
			//compare PIN
			if (pin1 == pin)
			{

				bool correct = false;
				while (correct == false)
                {
					splashscreen bigSplash = new splashscreen();
					/*
					boxxClass box1 = new boxxClass(false, "[1] Check balance   ", 0, 11, 2, 21);
					boxxClass box2 = new boxxClass(false, "[2] Withdraw money   ", 0, 13, 26, 21);
					boxxClass box3 = new boxxClass(false, "[3] Deposit money", 0, 15, 51, 21);
					boxxClass box4 = new boxxClass(false, "[4] Change password", 0, 15, 72, 21);
					boxxClass box5 = new boxxClass(false, "[5] Exit      ", 0, 15, 95, 21);
					*/

					//Console.SetCursorPosition(0, 0);
					
					string choice = Console.ReadLine();

					switch (choice)
					{
						case "1":
							Console.Clear();
							Console.WriteLine($"The current balance in your bank account is {amt}");
							
							break;

						case "2":
							Console.Clear();
							Console.WriteLine("How much would you like to withdraw?");
							{
								a = (int)double.Parse(Console.ReadLine());
								if (amt >= a)
								{
									if (a % 100 == 0)
									{
										Console.Clear();
										Console.WriteLine($"Remember to collect your money!");
										current = amt - a;
                                        Console.WriteLine("");
										Console.WriteLine($"The current balance is now {current}");
									}
									else
										Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
								}
								else
									Console.WriteLine("Your account does not have sufficient balance");
							}
							break;
						case "3":
							Console.Clear();
							Console.WriteLine("Enter the amount you want to deposit");
							a = (int)double.Parse(Console.ReadLine());
							current = amt + a;
							Console.Clear();
							Console.WriteLine($"The current balance is {current}");
							break;
						case "4":
							Console.Clear();
							Console.WriteLine("Enter your previous password");
							int prepin = int.Parse(Console.ReadLine());
							if (prepin == pin)
							{
								Console.WriteLine("Enter your new password");
								pin2 = int.Parse(Console.ReadLine());
								pin1 = pin2;
								Console.WriteLine("Your password is changed");

							}
							else
								Console.WriteLine("Enter the correct password");
							correct = false;
							break;
						case "5":
							Console.WriteLine("Thanks for using Bank Bank");
							correct = true;
							break;
						default:
							Console.WriteLine("Error: Wrong input");
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

