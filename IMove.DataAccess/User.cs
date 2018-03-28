using System;
using System.Collections.Generic;

namespace IMove.DataAccess
{
    public partial class User
    {
        public User()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
