using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
            new Category{CategoryId=1,CategoryName="Kitchen Equipments"},
            new Category{CategoryId=2,CategoryName="General Useful Equipments"},
            new Category{CategoryId=3,CategoryName="Cleaning Equipments"}
            };
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }
        public void Delete(Category entity)
        {
            Category entityToDelete = null;

            entityToDelete = _categories.SingleOrDefault(i => i.CategoryId == entity.CategoryId);

            _categories.Remove(entityToDelete);
        }
        public void Update(Category entity)
        {
            Category entityToUpdate = null;

            entityToUpdate = _categories.SingleOrDefault(i => i.CategoryId == entity.CategoryId);
            entityToUpdate.CategoryName = entity.CategoryName;
           
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        
    }
}
