using IMove.BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMove.BusinessLogic.Interface
{
    public interface ICarsDataAccess
    {
        List<CarInfoDTO> GetAllCars();

    }
}
