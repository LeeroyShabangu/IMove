using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMove.DataAccess
{
    public partial class CarInfo
    {
        public int CarInfoId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int? CarYear { get; set; }
        [ForeignKey("VehicleCategory")]
        public int? FkVehicleCategory { get; set; }
        [ForeignKey("Driver")]
        public int? FkDriverId { get; set; }

        public DriverDTO FkDriver { get; set; }
        public VehicleCategory FkVehicleCategoryNavigation { get; set; }
    }
}
