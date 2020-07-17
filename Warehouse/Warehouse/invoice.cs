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
    
    public partial class invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public invoice()
        {
            this.pickUpDelivery = new HashSet<pickUpDelivery>();
            this.summary = new HashSet<summary>();
            this.supply = new HashSet<supply>();
        }
    
        public int invoiceID { get; set; }
        public int providerID { get; set; }
        public string deliveryReportNo { get; set; }
        public System.DateTime deliveryDate { get; set; }
        public Nullable<int> numberOfItems { get; set; }
        public string company { get; set; }
        public string orderNumber { get; set; }
        public int itemNumber { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public string serialNo { get; set; }
    
        public virtual provider provider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pickUpDelivery> pickUpDelivery { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<summary> summary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supply> supply { get; set; }
    }
}
