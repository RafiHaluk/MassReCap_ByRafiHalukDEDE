using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {
            new Product{CategoryId=1,ProductId=1,ProductName="Glass Of StarWars",UnitPrice=9,UnitsInStock=85},
            new Product{CategoryId=1,ProductId=2,ProductName="Plate Of Oliver",UnitPrice=11,UnitsInStock=74},
            new Product{CategoryId=1,ProductId=3,ProductName="Stainless Sweeden Knife",UnitPrice=89,UnitsInStock=1},
            new Product{CategoryId=2,ProductId=4,ProductName="Water Heater 0.5L",UnitPrice=17,UnitsInStock=61},
            new Product{CategoryId=3,ProductId=5,ProductName="MicroFiber Cloth",UnitPrice=4,UnitsInStock=584}
            };
        }
        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public void Delete(Product entity)
        {
            //LINQ = Language Integrated Query => Dile gomulu sorgulama.
           
            Product entityToDelete = null;

            //To use `SingleOrDefault` add usage of LINQ. `SingleOrDefault` syntax acts like a foreach loop to find the elemenet that we seacrh.
            
            entityToDelete = _products.SingleOrDefault(i=>i.ProductId == entity.ProductId);

            _products.Remove(entityToDelete);

        }

       
        public void Update(Product entity)
        {
            Product entityToUpdate = null;

            entityToUpdate = _products.SingleOrDefault(i => i.ProductId == entity.ProductId);
            entityToUpdate.ProductName = entity.ProductName;
            entityToUpdate.UnitPrice = entity.UnitPrice;
            entityToUpdate.UnitPrice = entity.UnitsInStock;

        }
        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }




    }
}
