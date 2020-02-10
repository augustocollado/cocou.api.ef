using api.ef.Context;
using api.ef.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.ef.Controllers
{
    public abstract class SuperController : Controller
    {
        protected readonly trackingContext dbContext;
     
        public SuperController(trackingContext context)
        {
            dbContext = context;
        }
    }
}