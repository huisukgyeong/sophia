using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Consultants")]
    public class ConsultationView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ConsultationView);
        }
        protected override void OnResume()
        {
            var vm = (ConsultationViewModel)ViewModel;
            vm.OnResume();
            base.OnResume();
        }
    }
}