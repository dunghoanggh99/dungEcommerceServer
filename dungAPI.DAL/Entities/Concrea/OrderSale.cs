using dungAPI.DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace dungAPI.DAL.Entities.Concrea
{
    public class OrderSale : BaseEntity
    {
        public Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
