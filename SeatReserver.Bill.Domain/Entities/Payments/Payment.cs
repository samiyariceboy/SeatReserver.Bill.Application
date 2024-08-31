using SeatReserver.Bill.Domain.ValueObjects;

namespace SeatReserver.Bill.Domain.Entities.Payments
{
    public class Payment : BaseEntity
    {
        #region Ctors

        #endregion

        #region Properties
        public PaymentProviderType PaymentProvider { get; set; }
        public Price PaymentPrice { get; set; }
        #endregion

        #region Methods

        #endregion

        #region Enums
        public enum PaymentProviderType
        {
            Mellat,
            Saman,
            Azki
        }
        #endregion
    }
}
