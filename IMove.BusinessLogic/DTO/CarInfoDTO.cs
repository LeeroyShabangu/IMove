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
        public int? VehicleCategoryID { get; set; }
        public int? DriverId { get; set; }
        public DriverDTO Driver { get; set; }
        public VehicleCategoryDTO VehicleCategory { get; set; }
    }
}
