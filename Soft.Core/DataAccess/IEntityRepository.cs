using Soft.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


// Temel CRUD işlemleri yapısını oluşturuyoruz.
// Hepsi T türünde değer döndüğü için kod tekrarına düşmeden çok kolay bir şekilde işlemleri yapabileceğiz.

namespace Soft.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Default null olarak belirtilir, eğer null ise bütün data yı getirir. Değilse filtre yaparak getirir.
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);

        //Tek bie nesneyi getirmek için kullanılır.
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
