﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car4U.Models
{
    public class Promotion
    {
        public string id { get; set; }
        public string Description { get; set; }
        public int Percentage { get; set; }
        public DateTime Days { get; set; }
    }
}