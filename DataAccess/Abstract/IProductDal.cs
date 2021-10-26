using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //This interface contains the operations(create,run,update,delete(CRUD),list,filter,show,calculate...) that we will operate(run) on the DataBase...
    public interface IProductDal : IEntitiyRepository<Product>
    { 


    }
}
