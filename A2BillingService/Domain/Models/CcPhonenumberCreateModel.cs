using System;
using System.Collections.Generic;

namespace A2BillingService.Domain.Models
{
    public partial class CcPhonenumberCreateModel
    {
        #region Generated Properties
        public long Id { get; set; }

        public int IdPhonebook { get; set; }

        public string Number { get; set; }

        public string Name { get; set; }

        public DateTime Creationdate { get; set; }

        public short Status { get; set; }

        public string Info { get; set; }

        public int Amount { get; set; }

        #endregion

    }
}
