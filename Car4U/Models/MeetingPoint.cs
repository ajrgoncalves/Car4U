using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class MeetingPoint
    {
        public string ID { get; set; }
        public string Place { get; set; }
        public virtual ICollection<Reservation> IdReservations { get; set; }
    }
}