using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Measurements")]
    public class MeasurementsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MeasurementsView);
        }
        protected override void OnResume()
        {
            var vm = (MeasurementsViewModel)ViewModel;
            vm.OnResume();
            base.OnResume();
        }
    }
}
