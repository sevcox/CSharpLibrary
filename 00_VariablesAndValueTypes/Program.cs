using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish};
    class Program
    {
        static void Main(string[] args)
        {
            // Bools
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            char character = 'a';
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n';

            //Whole Numbers
            byte byteExample = 255; //Max value = 255
            sbyte sByteExample = -128;
            //This next two are the same thing.
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExampleMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 7;
            int b = -7000; //terminal runs -7000 first and stores it as b next

            byte age = 104;

            // Decimals
            float floatExample = 1.045231f; //needs a f
            double doubleExample = 1.789053278907036d; //you can either put a d or not
            decimal decimalExample = 1.2578907289045789789789789787897m; //needs a m
            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);




            // Enums
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            //Structs
            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1805, 11, 24);
            DateTime test = new DateTime();

            int first = 7;
            int second = 2;
            int quo = first / second;
            Console.WriteLine(quo);

            int code = 17;
            int quantity = 55;
            int temp = code;
            code = quantity;
            quantity = temp;
            Console.WriteLine(quantity);
            Console.WriteLine(code);

            int[] allNums = { 1, 2, 3, 4, 5 };

            int index = 0;

            while (index <= 5)
            {
                Console.WriteLine($"Last index {allNums[index]}");
                index++;
            }

            Console.ReadKey(); //This stops the code and tells the user that it needs some sort of input/command
        }

    }
}
