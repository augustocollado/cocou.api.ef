using System.Collections.Generic;
using api.ef.Models;

namespace api.ef.Context
{
    public abstract class SuperContext<T>
    {
        protected trackingContext dbContext;

        public SuperContext(trackingContext context)
        {
            dbContext = context;
        }

        public abstract IEnumerable<T> GetAll();
        public abstract T GetById(int id);
        public abstract void Add(T newT);
        public abstract void Update(T editedObj);
        public abstract void Remove(T obj);

    }
}