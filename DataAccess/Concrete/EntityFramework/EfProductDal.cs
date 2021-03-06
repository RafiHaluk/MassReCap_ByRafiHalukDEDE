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
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            /* using = IDisposable Pattern Implemantation of C# */
            /*`using` is a very exclusive syntax of C#, because `using` calls the GarbageCollector automatically
            after the endings of `using` block. So our cache=(memory)(bellek) not struglle with the garbage data */
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                if (filter == null)
                {
                    return context.Set<Product>().ToList();
                }
                else
                {
                   return context.Set<Product>().Where(filter).ToList();
                }
                /* Another syntax Type of upper `If` block*
                   return filter == null 
                                     ? context.Set<Product>().ToList();
                                     : context.Set<Product>().Where(filter).ToList(); 
                                      
                                     `?` means check if and  `:` means check if not */
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
