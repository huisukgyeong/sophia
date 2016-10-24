using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class FoodViewModel : MvxViewModel
    {
        private NutritionWrapper selectedFood;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }
        private string foodWeight;
        public string FoodWeight
        {
            get { return foodWeight; }
            set
            {
                SetProperty(ref foodWeight, value);
            }
        }
        private string calories;
        public string Calories
        {
            get { return calories; }
            set
            {
                SetProperty(ref calories, value);
            }
        }
        private string protein;
        public string Protein
        {
            get { return protein; }
            set
            {
                SetProperty(ref protein, value);
            }
        }
        private string fat;
        public string Fat
        {
            get { return fat; }
            set
            {
                SetProperty(ref fat, value);
            }
        }
        private string carbohydrates;
        public string Carbohydrates
        {
            get { return carbohydrates; }
            set
            {
                SetProperty(ref carbohydrates, value);
            }
        }
        public void Init(NutritionWrapper parameters)
        {
            selectedFood = parameters;
            Name = selectedFood.Name;
        }
        public override void Start()
        {
            base.Start();
            FoodWeight = String.Format("{0}g", selectedFood.FoodWeight);
            Calories = String.Format("{0}cal", selectedFood.Calories);
            Protein = String.Format("{0}", selectedFood.Protein);
            Fat = String.Format("{0}", selectedFood.Fat);
            Carbohydrates = String.Format("{0}", selectedFood.Carbohydrates);
        }
    }
}
