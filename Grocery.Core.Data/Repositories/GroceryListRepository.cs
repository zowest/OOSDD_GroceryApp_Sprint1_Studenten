﻿using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class GroceryListRepository : IGroceryListRepository
    {
        private readonly List<GroceryList> groceryLists;

        public GroceryListRepository()
        {
            groceryLists = [
                new GroceryList(1, "Familieweekend boodschappen", DateOnly.Parse("2024-12-14"), "#FF6A00", 1),
                new GroceryList(2, "Kerstboodschappen", DateOnly.Parse("2024-12-07"), "#626262", 1),
                new GroceryList(3, "Weekend boodschappen", DateOnly.Parse("2024-11-30"), "#003300", 1)];
        }

        public List<GroceryList> GetAll()
        {
            return groceryLists;
        }
        public GroceryList Add(GroceryList item)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Delete(GroceryList item)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Get(int id)
        {
            throw new NotImplementedException();
        }

        public GroceryList? Update(GroceryList item)
        {
            throw new NotImplementedException();
        }
    }
}
