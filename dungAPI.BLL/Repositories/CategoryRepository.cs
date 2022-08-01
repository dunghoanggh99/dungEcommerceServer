using AutoMapper;
using dungAPI.DAL.Context;
using dungAPI.DAL.Entities.Concrea;
using dungEcommerce.BLL.IRepositories;
using dungEcommerce.BLL.Models;

namespace dungEcommerce.BLL.Repositories
{
    public class CategoryRepository : GenericRepository<Category, CategoryModel>, ICategoryRepository
    {
        public CategoryRepository(dungContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
