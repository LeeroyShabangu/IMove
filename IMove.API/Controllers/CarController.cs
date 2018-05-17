using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IMove.BusinessLogic.Interface;
using IMove.BusinessLogic.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IMove.API.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        readonly private ICarsDataAccess _cardataccess;

        public CarController(ICarsDataAccess dataaccess)
        {
            _cardataccess = dataaccess;
        }

        // GET: api/values
        [HttpGet]
        public List<CarInfoDTO> GetAllCars()
        {
            return _cardataccess.GetAllCars();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
