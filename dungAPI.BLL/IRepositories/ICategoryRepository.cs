using dungAPI.DAL.Entities.Concrea;
using dungEcommerce.BLL.IRepository;
using dungEcommerce.BLL.Models;

namespace dungEcommerce.BLL.IRepositories
{
    public interface ICategoryRepository : IGenericRepository<Category, CategoryModel>
    {
    }
}
