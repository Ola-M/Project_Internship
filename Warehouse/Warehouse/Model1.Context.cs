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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class warehouseDatabaseEntities1 : DbContext
    {
        public warehouseDatabaseEntities1()
            : base("name=warehouseDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryNote> DeliveryNote { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<DeliveryView> DeliveryView { get; set; }
        public virtual DbSet<OwnedProductView> OwnedProductView { get; set; }
        public virtual DbSet<ProductView> ProductView { get; set; }
        public virtual DbSet<ProvenProduct> ProvenProduct { get; set; }
        public virtual DbSet<IncompatibleProductsView> IncompatibleProductsView { get; set; }
        public virtual DbSet<Summary> Summary { get; set; }
    }
}
