using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Exercise
    {
        public Exercise() { }
        public Exercise(string name, double time)
        {
            Name = name;
            Time = time;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Time { get; set; }

    }
}
