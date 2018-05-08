using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class DriverDTO
    {
        public DriverDTO()
        {
            Availability = new HashSet<Availability>();
            BookingDetails = new HashSet<BookingDetails>();
            CarInfo = new HashSet<CarInfo>();
        }

        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<Availability> Availability { get; set; }
        public ICollection<BookingDetails> BookingDetails { get; set; }
        public ICollection<CarInfo> CarInfo { get; set; }
    }
}
