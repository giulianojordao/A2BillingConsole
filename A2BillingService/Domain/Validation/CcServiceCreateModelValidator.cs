using System;
using FluentValidation;
using A2BillingService.Domain.Models;

namespace A2BillingService.Domain.Validation
{
    public partial class CcServiceCreateModelValidator
        : AbstractValidator<CcServiceCreateModel>
    {
        public CcServiceCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
