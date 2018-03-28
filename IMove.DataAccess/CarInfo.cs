using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class CarInfo
    {
        public int CarInfoId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int? CarYear { get; set; }
        public int? FkVehicleCategory { get; set; }
        public int? FkDriverId { get; set; }

        public Driver FkDriver { get; set; }
        public VehicleCategory FkVehicleCategoryNavigation { get; set; }
    }
}
