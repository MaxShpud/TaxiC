﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Ride
    {
        public Ride() { }

        public Ride(Location location, AppUser dispatcher, RideVehicleType vehicleType, AppUser driver)
        {
            location = location ?? new Location();
            dispatcher = dispatcher ?? new AppUser();
            driver = driver ?? new AppUser();
            OrderDateTime = DateTime.Now;
            OrderLocation = location;
            VehicleType = vehicleType;
            Dispatcher = dispatcher;
            Driver = driver;
            Status = RideStatus.Formed;
        }

        public int Id { get; set; }

        public DateTime? OrderDateTime { get; set; }

        public Location OrderLocation { get; set; }

        public RideVehicleType? VehicleType { get; set; }

        public Location Destination { get; set; }

        public AppUser Dispatcher { get; set; }

        public AppUser Driver { get; set; }

        public int? Price { get; set; }

        public Comment Comment { get; set; }

        public RideStatus? Status { get; set; }
    }
}