using Microsoft.Win32;
using SeatReserver.Bill.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace SeatReserver.Bill.Domain.ValueObjects
{
    public class Price : BaseValueObject, IValidatableObject
    {
        #region Propeties
        private readonly decimal _value;
        #endregion
        #region Ctors
        private Price()
        {
            
        }
        public Price(decimal value)
        {
            Value = value;
            Validate(new ValidationContext(this));
        }
        #endregion

        #region Method
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //TODO: Impliment validate Logic
            if (_value > 100000000)
            {
                yield return new ValidationResult("");
            }
        }
        #endregion

        #region Propeties
        public decimal Value { get; init; }
        #endregion

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _value;
        }

       
    }
}
