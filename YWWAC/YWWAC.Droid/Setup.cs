using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using YWWAC.core.Interfaces;
using YWWAC.Droid.Database;
using YWWAC.core.Database;
using MvvmCross.Droid.Views;
using MvvmCross.Droid.Shared.Presenter;

namespace YWWAC.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }
        protected override IMvxApplication CreateApp()
        {
            return new YWWAC.core.App();
        }
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISqlite, SqliteDroid>();
            Mvx.LazyConstructAndRegisterSingleton<IFoodsDatabase, FoodsDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IMeasurementsDatabase, MeasurementsDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IConsultantsDatabase, ConsultantsDatabase>();
            base.InitializeFirstChance();
        }
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);
            return mvxFragmentsPresenter;
        }
    }
}
