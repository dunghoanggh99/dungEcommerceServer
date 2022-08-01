using AutoMapper;
using dungAPI.DAL.Context;
using dungEcommerce.BLL.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dungEcommerce.BLL.Repositories
{
    public class GenericRepository<TEntity, TModel> : IGenericRepository<TEntity, TModel> where TEntity : class, new() where TModel : class
    {
        protected readonly dungContext _context;
        protected readonly IMapper _mapper;
        public GenericRepository(dungContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Add(TModel model)
        {
            _context.Set<TEntity>().AddAsync(_mapper.Map<TEntity>(model));
        }
        public void Update(TModel model)
        {
            _context.Entry(_mapper.Map<TEntity>(model)).State = EntityState.Modified;
        }

        public void AddRange(IEnumerable<TModel> models)
        {
            _context.Set<TEntity>().AddRangeAsync(_mapper.Map<List<TEntity>>(models));
        }

        public IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expressionModel)
        {
            var expression = _mapper.Map<Expression<Func<TEntity, bool>>>(expressionModel);
            var entities = _context.Set<TEntity>().Where(expression);
            return _mapper.Map<IEnumerable<TModel>>(entities);
        }

        public IEnumerable<TModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TModel>>(_context.Set<TEntity>().ToList());
        }

        public TModel GetById(Guid Id)
        {
            return _mapper.Map<TModel>(_context.Set<TEntity>().FindAsync(Id));
        }

        public void Remove(TModel model)
        {
            _context.Set<TEntity>().Remove(_mapper.Map<TEntity>(model));
        }

        public void RemoveRange(IEnumerable<TModel> models)
        {
            _context.Set<TEntity>().RemoveRange(_mapper.Map<IEnumerable<TEntity>>(models));
        }
        public void Save()
        {
            _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.DisposeAsync();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}