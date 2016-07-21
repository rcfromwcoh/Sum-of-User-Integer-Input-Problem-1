using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfUserInputIntegersProblem1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*  Create a program that asks the user for integers. 
            *  Print to the console all integers that have been entered and the sum of the integers. 
            *  The integers should be entered one at a time.


            Your program should:

            Ask the user for 1 number.
            Print the number and the current sum.
            Ask the user if he/she would like to enter another number.
            If the user enters "YES", steps 1-3 should be repeated until the user does not enter "YES".
            When step 2 is repeated, all numbers that have been entered should print, not just the current number entered.
            User's "YES" response should be case insensitive.
            If the user enters "NO" (case insensitive), print "GOODBYE..." and the program should end.
            */

            



                int firstNum = 1;
                int secondNum = 1;
                string yesOrNo = null;

            do
            {

                Console.WriteLine("Enter a number to sum:");
                firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("NUMBERS ENTERED:\n" + firstNum + " SUM: " + firstNum);


                Console.WriteLine("Do you want to add another number? (YES/NO)");
                yesOrNo = Console.ReadLine();
                yesOrNo = yesOrNo.ToUpper();
                do
                {


                    if (yesOrNo == "YES")
                    {

                        Console.WriteLine("Enter a number to sum:");
                        secondNum = int.Parse(Console.ReadLine());
                        int firstSum = firstNum + secondNum;
                        Console.WriteLine("NUMBERS ENTERED:\n" + firstNum + secondNum + " SUM: " + firstSum);
                        Console.WriteLine("Do you want to add another number? (YES/NO)");
                        yesOrNo = Console.ReadLine();
                        yesOrNo = yesOrNo.ToUpper();
                    }
                }
                while (yesOrNo == "YES");
                
            }
            while (yesOrNo == "YES");

            Console.WriteLine("GOODBYE");
            Console.ReadKey();

        }
    }
}
