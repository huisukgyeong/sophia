using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Food
    {
        public Food() { }
        public Food(FoodSearchResults food)
        {
            ItemId = food.Id;
            ItemName = food.fields.ItemName;
            BrandName = food.fields.BrandName;
        }
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string BrandName { get; set; }
    }
}
