using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMusteriDal : IMusteriDal
    {
        public void Add(Musteri entity)
        {
            using (EvOdevContext context=new EvOdevContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Musteri entity)
        {
            using (EvOdevContext context = new EvOdevContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Musteri Get(Expression<Func<Musteri, bool>> filter)
        {
            using (EvOdevContext context = new EvOdevContext())
            {
                return context.Set<Musteri>().SingleOrDefault(filter);
            }
        }


        public List<Musteri> GetAll(Expression<Func<Musteri, bool>> filter = null)
        {
            using (EvOdevContext context=new EvOdevContext())
            {
                return filter == null 
                    ? context.Set<Musteri>().ToList() 
                    : context.Set<Musteri>().Where(filter).ToList();
            }
        }


        public void Update(Musteri entity)
        {
            using (EvOdevContext context = new EvOdevContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

    }
}
