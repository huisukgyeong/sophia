using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Measurements
    {
        public Measurements() { }
        public Measurements(DateTime dateTime, double weight, int height, double waist, int heartRate, int bloodPressureMax, int bloodPressureMin)
        {
            DateTime = dateTime;
            Weight = weight;
            Height = height;
            Waist = waist;
            HeartRate = heartRate;
            BloodPressureMax = bloodPressureMax;
            BloodPressureMin = bloodPressureMin;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public double Waist { get; set; }
        public int HeartRate { get; set; }
        public int BloodPressureMin { get; set; }
        public int BloodPressureMax { get; set; }
    }
}
