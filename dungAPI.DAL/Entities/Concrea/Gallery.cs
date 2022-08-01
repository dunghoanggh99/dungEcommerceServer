using dungAPI.DAL.Entities.Abstract;

namespace dungAPI.DAL.Entities.Concrea
{
    public class Gallery : BaseEntity
    {
        public string Path { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
