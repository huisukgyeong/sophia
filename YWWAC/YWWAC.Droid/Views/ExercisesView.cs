using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Exercises")]
    public class ExercisesView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ExercisesView);
        }
        protected override void OnResume()
        {
            var vm = (ExercisesViewModel)ViewModel;
            vm.OnResume();
            base.OnResume();
        }
    }
}