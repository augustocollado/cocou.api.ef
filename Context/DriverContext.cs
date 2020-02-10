using System.Collections.Generic;
using System.Linq;
using api.ef.Models;

namespace api.ef.Context
{
    public class DriverContext : SuperContext<Driver>
    {
        public DriverContext(trackingContext context) : base(context)
        {
        }

        public override void Add(Driver newT)
        {
            dbContext.Driver.Add(newT);
        }

        public override IEnumerable<Driver> GetAll()
        {
            return dbContext.Driver.ToList();
        }

        public override Driver GetById(int id)
        {
            return dbContext.Driver.SingleOrDefault(d => d.Id == id);
        }

        public override void Remove(Driver obj)
        {
            dbContext.Driver.Remove(obj);
        }

        public override void Update(Driver editedObj)
        {
            dbContext.Driver.Update(editedObj);
        }
    }

}