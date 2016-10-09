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
        [PrimaryKey, AutoIncrement]
        public string ResultId { get; set; }
        public DateTime DateTime { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public double Waist { get; set; }
        public int HeartRate { get; set; }
        public int BloodPressureMin { get; set; }
        public int BloodPressureMax { get; set; }
    }
}
