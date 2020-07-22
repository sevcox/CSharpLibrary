using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            FizzBuzz(15);

            SayHello("Erick");
            SayHello("Harry");

            int inputOne = 7;
            int inputTwo = 13;
            int sum = AddTwoNumbers(inputOne, inputTwo);
            Console.WriteLine(sum);

            double doubleSum = AddTwoNumbers(242.2d, 234.5);
            Console.WriteLine(doubleSum);

            int myAge = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine("My age is: " + myAge);
        }
        // public = access modifier
        // void = return type
        // TestMethod1 () = method signature (also the parentheses equals parameters- we currently have none
        //{} = body

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumbers(double one, double two)
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
        public void FizzBuzz(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
          
  
            }
        }
    }
}
