using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcServiceReportCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long CcServiceId { get; set; }

        public DateTime Daterun { get; set; }

        public int? Totalcardperform { get; set; }

        public float? Totalcredit { get; set; }

        #endregion

    }
}
