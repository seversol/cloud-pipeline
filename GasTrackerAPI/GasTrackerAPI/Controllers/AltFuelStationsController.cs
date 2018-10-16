using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GasTrackerAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GasTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltFuelStationsController : ControllerBase
    {
        private nrelContext dbContext = new nrelContext();

        // GET: api/AltFuelStations/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        public ActionResult<IEnumerable<AltFuelStations>> Get([FromQuery] String address, [FromQuery] String fuelType)
        {

            if ((address != null && address != String.Empty) && (fuelType == null || fuelType == String.Empty)) {
                var stations = dbContext.AltFuelStations.Where(s => EF.Functions.Like(s.StreetAddress, "%" + address + "%") || EF.Functions.Like(s.Zip, "%" + address + "%") || EF.Functions.Like(s.City, "%" + address + "%")).ToArray();
                return Ok(stations);
            } else if ((address != null && address != String.Empty) && (fuelType != null && fuelType != String.Empty))
            {
                var stations = dbContext.AltFuelStations.Where(s => (EF.Functions.Like(s.StreetAddress, "%" + address + "%") || EF.Functions.Like(s.Zip, "%" + address + "%") || EF.Functions.Like(s.City, "%" + address + "%")) && s.FuelTypeCode == fuelType).ToArray();
                return Ok(stations);
            } else if ((address == null || address == String.Empty) && (fuelType != null && fuelType != String.Empty))
            {
                var stations = dbContext.AltFuelStations.Where(s => s.FuelTypeCode == fuelType).ToArray();
                return Ok(stations);
            } else
            {
                var stations = dbContext.AltFuelStations.Take(100).ToArray();
                return Ok(stations);
            }
        }

        /*        // POST: api/AltFuelStations
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT: api/AltFuelStations/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE: api/ApiWithActions/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }*/
    }
}
