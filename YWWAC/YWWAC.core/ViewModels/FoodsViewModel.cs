using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using YWWAC.core.Services;
using System.Linq;
using System.Diagnostics;

namespace YWWAC.core.ViewModels
{
    public class FoodsViewModel : MvxViewModel
    {
        private ObservableCollection<FoodSearchResults> foods;
        public ObservableCollection<FoodSearchResults> Foods
        {
            get { return foods; }
            set { SetProperty(ref foods, value); }
        }
        private string searchTerm;
        public string SearchTerm
        {
            get { return searchTerm; }
            set
            {
                SetProperty(ref searchTerm, value);
                if (searchTerm.Length > 2)
                {
                    SearchFoods(searchTerm);
                }
            }
        }
        public ICommand SelectFoodCommand { get; private set; }
        public FoodsViewModel()
        {
            Foods = new ObservableCollection<FoodSearchResults>();
            SelectFoodCommand = new MvxCommand<FoodSearchResults>(selectedFood => ShowViewModel<FoodViewModel>(selectedFood));
        }
        public async void SearchFoods(string searchTerm)
        {
            FoodService foodService = new FoodService();
            Foods.Clear();
            var foodResults = await foodService.GetFoods(searchTerm);
            foreach (var item in foodResults)
            {
                Foods.Add(item);
            }
        }
    }
}
