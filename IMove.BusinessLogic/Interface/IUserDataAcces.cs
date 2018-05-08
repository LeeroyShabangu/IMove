using IMove.BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMove.BusinessLogic.Interface
{
    public interface IUserDataAcces
    {
        void CreateUser(UserDTO user);
        void MakeBooking(BookingDetailsDTO bookingdeatails);
    }
}
