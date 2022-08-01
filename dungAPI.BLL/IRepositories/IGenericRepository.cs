using System.Linq.Expressions;

namespace dungEcommerce.BLL.IRepository
{
    public interface IGenericRepository<TEntity, TModel> : IDisposable where TEntity : class, new() where TModel : class
    {
        Task<TModel> GetById(Guid Id);
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