using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using YWWAC.core.Interfaces;
using YWWAC.core.Database;
using YWWAC.Droid.Database;

namespace YWWAC.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }
        protected override void InitializeFirstChance()
        {
            Mvx.LazyConstructAndRegisterSingleton<ISqlite, SqliteDroid>();
            Mvx.LazyConstructAndRegisterSingleton<IFoodsDatabase, FoodsDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IExercisesDatabase, ExercisesDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IMeasurementsDatabase, MeasurementsDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IConsultantsDatabase, ConsultantsDatabase>();
            Mvx.LazyConstructAndRegisterSingleton<IGoalsDatabase, GoalsDatabase>();
            base.InitializeFirstChance();
        }
    }
}
