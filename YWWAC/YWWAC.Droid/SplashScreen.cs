using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace YWWAC.Droid
{
    [Activity(
        Label = "YWWAC"
        , MainLauncher = true
        , Icon = "@drawable/logo"
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
