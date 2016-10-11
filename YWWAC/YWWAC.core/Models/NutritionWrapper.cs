using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class NutritionWrapper : Nutrition
    {
        private double percentServings;
        public NutritionWrapper(Nutrition nutrition, Food food)
        {
            Name = nutrition.ItemName;
            FoodWeight = food.FoodWeight;
            Protein = nutrition.nf_protein;
            Fat = nutrition.nf_total_fat;
            Carbohydrates = nutrition.nf_total_carbohydrate;
            percentServings = FoodWeight / nutrition.nf_calories;
            Calories = ((4.0 * Protein) + (9.0 * Fat) + (4.0 * Carbohydrates)) * percentServings;
        }
        public string Name { get; set; }
        public double FoodWeight { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public double Calories { get; set; }
    }
}
