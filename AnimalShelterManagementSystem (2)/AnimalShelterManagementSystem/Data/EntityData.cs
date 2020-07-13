using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class EntityData<T> where T : class
    {
        protected AnimalShelterManagementEntities CreateContext()
        {
            AnimalShelterManagementEntities context = new AnimalShelterManagementEntities();
            context.Configuration.ProxyCreationEnabled = false;
            context.Database.Log = x => Console.WriteLine(x);

            return context;
        }


        public List<T> GetAll()
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Set<T>().ToList();
        }

        public int GetCount()
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Set<T>().Count();
        }

        public void Insert(T entity)
        {
            AnimalShelterManagementEntities context = CreateContext();

            //context.Albums.Add(album);
            context.Entry(entity).State = EntityState.Added;

            context.SaveChanges();
        }

        public void Update(T entity)
        {
            AnimalShelterManagementEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            AnimalShelterManagementEntities context = CreateContext();

            context.Entry(entity).State = EntityState.Deleted;

            context.SaveChanges();
        }
    }
}
