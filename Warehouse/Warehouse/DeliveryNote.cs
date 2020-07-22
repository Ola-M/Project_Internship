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
    
    public partial class DeliveryNote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryNote()
        {
            this.ProvenProduct = new HashSet<ProvenProduct>();
            this.Summary = new HashSet<Summary>();
            this.Product = new HashSet<Product>();
            this.Delivery = new HashSet<Delivery>();
        }
    
        public int deliveryNoteID { get; set; }
        public int providerID { get; set; }
        public string deliveryNumber { get; set; }
        public System.DateTime invoiceDate { get; set; }
        public int numberOfItems { get; set; }
    
        public virtual Provider Provider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvenProduct> ProvenProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Summary> Summary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
    }
}