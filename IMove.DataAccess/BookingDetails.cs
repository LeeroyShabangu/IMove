using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class BookingDetails
    {
        public int BookingDetailsId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string Destination { get; set; }
        public string Pickup { get; set; }
        public bool? IsApproved { get; set; }
        public int? FkDriverId { get; set; }
        public int? FkUserId { get; set; }
        public bool? IsCompleted { get; set; }

        public Driver FkDriver { get; set; }
        public User FkUser { get; set; }
    }
}
