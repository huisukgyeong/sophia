using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Services;
using System.Diagnostics;
using System.Windows.Input;
using YWWAC.core.Interfaces;
using YWWAC.core.Database;
using System.Collections.Generic;

namespace YWWAC.core.ViewModels
{
    public class FoodViewModel : MvxViewModel
    {
        List<FoodSearchResults> foods = new List<FoodSearchResults>();
        private ObservableCollection<NutritionWrapper> nutritionData = new ObservableCollection<NutritionWrapper>();
        private readonly IFoodsDatabase foodsDatabase;
        public ObservableCollection<NutritionWrapper> NutritionData
        {
            get { return nutritionData; }
            set { SetProperty(ref nutritionData, value); }
        }
        public ICommand AddNewFoodCommand { get; private set; }
        public FoodViewModel(IFoodsDatabase foodsdatabase)
        {
            this.foodsDatabase = foodsdatabase;
            AddNewFoodCommand = new MvxCommand(() => ShowViewModel<FoodsViewModel>());
        }
        public void OnResume()
        {
            GetFoodData();
        }
        public async void GetFoodData()
        {
            var foods = await foodsDatabase.GetFoods();
            var foodService = new FoodService();
            NutritionData.Clear();
            foreach (var food in foods)
            {
                var foodResult = await foodService.GetNutrition(food.ItemId);
                if (foodResult != null)
                {
                    NutritionData.Add(new NutritionWrapper(foodResult));
                }
                else
                {
                    foodsDatabase.DeleteFood(food.Id);
                }
            }
        }
    }
}
