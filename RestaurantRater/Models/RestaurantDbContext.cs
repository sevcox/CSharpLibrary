using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("DefaultConnection") {} //this is inheriting a default constructor from the base class
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}