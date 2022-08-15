//    Exercise 1
//    Write a program and ask the user to enter a few numbers separated by a hyphen. 
//    Work out if the numbers are consecutive. 
//    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

using System;
using System.Collections.Generic;


namespace CsharpFundamenals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a few numbers separated by a hyphen.");

            var userInput = Console.ReadLine();
            var splitInput = userInput.Split('-');
            List<int> inputArr = new List<int>();
            var consecutive = false;

            foreach (var item in splitInput)
            {
                inputArr.Add(Convert.ToInt32(item));
            }


            for (int i = 0; i < inputArr.Count - 1; i++)
            {
                if ((inputArr[i + 1] - inputArr[i] == 1) || (inputArr[i + 1] - inputArr[i] == -1))
                {
                    consecutive = true;
                }
                else
                {
                    consecutive = false;
                }
            }

            if (consecutive == true)
            {
                Console.WriteLine("It is consecutive");
            }
            else
            {
                Console.WriteLine("It is NOT consecutive");
            }

        }
    }

}
