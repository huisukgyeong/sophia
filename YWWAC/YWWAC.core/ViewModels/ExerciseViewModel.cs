using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class ExerciseViewModel : MvxViewModel
    {
        private Exercise selectedExercise;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }
        private string time;
        public string Time
        {
            get { return time; }
            set
            {
                SetProperty(ref time, value);
            }
        }
        public void Init(Exercise parameters)
        {
            selectedExercise = parameters;
        }
        public override void Start()
        {
            base.Start();
            Name = selectedExercise.Name;
            Time = String.Format("Duration: {0}mins", selectedExercise.Time);
        }
    }
}
