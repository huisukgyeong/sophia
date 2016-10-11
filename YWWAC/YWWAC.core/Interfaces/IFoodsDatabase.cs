using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Interfaces
{
    public interface IFoodsDatabase
    {
        Task<IEnumerable<Food>> GetFoods();
        Task<int> DeleteFood(object id);
        Task<int> InsertFood(Food food);
        Task<int> InsertFood(FoodSearchResults food, double foodWeight);
    }
}
