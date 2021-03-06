﻿using MvvmCross.Core.ViewModels;
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
    public class FoodsViewModel : MvxViewModel
    {
        private ObservableCollection<NutritionWrapper> nutritionData = new ObservableCollection<NutritionWrapper>();
        private readonly IFoodsDatabase foodsDatabase;
        public ObservableCollection<NutritionWrapper> NutritionData
        {
            get { return nutritionData; }
            set { SetProperty(ref nutritionData, value); }
        }
        public ICommand AddNewFoodCommand { get; private set; }
        public ICommand SelectFoodCommand { get; private set; }
        public FoodsViewModel(IFoodsDatabase foodsdatabase)
        {
            this.foodsDatabase = foodsdatabase;
            AddNewFoodCommand = new MvxCommand(() => ShowViewModel<AddFoodViewModel>());
            SelectFoodCommand = new MvxCommand<NutritionWrapper>((selectedFood) => ShowViewModel<FoodViewModel>(selectedFood));
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
                    NutritionData.Add(new NutritionWrapper(foodResult, food));
                }
                else
                {
                    foodsDatabase.DeleteFood(food.Id);
                }
            }
        }
    }
}
