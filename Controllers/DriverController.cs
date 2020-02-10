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
    public class DriverController : SuperController
    {
        public DriverController(trackingContext context) : base(context)
        {
        }

        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return dbContext.GetContext<DriverContext>().GetAll().OrderByDescending(d => d.Lastname).ToList();
        }
    }
}
