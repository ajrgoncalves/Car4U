﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class ExtraModel
    {
        public string ID { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public virtual ExtraType IdExtraType { get; set; }
        public virtual ICollection<Extra> IdExtra { get; set; }
        
    }
}