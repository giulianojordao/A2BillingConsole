using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcSpeeddialReadModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public long IdCcCard { get; set; }

        public string Phone { get; set; }

        public string Name { get; set; }

        public int? Speeddial { get; set; }

        public DateTime Creationdate { get; set; }

        #endregion

    }
}
