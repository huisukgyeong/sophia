using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Library")]
    public class InformationMenuView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.InformationMenuView);
        }
    }
}
