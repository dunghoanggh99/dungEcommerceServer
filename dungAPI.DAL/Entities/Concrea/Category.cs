using dungAPI.DAL.Entities.Abstract;

namespace dungAPI.DAL.Entities.Concrea
{
    public class Category : BaseEntity
    {
        public List<Product> Products { get; set; }
    }
}
