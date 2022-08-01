using dungAPI.DAL.Entities.Abstract;
using dungAPI.DAL.Enums;

namespace dungAPI.DAL.Entities.Concrea
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public virtual List<Category> Categories { get; set; }
        private decimal _discountRate = 1.0m;
        public decimal DiscountRate
        {
            get { return _discountRate; }
            set { _discountRate = value; }
        }
        private Rate _rate = Rate.Excellent;
        public Rate Rate { get => _rate; set => _rate = value; }

    }
}
