using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using YWWAC.core.ViewModels;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Food")]
    public class FoodsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FoodsView);
        }
        protected override void OnResume()
        {
            var vm = (FoodsViewModel)ViewModel;
            vm.OnResume();
            base.OnResume();
        }
    }
}
