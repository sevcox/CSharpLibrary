using RestaurantRater.Controllers;
using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRaterUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantService rs = new RestaurantService();
            ProgramUI ui = new ProgramUI();

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Select an option: \n" +
                    "1. See all Restaurants\n" +
                    "2.Exit");
                string response = Console.ReadLine();
                if(response == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    List<Restaurant> restaurants = rs.GetRestaurantsAsync().Result;
                    ui.ListRestaurants(restaurants);
                }
                else if(response == "2")
                {
                    keepRunning = false;
                }
            }
        }
    }
}
