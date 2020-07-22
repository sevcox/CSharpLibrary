using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluated.");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you are ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry we are closed!");
                    break;
            }

            //-- Challenge
            // Ask the user how they are feeling on a scale of 1-5. Capture their input and run it through a switch statement. Output a different response for each value. If they respond out of range, let them know.

            Console.WriteLine("How are you feeling today? Rate on a scale of 1 to 5. 1 being absolutely terrible and 5 being absolutely wonderful!");
            string feelingRating = Console.ReadLine();
            int userInput = Int16.Parse(feelingRating);

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Well that is just terrible! I hope you are able to get some rest, so that you can try again tomorrow!");
                    break;
                case 2:
                    Console.WriteLine("I'm sorry! Try eating some chocolate! That always makes my day better!");
                    break;
                case 3:
                    Console.WriteLine("Not too shabby! Try writing a few things that made you happy today and maybe we could increase that number.");
                    break;
                case 4:
                    Console.WriteLine("That's great news! Day is not over yet until your head hits the pillow! Plenty of time to make it the best day yet!");
                    break;
                case 5:
                    Console.WriteLine("AWESOME! Go out and share some greatness with the world!");
                    break;
                default:
                    Console.WriteLine("Ummmmm... Did you even read the instructions! Number 1-5 only please!");
                    break;
            }
            Console.ReadKey();

           

        }
    }
}
