using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImmanuelNews.WebApi.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetList();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}