//using RestaurantApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RestaurantApp.Services
//{
//    public class InMemmoryRestaurantData : IRestaurantData
//    {
//        public InMemmoryRestaurantData()
//        {
//            _restaurants = new List<Restaurant>()
//            {
//                new Restaurant() {Id = 1, Name = "TookFood"},
//                new Restaurant() {Id = 2, Name = "BasoManiak"},
//                new Restaurant() {Id = 3, Name = "Father's meal"},
//                new Restaurant() {Id = 4, Name = "Kobas for you"},
//            };
//        }
        

//        public IEnumerable<Restaurant> GetAll()
//        {
//            return _restaurants.OrderBy(r => r.Name);
//        }

//        public Restaurant Get(int id)
//        {
//            return _restaurants.FirstOrDefault(l => l.Id == id);
//        }

//        public Restaurant Add(Restaurant restaurant)
//        {
//            restaurant.Id = _restaurants.Max(r => r.Id) + 1;
//            _restaurants.Add(restaurant);
//            return restaurant;
//        }

//        private List<Restaurant> _restaurants;
//    }
//}
