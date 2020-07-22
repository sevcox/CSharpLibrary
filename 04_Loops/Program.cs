﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("You did it!");
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            //For Loop
            int studentCount = 21;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
            int number = 15;
            for (int x = 1; x <= number; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }

                string[] students = { "Nick", "Adam", "AJ", "Austin", "Severa", "Tim" };
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine($"Hello there! {students[i]}!");
                }

                //Foreach
                foreach (string student in students)
                {
                    Console.WriteLine(student + " is in the class today");
                }

                string myName = "Amanda Joy Knight";
                foreach (char letter in myName)
                {
                    if (letter != ' ')
                    {
                        Console.WriteLine(letter);
                    }
                }

                // Do While
                int iterator = 0;
                do
                {
                    Console.WriteLine("Hello!");
                    iterator++;
                }
                while (iterator < 5);

                do
                {
                    Console.WriteLine("My do while condition is false!");
                }
                while (false);
                Console.ReadKey();
        

        }
    }
}
