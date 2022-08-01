using dungAPI.DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace dungAPI.DAL.Entities.Concrea
{
    public class Order : BaseEntity
    {
        public List<OrderSale> OrderSales { get; set; }
        [ForeignKey("Coupon")]
        public Guid CouponId { get; set; }
        public virtual Coupon Coupon { get; set; }
    }
}
