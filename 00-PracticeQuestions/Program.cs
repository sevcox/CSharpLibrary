using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_PracticeQuestions
{
    class Program
    {
        enum WeekDays
        {
           Monday,
           Tuesday,
           Wednesday,
           Thursday,
           Friday,
           Saturday,
           Sunday
        }
        static void Main(string[] args)
        {
            //01-Types
            //Value Types
            int userAge = 23;
            decimal accountBalance = 500.25m;
            char myFavLetter;
            bool isLoggedIn = true;
            double twoNumberSum;
            float bigNumberSum;
            string userName = "sevcox";
            bool isAnAdult;
            string firstName;
            char myFavNumber = '7';
            Console.WriteLine(userAge);
            Console.WriteLine(accountBalance);
            Console.WriteLine(isLoggedIn);
            Console.WriteLine(userName);
            Console.WriteLine(myFavNumber);

            WeekDays myFavWeekDay = WeekDays.Friday;
            Console.WriteLine(myFavWeekDay);

            //Reference Types
            //Composite
            string color = "gold";
            string spamEmail = String.Format("We promise this is not spam. This is pure {0} information.", color);
            string randomSentence = String.Format("We find the {0} so you don't have to.", color);
            string welcomeMessage = String.Format("Hello and welcome to our {0} club membership. We are thrilled to have you join our exclusive membership. {1} Although we are often looked at us spam. We promise that we will always treat you like the {0} member that you are. Remember, {2}", color, spamEmail, randomSentence);
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(spamEmail);
            Console.WriteLine(randomSentence);
            //Interpolation
            string cheese = " cheese";
            string cheeseType = $"string {cheese}";
            string pasta = $"mac and {cheese}";
            string beans = "kidney beans";
            string shoppingList = $"I am going to go shopping for a few items. I know I will need {cheeseType}, {pasta}, and {beans}. I am on a budget though. So maybe only items that have {cheese} in their name.";
            Console.WriteLine(shoppingList);
            //Concatenate/All
            string variable = "Hello";
            //a
            string compositeSentence = String.Format("{0} world, and {0} class. Welcome to the {1} badge.", variable, color);
            Console.WriteLine(compositeSentence);
            //b
            string interpolationSentence = $"{variable} world, and {variable} class. Welcome to the {color} badge.";
            Console.WriteLine(interpolationSentence);
            //c
            string concatenateSentence = variable + " world, and " + variable + " class. Welcome to the " + color + " badge.";
            Console.WriteLine(concatenateSentence);







        }
    }
}
