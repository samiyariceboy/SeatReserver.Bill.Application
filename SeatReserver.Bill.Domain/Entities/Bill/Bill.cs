using SeatReserver.Bill.Domain.Entities.Payments;

namespace SeatReserver.Bill.Domain.Entities.Bill
{
    public class Bill
    {
        #region Ctors

        #endregion

        #region Properties
        public Guid BillId { get; set; }
        public Guid? UserId { get; set; }
        public string BillCode { get; set; }
        public long BillPrice { get; set; }
        #endregion

        #region Methods

        #endregion

        #region Relation
        #region ForeignKey

        #endregion

        #region ICollection
        private readonly List<Payment> _payments;
        public virtual IReadOnlyCollection<Payment> Payments => _payments;

        private readonly List<BillItem> _billItems;
        public virtual IReadOnlyCollection<BillItem> BillItems => _billItems;
        #endregion 
        #endregion

    }
}
