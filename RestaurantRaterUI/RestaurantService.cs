using RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRaterUI
{
    public class RestaurantService
    {
        private readonly HttpClient _client = new HttpClient();

        //GET ALL Restaurants
        public async Task<List<Restaurant>> GetRestaurantsAsync()
        {
            HttpResponseMessage response = await _client.GetAsync("https://localhost:44361/api/Restaurant");
            if (response.IsSuccessStatusCode)
            {
                List<Restaurant> restaurants = await response.Content.ReadAsAsync<List<Restaurant>>();
                return restaurants;
            }
            return new List<Restaurant>();
        }

        //Get By Id
        public async Task<Restaurant> GetRestaurantByIdAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync("https://localhost:44361/api/Restaurant" + id);
            if (response.IsSuccessStatusCode)
            {
                Restaurant restaurants = await response.Content.ReadAsAsync<Restaurant>();
                return restaurants;
            }
            return null;
        }
    }
}
