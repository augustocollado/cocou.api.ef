using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.ef.Context;
using api.ef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.ef.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : SuperController
    {
        public VehicleController(trackingContext context) : base(context)
        {
        }

        [HttpGet]
        public IEnumerable<Vehicle> Get()
        {
            return dbContext.GetContext<VehicleContext>().GetAll().ToList();
        }

        [HttpGet]
        [Route("driver")]
        public IEnumerable<Vehicle> GetWithDriver()
        {
            return dbContext.GetContext<VehicleContext>().GetAllWithDrivers().ToList();
        }

    }
}
