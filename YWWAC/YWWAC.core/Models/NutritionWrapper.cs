using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class NutritionWrapper : Nutrition
    {
        public NutritionWrapper() { }
        public NutritionWrapper(Nutrition nutrition, Food food)
        {
            Name = nutrition.ItemName;
            FoodWeight = food.FoodWeight;
            percentServings = FoodWeight / nutrition.nf_serving_weight_grams;
            Protein = Math.Round(nutrition.nf_protein * 4.0 * percentServings, 2);
            Fat = Math.Round(nutrition.nf_total_fat * 9.0 * percentServings, 2);
            Carbohydrates = Math.Round(nutrition.nf_total_carbohydrate * 4.0 * percentServings, 2);
            Calories = Math.Round(nutrition.nf_calories * percentServings, 2);
        }
        private double percentServings;
        public string Name { get; set; }
        public double FoodWeight { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public double Calories { get; set; }
    }
}
