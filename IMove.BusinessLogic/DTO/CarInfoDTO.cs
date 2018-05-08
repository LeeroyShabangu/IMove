using IMove.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMove.BusinessLogic.DTO
{
    public class CarInfoDTO
    {
        public int CarInfoId { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int? CarYear { get; set; }
        public int? FkVehicleCategory { get; set; }
        public int? FkDriverId { get; set; }
        public DriverDTO FkDriver { get; set; }
        public VehicleCategoryDTO FkVehicleCategoryNavigation { get; set; }
    }
}
