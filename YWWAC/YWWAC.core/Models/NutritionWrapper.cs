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
        }
        public string Name { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
    }
}
