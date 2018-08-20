﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public AppUser Driver { get; set; }
        public int Year { get; set; }
        public int Registration { get; set; }
        public int Identification { get; set; }
        public VehicleType Type { get; set; }
    }
}