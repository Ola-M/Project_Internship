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
    
    public partial class ProvenProduct
    {
        public int provenProductID { get; set; }
        public int deliveryNoteID { get; set; }
        public int usersID { get; set; }
        public Nullable<System.DateTime> checkDate { get; set; }
        public string cCompany { get; set; }
        public string cOrderNumber { get; set; }
        public Nullable<int> cItemNumber { get; set; }
        public string cProductCode { get; set; }
        public string cProductName { get; set; }
        public string cSerialNo { get; set; }
        public Nullable<bool> offTheList { get; set; }
    
        public virtual DeliveryNote DeliveryNote { get; set; }
        public virtual Users Users { get; set; }
    }
}
