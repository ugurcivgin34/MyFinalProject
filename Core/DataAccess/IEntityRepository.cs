using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //core katmanı diğer katmanları refereans almaz.Kimseye bağlı olmaz yani

    //generic constraint
    //class :referenas tip 
    //IEntity :IEntity olabilir yada IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtre vermeme anlamı katıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
