using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class AddExerciseViewModel : MvxViewModel
    {
        private readonly IExercisesDatabase exercisesDatabase;
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        private double time;
        public double Time
        {
            get { return time; }
            set { SetProperty(ref time, value); }
        }
        public ICommand AddExerciseCommand { get; private set; }
        public AddExerciseViewModel(IExercisesDatabase exercisesDatabase)
        {
            this.exercisesDatabase = exercisesDatabase;
            AddExerciseCommand = new MvxCommand(() =>
            {
                Exercise newExercise = new Exercise(Name, Time);
                AddExercise(newExercise);
            });
        }
        public async void AddExercise(Exercise newExercise)
        {
            await exercisesDatabase.InsertExercise(newExercise);
            Close(this);
        }
    }
}
