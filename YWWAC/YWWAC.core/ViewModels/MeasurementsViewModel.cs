using MvvmCross.Core.ViewModels;
using System;
using System.Windows.Input;

namespace YWWAC.core.ViewModels
{
    public class MeasurementsViewModel : MvxViewModel
    {
        //private ObservableCollection<Day> day;
        private DateTime dateTime;
        public DateTime DateTime {
            get { return dateTime; }
            set
            {
                SetProperty(ref dateTime, value);
            }
        }
        private string date;
        public string Date
        {
            get { return date; }
            set
            {
                SetProperty(ref date, value);
            }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                SetProperty(ref weight, value);
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                SetProperty(ref height, value);
            }
        }
        private double waist;
        public double Waist
        {
            get { return waist; }
            set
            {
                SetProperty(ref waist, value);
            }
        }
        private int heartrate;
        public int Heartrate
        {
            get { return heartrate; }
            set
            {
                SetProperty(ref heartrate, value);
            }
        }
        private int bloodPressureMax;
        public int BloodPressureMax
        {
            get { return bloodPressureMax; }
            set
            {
                SetProperty(ref bloodPressureMax, value);
            }
        }
        private int bloodPressureMin;
        public int BloodPressureMin
        {
            get { return bloodPressureMin; }
            set
            {
                SetProperty(ref bloodPressureMin, value);
            }
        }
        public MvxCommand PreviousDate { get; private set; }
        public MvxCommand NextDate { get; private set; }
        public MvxCommand FoodViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FoodViewModel>());
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
            DateTime = DateTime.Now;
            Date = SetDate(DateTime);
            PreviousDate = new MvxCommand(() =>
            {
                Date = SetDate(DateTime = DateTime.AddDays(-1.0));
                //get date's data
            });
            NextDate = new MvxCommand(() =>
            {
                Date = SetDate(DateTime = DateTime.AddDays(1.0));
                //get date's data
            });
            //dummy data
            SenseWeight = new MvxCommand(() =>
            {
                Weight = 52.0;
            });
            SenseHeight = new MvxCommand(() =>
            {
                Height = 167;
            });
            SenseWaist = new MvxCommand(() =>
            {
                Waist = 80.0;
            });
            SenseHeartrate = new MvxCommand(() =>
            {
                Heartrate = 60;
            });
            SenseBloodPressure = new MvxCommand(() =>
            {
                BloodPressureMax = 120;
                BloodPressureMin = 80;
            });
        }
        public string SetDate(DateTime dateTime)
        {
            return String.Format("{0}/{1}/{2}",
                dateTime.Day.ToString(),
                dateTime.Month.ToString(),
                dateTime.Year.ToString());
        }
    }
}
