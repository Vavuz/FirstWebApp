using FirstWebApp.Core;
using System;
namespace FirstWebApp.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Edinburgh", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Prathamesh's Curry", Location = "Glasgow", Cuisine = CuisineType.Indian},
                new Restaurant { Id = 3, Name = "Marco's Tacos", Location = "Inverness", Cuisine = CuisineType.Mexican}
            };
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);    // Returns either the one restaurant that matches or the default value (null)
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.ToLower().StartsWith(name.ToLower())
                   orderby r.Name
                   select r;
        }
    }
}
