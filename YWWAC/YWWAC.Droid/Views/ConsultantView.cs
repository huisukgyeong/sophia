using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Consultant")]
    public class ConsultantView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ConsultantView);
        }
    }
}