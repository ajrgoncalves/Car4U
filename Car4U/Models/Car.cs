using Car4U.CarModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Car
    {
        public string ID { get; set; }
        public string LicensePlate { get; set; }
        public string RegisterDate { get; set; }
        public int NDoors { get; set; }
        public int NLuggage { get; set; }
        public string Engine { get; set; }
        public string HorsePower { get; set; }

        public virtual Unavailability unavailability { get; set; }

        public virtual Fuel fuel { get; set; }

        public virtual Brand brand { get; set; }

        public virtual CarModel carModel { set; get; }
    }
}