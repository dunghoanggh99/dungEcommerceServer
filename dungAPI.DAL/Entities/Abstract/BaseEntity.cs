using dungAPI.DAL.Enums;

namespace dungAPI.DAL.Entities.Abstract
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; }
        public DateTime? PassivedDate { get; set; }
        public DateTime? DateModified { get; set; }
        public string Description { get; set; }
    }
}
