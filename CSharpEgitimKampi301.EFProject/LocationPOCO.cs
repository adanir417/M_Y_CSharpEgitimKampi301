using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EFProject
{
    public class LocationPOCO
    {
        public int LocationId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public byte? Capacity { get; set; }
        public decimal? Price { get; set; }
        public string DayNight { get; set; }
        public int GuideId { get; set; }
        public string GuideNameAndSurname { get; set; }
    }
}
