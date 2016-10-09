using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class NutritionWrapper : Nutrition
    {
        public NutritionWrapper(Nutrition nutrition)
        {
            Name = nutrition.ItemName;
            Protein = nutrition.nf_protein;
            Fat = nutrition.nf_total_fat;
            Carbohydrates = nutrition.nf_total_carbohydrate;
            Calories = (4.0 * Protein) + (9.0 * Fat) + (4.0 * Carbohydrates);
        }
        public string Name { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public double Calories { get; set; }
    }
}
