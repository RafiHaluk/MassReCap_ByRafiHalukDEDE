using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    /*Context classes are using to connect project classes with DB tables...*/
    public class NorthwindContext : DbContext
    {
        /*This method is defines that in which DB we are going to work `override + onconfiguring`*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Defining the local DB or IP adress
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }
        //          OurClass    DbTable
        //             |           |
        //             |           |
        public DbSet<Product>  Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
