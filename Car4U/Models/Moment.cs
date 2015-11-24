using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Moment
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }
        public string IdReservation { get; set; }
        public string IdMomentType { get; set; }
    }
}