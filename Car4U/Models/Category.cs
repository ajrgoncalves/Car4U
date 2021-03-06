﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Category
    {
        public string ID { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
        public int Warranty { get; set; }

        public virtual ICollection<Reservation> reservation { get; set; }
    }
}