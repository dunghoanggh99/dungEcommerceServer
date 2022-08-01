using dungAPI.DAL.Entities.Abstract;
using System.ComponentModel.DataAnnotations;

namespace dungAPI.DAL.Entities.Concrea
{
    public class Coupon : BaseEntity
    {
        [Required]
        public Guid Code { get; set; }
        public decimal Value { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiredDate { get; set; }

    }
}
