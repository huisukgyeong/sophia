using MvvmCross.Core.ViewModels;

namespace YWWAC.core.ViewModels
{
    //Author: Leon Tran n9157841
    public class MeasurementsViewModel : MvxViewModel
    {
        private string weight;
        private string height;
        private string waist;
        private string heartrate;
        private string bloodPressureMax;
        private string bloodPressureMin;
        public MvxCommand FoodViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FoodsViewModel>());
            }
        }
        public string Weight
        {
            get { return weight; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref weight, value);
                }
            }
        }
        public string Height
        {
            get { return height; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref height, value);
                }
            }
        }
        public string Waist
        {
            get { return waist; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref waist, value);
                }
            }
        }
        public string Heartrate
        {
            get { return heartrate; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref heartrate, value);
                }
            }
        }
        public string BloodPressureMax
        {
            get { return bloodPressureMax; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref bloodPressureMax, value);
                }
            }
        }
        public string BloodPressureMin
        {
            get { return bloodPressureMin; }
            set
            {
                if (value != null)
                {
                    SetProperty(ref bloodPressureMin, value);
                }
            }
        }
        //dummy data
        public MvxCommand SenseWeight { get; private set; }
        public MvxCommand SenseHeight { get; private set; }
        public MvxCommand SenseWaist { get; private set; }
        public MvxCommand SenseHeartrate { get; private set; }
        public MvxCommand SenseBloodPressure { get; private set; }
        public MeasurementsViewModel()
        {
            //dummy data
            SenseWeight = new MvxCommand(() =>
            {
                Weight = "52";
            });
            SenseHeight = new MvxCommand(() =>
            {
                Height = "167";
            });
            SenseWaist = new MvxCommand(() =>
            {
                Waist = "80";
            });
            SenseHeartrate = new MvxCommand(() =>
            {
                Heartrate = "60";
            });
            SenseBloodPressure = new MvxCommand(() =>
            {
                BloodPressureMax = "120";
                BloodPressureMin = "80";
            });
        }
    }

    //Author: Dongmin Park n8920281
    public class SecondViewModel : MvxViewModel
    {
        public MvxCommand MenuViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<MenuViewModel>());
            }
        }
    }

    //Author: Huisuk Gyeong n9230424
    public class ThirdViewModel : MvxViewModel
    {
        public MvxCommand GoCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SecondViewModel>());
            }
        }
    }
}
