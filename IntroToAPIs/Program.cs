﻿using IntroToAPIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAPIs
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/1").Result; // GetAsync sends a request to pull data

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Person personResponse = response.Content.ReadAsAsync<Person>().Result;

                foreach(string vehicleUrl in personResponse.Vehicles) //itireating through each string in the string array of vehicles 
                {
                    HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result); //this just displays the JSON object

                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result; //converts JSON object to POCO
                    Console.WriteLine(vehicle.Name);
                }
            }

            SWAPIService swapiService = new SWAPIService();

            //Person anotherPerson = httpClient.GetAsync("https://swapi.dev/api/people/1").Result.Content.ReadAsAsync<Person>().Result;
            Person personTwo = swapiService.GetPersonAsync("https://swapi.dev/api/people/1").Result; //same thing as above just more dry by using the method we created
            if (personTwo != null)
            {
                Console.WriteLine(personTwo.Name);

                foreach (string vehicleUrl in personTwo.Vehicles)
                {
                    Vehicle vehicle = swapiService.GetVehicleAsync(vehicleUrl).Result;
                    Console.WriteLine(vehicle.Name);
                }
            }

            var genericResponse = swapiService.GetAsync<Person>("https://swapi.dev/api/people/7").Result;
            if(genericResponse != null)
            {
                Console.WriteLine(genericResponse.Name);
            }
            else
            {
                Console.WriteLine("The target object does not exist.");
            }

            SearchResult<Person> skywalker = swapiService.GetPersonSearchAsync("skywalker").Result;
            foreach(Person person in skywalker.Results)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
