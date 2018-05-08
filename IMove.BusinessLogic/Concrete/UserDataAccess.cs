using IMove.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using IMove.BusinessLogic.DTO;
using IMove.DataAccess;

namespace IMove.BusinessLogic.Concrete
{
    public class UserDataAccess : IUserDataAcces
    {
        public IMoveDBContext _imovedb;

        public UserDataAccess(IMoveDBContext imovedb)
        {
            _imovedb = imovedb;
        }

        public void CreateUser(UserDTO user)
        {
            var User = new DataAccess.User
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,

            };
        }

        public void MakeBooking(BookingDetailsDTO bookingdeatails)
        {
            var driver = _imovedb.Driver.Find(bookingdeatails.FkDriverId);
            var user = _imovedb.User.Find(bookingdeatails.FkUserId);

            var bookingdetails = new DataAccess.BookingDetails
            {
                Destination = bookingdeatails.Destination,
                BookingDate = bookingdeatails.BookingDate,
                IsApproved = bookingdeatails.IsApproved,
                IsCompleted = bookingdeatails.IsCompleted,
                 FkDriverId = bookingdeatails.FkDriverId,
                 FkUserId = bookingdeatails.FkUserId,
                 FkDriver = driver,
                 FkUser = user,
                 Pickup = bookingdeatails.Pickup
            };
        }
    }
}
