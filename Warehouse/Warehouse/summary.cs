//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class summary
    {
        public int summaryID { get; set; }
        public int invoiceID { get; set; }
        public int checkedInvoiceID { get; set; }
        public bool deliveryCompatible { get; set; }
    
        public virtual checkedInvoice checkedInvoice { get; set; }
        public virtual invoice invoice { get; set; }
    }
}
