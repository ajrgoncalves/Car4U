using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Reservation
    {
        public string ID { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double FinalPrice { get; set; }
        public virtual MeetingPoint IdMPDelivery { get; set; }
        public virtual MeetingPoint IdMPReturn { get; set; }
        public virtual ICollection<Extra> IdExtras { get; set; }
        public virtual ICollection<Moment> IdMoments { get; set; }
        public virtual Category IdCategory { get; set; }
        public virtual ApplicationUser user { get; set; }
    }
}