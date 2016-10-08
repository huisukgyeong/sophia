using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Services;
using System.Diagnostics;

namespace YWWAC.core.ViewModels
{
    class FoodViewModel : MvxViewModel
    {
        private FoodSearchResults selectedFood;
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private int weight;
        public int Weight
        {
            get { return weight; }
            set { SetProperty(ref weight, value); }
        }
        private double calories;
        public double Calories
        {
            get { return calories; }
            set { SetProperty(ref calories, value); }
        }
        private int servingWeight;
        public int ServingWeight
        {
            get { return servingWeight; }
            set { SetProperty(ref servingWeight, value); }
        }
        private double protein;
        public double Protein
        {
            get { return protein; }
            set { SetProperty(ref protein, value); }
        }
        private double fat;
        public double Fat
        {
            get { return fat; }
            set { SetProperty(ref fat, value); }
        }
        private double carbohydrates;
        public double Carbohydrates
        {
            get { return carbohydrates; }
            set { SetProperty(ref carbohydrates, value); }
        }
        public void Init(FoodSearchResults parameters)
        {
            selectedFood = parameters;
        }
        public override void Start()
        {
            base.Start();
            GetFoodData();
        }

        public async void GetFoodData()
        {
            var foodService = new FoodService();
            var foodResult = await foodService.GetNutrition(selectedFood.Id);
            Name = foodResult.item_name;
            Calories = foodResult.nf_calories;
            ServingWeight = foodResult.nf_serving_weight_grams;
            Protein = foodResult.nf_protein;
            Fat = foodResult.nf_total_fat;
            Carbohydrates = foodResult.nf_total_carbohydrate;
        }
    }
}
