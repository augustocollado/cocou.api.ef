using System.Collections.Generic;
using System.Linq;
using api.ef.Models;

namespace api.ef.Context
{
    public class VehicleContext : SuperContext<Vehicle>
    {
        public VehicleContext(trackingContext context) : base(context)
        {
        }
        
        public override void Add(Vehicle newT)
        {
            dbContext.Add(newT);
        }

        public override IEnumerable<Vehicle> GetAll()
        {
            return dbContext.Vehicle.ToList();
        }

        public override Vehicle GetById(int id)
        {
            return dbContext.Vehicle.Where(v => v.Id == id).SingleOrDefault();
        }

        public override void Remove(Vehicle obj)
        {
            dbContext.Vehicle.Remove(obj);
        }

        public override void Update(Vehicle editedObj)
        {
            dbContext.Vehicle.Update(editedObj);
        }

        public IEnumerable<Vehicle> GetAllWithDrivers()
        {
            var query = from vehicle in dbContext.Vehicle
                join driver in dbContext.Driver
                on vehicle.Driver.Id equals driver.Id
            select new { vehicle, driver };

            var result = new List<Vehicle>();
            foreach(var q in query)
            {
                q.driver.Vehicle = null;
                q.vehicle.Driver = q.driver;
                result.Add(q.vehicle);
            }

            return result;
        }
    }
}