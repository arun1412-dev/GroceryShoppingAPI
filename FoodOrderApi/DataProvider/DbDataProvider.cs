﻿using FoodOrderApi.Model;
using FoodOrderApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderApi.DataProvider
{
    public class DbDataProvider : Controller, IDataProvider
    {
        private readonly FoodApiDbContext foodApiDbContext;
        public static List<Order> _CustomerOrder = new List<Order>();

        public DbDataProvider(FoodApiDbContext foodApiDbContext)
        {
            this.foodApiDbContext = foodApiDbContext;
            //AddRestrauntData();
        }

        public IEnumerable<Menu> GetMenuDisplay()
        {
            return foodApiDbContext.Menus.Select(x => x);
        }

        public IEnumerable<Order> GetOrderByName(string customerName)
        {
            return foodApiDbContext.Orders.Select(x => x).Where(item => item.CustomerName == customerName);
        }

        public IEnumerable<Restaurant> GetRestaurant()
        {
            return foodApiDbContext.Restaurants.Select(x => x);
        }

        public void PlaceOrder(Order newCustomerOrder)
        {
            foodApiDbContext.Orders.Add(newCustomerOrder);
            foodApiDbContext.SaveChanges();
        }

        public void DeleteOrder(Order newCustomerOrder)
        {
            foodApiDbContext.Orders.Remove(newCustomerOrder);
            foodApiDbContext.SaveChanges();
        }

        public void AddRestrauntData()
        {
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 2, ProductID = 1, ProductName = "Idly(2)", ProductPrice = "33" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 1, ProductID = 1, ProductName = "Thai Broccoli Salad", ProductPrice = "255" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 1, ProductID = 2, ProductName = "Chettinad Cutlet", ProductPrice = "275" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 1, ProductID = 3, ProductName = "Curd Rice Aracini", ProductPrice = "265" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 2, ProductID = 2, ProductName = "Pongal", ProductPrice = "48" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 2, ProductID = 3, ProductName = "Roast", ProductPrice = "75" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 3, ProductID = 1, ProductName = "Chocolate Sizzler", ProductPrice = "299" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 3, ProductID = 2, ProductName = "Choco Brownie Bomb", ProductPrice = "249" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 3, ProductID = 3, ProductName = "Chocolate Cookies", ProductPrice = "199" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 4, ProductID = 1, ProductName = "Vegetable Club Sandwich", ProductPrice = "150" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 4, ProductID = 2, ProductName = "Veg Combo Meal", ProductPrice = "439" });
            foodApiDbContext.Menus.Add(new Menu() { RestaurantID = 4, ProductID = 3, ProductName = "Orbis Signature Rice", ProductPrice = "250" });

            foodApiDbContext.SaveChanges();
        }
    }
}