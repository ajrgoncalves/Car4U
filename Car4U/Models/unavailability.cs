using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Unavailability
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime FinishDate { get; set; }

        public virtual ICollection<Car> Car { get; set; }
        
    }
}