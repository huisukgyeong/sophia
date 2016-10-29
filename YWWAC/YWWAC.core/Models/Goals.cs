using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Goals
    {
        public Goals() { }
        public Goals(double current_weight, double current_height, double goal_weight)
        {
            CurrentWeight = current_weight;
            CurrentHeight = current_height;
            GoalWeight = goal_weight;
        }
        public int Id { get; set; }
        public double CurrentWeight { get; set; }
        public double CurrentHeight { get; set; }
        public double GoalWeight { get; set; }
    }
}
