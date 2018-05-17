using IMove.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using IMove.BusinessLogic.DTO;
using IMove.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IMove.BusinessLogic.Concrete
{
    public class CarDataAccess : ICarsDataAccess
    {
        public IMoveDBContext _imovedb = new IMoveDBContext();

        public CarDataAccess()
        {
        }

        public List<CarInfoDTO> GetAllCars()
        {
            using (_imovedb)
            {
                return _imovedb.CarInfo.Select(_ => new CarInfoDTO
                {
                    CarInfoId = _.CarInfoId,
                    CarMake = _.CarMake,
                    CarModel = _.CarModel,
                    CarYear = _.CarYear,
                     DriverId =_.FkDriverId,
                     VehicleCategoryID = _.FkVehicleCategory,
                     Driver = new DTO.DriverDTO
                     {
                         DriverId = _.FkDriver.DriverId,
                         DriverName = _.FkDriver.DriverName,
                         Email = _.FkDriver.Email,
                         PhoneNumber = _.FkDriver.PhoneNumber
                     },
                     VehicleCategory = new VehicleCategoryDTO
                     {
                         VehicleCategoryId =_.FkVehicleCategoryNavigation.VehicleCategoryId,
                         VehicleCategoryName = _.FkVehicleCategoryNavigation.VehicleCategoryName
                     }
                     
                }).ToList();
            }
        }
    }
}
