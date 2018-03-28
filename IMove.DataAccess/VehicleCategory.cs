using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class VehicleCategory
    {
        public VehicleCategory()
        {
            CarInfo = new HashSet<CarInfo>();
        }

        public int VehicleCategoryId { get; set; }
        public string VehicleCategoryName { get; set; }

        public ICollection<CarInfo> CarInfo { get; set; }
    }
}
