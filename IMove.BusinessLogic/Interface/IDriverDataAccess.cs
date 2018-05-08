using IMove.BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMove.BusinessLogic.Interface
{
    public interface IDriverDataAccess
    {
        void createDriver(DriverDTO driver);
        void AddCar(CarInfoDTO carinfo);
    }
}
