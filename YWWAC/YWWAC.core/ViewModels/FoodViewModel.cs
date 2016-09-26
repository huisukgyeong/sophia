using MvvmCross.Core.ViewModels;
using YWWAC.core.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.ViewModels
{
    class FoodViewModel : MvxViewModel
    {
        private Food selectedFood;
        private string foodName;
        public string FoodName
        {
            get { return foodName; }
            set { SetProperty(ref foodName, value); }
        }
        private double foodAmount;
        public double FoodAmount
        {
            get { return foodAmount; }
            set { SetProperty(ref foodAmount, value); }
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
        public void Init(Food parameters)
        {
            selectedFood = parameters;
        }
        public override void Start()
        {
            base.Start();
            FoodName = selectedFood.FoodName;
            GetFoodData();
        }

        public void GetFoodData()
        {
            Protein = selectedFood.Protein;
            Fat = selectedFood.Fat;
            Carbohydrates = selectedFood.Carbohydrates;
        }
    }
}
