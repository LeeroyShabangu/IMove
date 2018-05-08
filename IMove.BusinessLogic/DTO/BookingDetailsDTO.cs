using System;
using System.Collections.Generic;
using System.Text;

namespace IMove.BusinessLogic.DTO
{
    public class BookingDetailsDTO
    {
        public int BookingDetailsId { get; set; }
        public DateTime? BookingDate { get; set; }
        public string Destination { get; set; }
        public string Pickup { get; set; }
        public bool? IsApproved { get; set; }
        public int? FkDriverId { get; set; }
        public int? FkUserId { get; set; }
        public bool? IsCompleted { get; set; }
        public DriverDTO driver { get; set; }
        public UserDTO UserDTO { get; set; }
    }
}
