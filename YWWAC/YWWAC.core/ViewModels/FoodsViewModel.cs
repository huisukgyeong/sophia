using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace YWWAC.core.ViewModels
{
    public class FoodsViewModel : MvxViewModel
    {
        private ObservableCollection<Food> foodNames;
        public ObservableCollection<Food> FoodNames
        {
            get { return foodNames; }
            set { SetProperty(ref foodNames, value); }
        }
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref foodName, value);
                }
            }
        }
        public ICommand AddFoodCommand { get; private set; }
        public ICommand SelectFoodCommand { get; private set; }
        public FoodsViewModel()
        {
            FoodNames = new ObservableCollection<Food>() { };
            AddFoodCommand = new MvxCommand(() =>
            {
                AddFood(new Food(FoodName));
                RaisePropertyChanged(() => FoodNames);      
            });
            SelectFoodCommand = new MvxCommand<Food>(selectedFood => ShowViewModel<FoodViewModel>(selectedFood));
        }
        public void AddFood(Food newFood)
        {
            if (newFood.FoodName != null)
            {
                FoodNames.Add(newFood);
            }
        }
    }
}
