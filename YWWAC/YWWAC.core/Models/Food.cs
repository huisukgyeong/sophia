using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Food
    {
        public string FoodName { get; set; }
        public double FoodAmount { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }

        public Food() { }
        public Food(string foodName)
        {
            FoodName = foodName;
            FoodAmount = 150.0;
            Protein = 12.0;
            Fat = 8.0;
            Carbohydrates = 35.0;
        }
    }
}
