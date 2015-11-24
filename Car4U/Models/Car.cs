using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Car
    {
        public string3 ID { get; set; }
        public string LicensePlate { get; set; }
        public string RegisterDate { get; set; }
        public int NDoors { get; set; }
        public int NLuggage { get; set; }
        public string Engine { get; set; }
        public string HorsePower { get; set; }
        public string IdCategory { get; set; }
        public string IdFuel { get; set; }
        public string IdBrand { get; set; }
        public string IdModel { get; set; }
    }
}