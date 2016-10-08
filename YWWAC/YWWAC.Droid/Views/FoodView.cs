using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Food")]
    public class FoodView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FoodView);
        }
        protected override void OnResume()
        {
            var vm = (FoodViewModel)ViewModel;
            vm.OnResume();
            base.OnResume();
        }
    }
}
