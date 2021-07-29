using System;
//Simple calculator program utillizing switch cases and methods.

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loop untill user says N
            char restart;
            do
            {
                //Create any need variables
                double userNum1 = 0;
                double userNum2 = 0;
                double answer = 0;
                double userChoice = 0;
                


                //Invoke methods 
                userChoice = Greeting(userChoice);
                userNum1 = Num1(userNum1);
                userNum2 = Num2(userNum2);
                answer = Answer(userChoice, answer, userNum1, userNum2);

                Console.WriteLine("");
                Console.Write("Would you like to calculate again? Enter Y or N: ");
                restart = Console.ReadLine()[0];

                //Check to see if valid input
                while (restart != 'Y' && restart != 'N')
                {
                    if (restart != 'Y' && restart != 'N')
                    {
                        Console.Write("Invaild input please type in Y or N: ");
                        restart = Console.ReadLine()[0];
                        Console.WriteLine("");
                    }
                }

                //Give a farewell message if user decides to stop program
                if (restart == 'N')
                    Console.WriteLine("Thank you for using simple calculator goodbye!");

            }while (restart == 'Y');

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userChoice"></param>
        /// <param name="answer"></param>
        /// <param name="userNum1"></param>
        /// <param name="userNum2"></param>
        /// <returns></returns>
        static double Answer(double userChoice, double answer, double userNum1, double userNum2)
        {
            switch(userChoice)
            {
                case 1:
                    answer = userNum1 + userNum2;
                    Console.WriteLine(userNum1 + " + " + userNum2 + " = " + answer);
                    break;
                case 2:
                    answer = userNum1 - userNum2;
                    Console.WriteLine(userNum1 + " - " + userNum2 + " = " + answer);
                    break;
                case 3:
                    answer = userNum1 * userNum2;
                    Console.WriteLine(userNum1 + " x " + userNum2 + " = " + answer);
                    break;
                case 4:
                    answer = userNum1 / userNum2;
                    Console.WriteLine(userNum1 + " / " + userNum2 + " = " + answer);
                    break;
            }
            return answer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userNum1"></param>
        /// <returns></returns>
        static double Num1(double userNum1)
        {
            Console.WriteLine("");
            Console.Write("Please enter your 1st number to calculate with: ");
            userNum1 = Convert.ToDouble(Console.ReadLine());
            return userNum1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userNum2"></param>
        /// <returns></returns>
        static double Num2(double userNum2)
        {
            Console.Write("Please enter your 2nd number to calculate with: ");
            userNum2 = Convert.ToDouble(Console.ReadLine());
            return userNum2;
            Console.WriteLine("");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        static double Greeting(double choice)
        { 
            Console.WriteLine("Welcome to Simple Calculator");
            Console.WriteLine(" ");
            Console.WriteLine("Down below are options you can choose from to use on you're two numbers");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.Write("Please type in the number that corresponds to your choice: ");
            choice = Convert.ToDouble(Console.ReadLine());
            while (choice != 1 & choice != 2 & choice != 3 & choice != 4)
            {
                if (choice != 1 & choice != 2 & choice != 3 & choice != 4)
                {
                    Console.Write("Your input is invaid please try again: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }
            return choice;
        }
    }
}
