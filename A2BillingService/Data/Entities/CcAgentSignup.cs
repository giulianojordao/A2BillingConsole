using System;
using System.Collections.Generic;

namespace A2BillingService.Data.Entities
{
    public partial class CcAgentSignup
    {
        public CcAgentSignup()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long Id { get; set; }

        public int IdAgent { get; set; }

        public string Code { get; set; }

        public int IdTariffgroup { get; set; }

        public int IdGroup { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
