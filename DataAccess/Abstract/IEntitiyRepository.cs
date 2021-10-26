using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess
{

    /*Generic restriction(constraint) = As `T` is a generic type variable we cant let `T` to be an int type or any other useless types... So we need to 
    restrict variable `T` using this syntax. "where X:class" means T is a refrance type...
    Furthermore we are using `IEntity` to strenghten the restriction. Without additional `IEntity` restriction, refrance type `T` may be any type of class
    like `DivedeByZereException`. `IEntity` restiriction tells us the ref type `T` is allowed by us to be only `IEntities` classes.....*/
    /*Lastly in this sotuation, as well as `IEntity` which is we dont need because `IEntity`is an abstract object we cant use it, 
     * so we need add one more thing which is `new()`... As `IEntity` is an interface, it cant be take operator `new()`...*/
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);





    }
}
