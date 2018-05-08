using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class Availability
    {
        public int AvailabityId { get; set; }
        public string LocationAvalailable { get; set; }
        public TimeSpan? StartTimeAvailable { get; set; }
        public TimeSpan? EndTimeAvailable { get; set; }
        public string DayofWeekAvailable { get; set; }
        public int? FkDriverId { get; set; }

        public DriverDTO FkDriver { get; set; }
    }
}
