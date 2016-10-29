using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.ViewModels
{
    public class MeasurementsViewModel : MvxViewModel
    {
        List<Measurements> measurements = new List<Measurements>();
        private readonly IMeasurementsDatabase measurementsDatabase;
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
        public MvxCommand SaveCommand { get; private set; }
        public MvxCommand FoodViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<FoodsViewModel>());
            }
        }
        public MvxCommand ExerciseViewCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<ExercisesViewModel>());
            }
        }
        public MeasurementsViewModel(IMeasurementsDatabase measurementsDatabase)
        {
            this.measurementsDatabase = measurementsDatabase;
            DateTime = DateTime.Now;
            Date = SetDate(DateTime);
            PreviousDate = new MvxCommand(() =>
            {
                DateTime = DateTime.AddDays(-1.0);
                Date = SetDate(DateTime);
                GetMeasurementsData();
            });
            NextDate = new MvxCommand(() =>
            {
                DateTime = DateTime.AddDays(1.0);
                Date = SetDate(DateTime);
                GetMeasurementsData();
            });
            SaveCommand = new MvxCommand(() =>
            {
                Measurements newMeasurements = new Measurements(DateTime, Weight, Height, Waist, heartrate, BloodPressureMax, BloodPressureMin);
                SaveMeasurements(newMeasurements);
            });
        }
        public void OnResume()
        {
            GetMeasurementsData();
        }
        public string SetDate(DateTime dateTime)
        {
            return String.Format("{0}/{1}/{2}",
                dateTime.Day.ToString(),
                dateTime.Month.ToString(),
                dateTime.Year.ToString());
        }
        public async void SaveMeasurements(Measurements measurements)
        {
            //if (!await measurementsDatabase.CheckIfExists(measurements))
            //{
                await measurementsDatabase.InsertMeasurements(measurements);
                Close(this);
            //}
            //else
            //{
            //    await measurementsDatabase.UpdateMeasurements(measurements);
            //    Close(this);
            //}
        }
        public async void GetMeasurementsData()
        {
            var measurements = await measurementsDatabase.GetMeasurements();
            foreach (var measurement in measurements)
            {
                if (measurement.DateTime.Date == DateTime.Date)
                {
                    Weight = measurement.Weight;
                    Height = measurement.Height;
                    Waist = measurement.Waist;
                    Heartrate = measurement.HeartRate;
                    BloodPressureMax = measurement.BloodPressureMax;
                    BloodPressureMin = measurement.BloodPressureMin;
                }
            }
        }
    }
}
