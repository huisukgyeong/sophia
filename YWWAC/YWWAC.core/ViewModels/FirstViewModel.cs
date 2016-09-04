using MvvmCross.Core.ViewModels;

namespace YWWAC.core.ViewModels
{
    //Author: Leon Tran n9157841
    public class FirstViewModel : MvxViewModel
    {
        private string weight;
        private string height;
        private string waist;
        private string heartrate;
        private string bloodPressureMax;
        private string bloodPressureMin;
        public IMvxCommand SenseWeight { get; private set; }
        public IMvxCommand SenseHeight { get; private set; }
        public IMvxCommand SenseWaist { get; private set; }
        public IMvxCommand SenseHeartrate { get; private set; }
        public IMvxCommand SenseBloodPressure { get; private set; }
        public FirstViewModel()
        {
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
    }

    //Author: Dongmin Park n8920281
    public class SecondViewModel : MvxViewModel
    {
    
    }

    //Author: Huisuk Gyeong n9230424
    public class ThirdViewModel : MvxViewModel
    {

    }
}
