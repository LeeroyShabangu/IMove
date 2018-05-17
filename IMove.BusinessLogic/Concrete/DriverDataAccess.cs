using System;
using System.Collections.Generic;
using System.Text;
using IMove.BusinessLogic.DTO;
using IMove.DataAccess;

namespace IMove.BusinessLogic.Interface
{
    public class DriverDataAccess : IDriverDataAccess
    {
        public IMoveDBContext _imovedb;

        public DriverDataAccess(IMoveDBContext imovedb)
        {
            _imovedb = imovedb;
        }

        public void AddCar(CarInfoDTO carinfo)
        {
            var driver = _imovedb.Driver.Find(carinfo.DriverId);
            var vehiclecat = _imovedb.VehicleCategory.Find(carinfo.VehicleCategoryID);

            var car = new DataAccess.CarInfo
            {
                CarMake = carinfo.CarMake,
                CarModel = carinfo.CarModel,
                CarYear = carinfo.CarYear,
                FkDriver = driver,
                FkVehicleCategoryNavigation = vehiclecat

            };
        }

        public void createDriver(DTO.DriverDTO driver)
        {
            var Driver = new DataAccess.DriverDTO
            {
                DriverId = driver.DriverId,
                Email = driver.Email,
                DriverName  = driver.DriverName,
                PhoneNumber = driver.PhoneNumber
            };

            using (_imovedb)
            {
                _imovedb.Driver.Add(Driver);
                _imovedb.SaveChanges();
            }
        }
    }
}
