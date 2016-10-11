using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Consultant
    {
        public Consultant() { }
        public Consultant(string name, string profession, string contact, string institution)
        {
            Name = name;
            Profession = profession;
            Contact = contact;
            Institution = institution;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Contact { get; set; }
        public string Institution { get; set; }
    }
}
