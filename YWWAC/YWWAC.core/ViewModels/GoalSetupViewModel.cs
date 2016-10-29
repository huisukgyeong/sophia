using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class GoalSetupViewModel : MvxViewModel
    {
        List<Goals> goals = new List<Goals>();
        private readonly IGoalsDatabase goalsDatabase;
        private double currentWeight;
        public double CurrentWeight
        {
            get { return currentWeight; }
            set
            {
                SetProperty(ref currentWeight, value);
            }
        }
        private double currentHeight;
        public double CurrentHeight
        {
            get { return currentHeight; }
            set
            {
                SetProperty(ref currentHeight, value);
            }
        }
        private double goalWeight;
        public double GoalWeight
        {
            get { return goalWeight; }
            set
            {
                SetProperty(ref goalWeight, value);
            }
        }
        public MvxCommand SaveCommand { get; private set; }
        public GoalSetupViewModel(IGoalsDatabase goalsDatabase)
        {
            this.goalsDatabase = goalsDatabase;
            SaveCommand = new MvxCommand(() =>
            {
                Goals newGoals = new Goals(CurrentWeight, CurrentHeight, GoalWeight);
                SaveGoals(newGoals);
            });
        }
        public async void SaveGoals(Goals goals)
        {
            await goalsDatabase.InsertGoals(goals);
            ShowViewModel<MenuViewModel>();
        }
        public void OnResume()
        {
            GetGoalsData();
        }
        public async void GetGoalsData()
        {
            var goalsResults = await goalsDatabase.GetGoals();
            foreach (var goals in goalsResults)
            {
                if (goals != null)
                {
                    CurrentWeight = goals.CurrentWeight;
                    CurrentHeight = goals.CurrentHeight;
                    GoalWeight = goals.GoalWeight;
                }
            }
        }
    }
}
