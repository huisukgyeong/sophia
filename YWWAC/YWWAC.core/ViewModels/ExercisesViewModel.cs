using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class ExercisesViewModel : MvxViewModel
    {
        private ObservableCollection<Exercise> exercises = new ObservableCollection<Exercise>();
        private readonly IExercisesDatabase exercisesDatabase;
        public ObservableCollection<Exercise> Exercises
        {
            get { return exercises; }
            set { SetProperty(ref exercises, value); }
        }
        public ICommand AddNewExerciseCommand { get; private set; }
        public ICommand SelectExerciseCommand { get; private set; }
        public ExercisesViewModel(IExercisesDatabase exercisesDatabase)
        {
            this.exercisesDatabase = exercisesDatabase;
            AddNewExerciseCommand = new MvxCommand(() => ShowViewModel<AddExerciseViewModel>());
            SelectExerciseCommand = new MvxCommand<Exercise>((selectedExercise) => ShowViewModel<ExerciseViewModel>(selectedExercise));
        }
        public void OnResume()
        {
            GetExerciseData();
        }
        public async void GetExerciseData()
        {
            var exerciseResults = await exercisesDatabase.GetExercises();
            Exercises.Clear();
            foreach (var exercise in exerciseResults)
            {
                if (exercise != null)
                {
                    Exercises.Add(new Exercise(exercise.Name, exercise.Time));
                }
                else
                {
                    exercisesDatabase.DeleteExercise(exercise.Id);
                }
            }
        }
    }
}
