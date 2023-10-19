﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class CarInformation
    {
        public CarInformation()
        {
            RentingDetails = new HashSet<RentingDetail>();
        }

        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarDescription { get; set; }
        public int? NumberOfDoors { get; set; }
        public int? SeatingCapacity { get; set; }
        public string FuelType { get; set; }
        public int? Year { get; set; }
        public int ManufacturerId { get; set; }
        public int SupplierId { get; set; }
        public byte? CarStatus { get; set; }
        public decimal? CarRentingPricePerDay { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<RentingDetail> RentingDetails { get; set; }
    }
}
