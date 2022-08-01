using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dungEcommerce.BLL.IRepository
{
    internal interface IGenericRepository<TEntity,TModel> : IDisposable where TEntity : class, new() where TModel : class
    {
        TModel GetById(Guid Id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expression);
        void Add(TModel model);
        void AddRange(IEnumerable<TModel> models);
        void Update(TModel model);
        void Remove(TModel model);
        void RemoveRange(IEnumerable<TModel> models);
        void Save();
    }
}