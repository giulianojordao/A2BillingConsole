using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcCurrenciesUpdateModelValidator
        : AbstractValidator<CcCurrenciesUpdateModel>
    {
        public CcCurrenciesUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
