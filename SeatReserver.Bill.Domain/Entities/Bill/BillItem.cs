using System.ComponentModel.DataAnnotations.Schema;

namespace SeatReserver.Bill.Domain.Entities.Bill
{
    public class BillItem: BaseEntity
    {
        #region Ctors

        #endregion

        #region Properties
        public Guid ReserveItemId { get; private set; }
        public ReserveType ReserveType { get; private set; }
        #endregion

        #region Relations
        #region ForeignKey

        #endregion

        #region ICollection

        #endregion
        #endregion
    }

    public enum ReserveType
    {
        MovieSeat
    }
}
