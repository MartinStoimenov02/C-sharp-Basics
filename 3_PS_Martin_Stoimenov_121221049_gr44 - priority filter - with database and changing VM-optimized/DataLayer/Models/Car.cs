using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Transmision { get; set; }
        public Double Price { get; set; }
        public string BodyType { get; set; }
        public string EuroCategory { get; set; }
    }
}
