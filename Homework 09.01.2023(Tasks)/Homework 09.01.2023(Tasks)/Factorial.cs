﻿using Homework_09._01._2023_Tasks_.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._01._2023_Tasks_
{
    public class Factorial
    {
        public void GetFactorial()

        {

            try
            {
                Factorials();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Factorials()
        {
            int number;
            int factorial = 1;

            Console.WriteLine("Enter Number:");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;

                }
                Console.WriteLine(factorial);
            }
            if (number<0)
            {
                throw new InvalidFactorialException(HelperMessage.Message);
            }
        }
    }
}
