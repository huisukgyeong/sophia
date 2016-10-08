using MvvmCross.Platform;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.Database
{
    public class FoodsDatabase : IFoodsDatabase
    {
        private SQLiteConnection database;
        public FoodsDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Food>();
        }
        public async Task<IEnumerable<Food>> GetFoods()
        {
            return database.Table<Food>().ToList();
        }
        public async Task<int> DeleteFood(object id)
        {
            return database.Delete<Food>(Convert.ToInt16(id));
        }
        public async Task<int> InsertFood(Food food) {
            var num = database.Insert(food);
            database.Commit();
            return num;
        }
        public async Task<int> InsertFood(FoodSearchResults food)
        {
            return await InsertFood(new Food(food));
        }
    }
}
