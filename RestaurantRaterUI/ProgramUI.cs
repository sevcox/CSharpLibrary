using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRaterUI
{
    public class ProgramUI
    {
        public void ListRestaurants (List<Restaurant> restaurants)
        {
            Console.Clear();
            int count = 1;
            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine($"{count + ".", -5} {restaurant.Name, -20} {restaurant.Address, -20} {restaurant.Rating, -10}");
                count++;
            }
            Console.ReadKey();
        }
    }
}
