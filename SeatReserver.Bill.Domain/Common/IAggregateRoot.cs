using SeatReserver.Bill.Domain.Entities;
using SeatReserver.Bill.Domain.Events.DomainEvents;

namespace SeatReserver.Bill.Domain.Common
{
    public interface IAggregateRoot : IEntity
    {
        void ClearDomainEvents();
        IReadOnlyList<IDomainEvent> DomainEvents { get; }
    }
}