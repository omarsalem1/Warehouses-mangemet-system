//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class entities : DbContext
    {
        public entities()
            : base("name=entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<exchane_permit_items> exchane_permit_items { get; set; }
        public virtual DbSet<exchang_permit> exchang_permit { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<item_units> item_units { get; set; }
        public virtual DbSet<selling_permit> selling_permit { get; set; }
        public virtual DbSet<selling_permit_items> selling_permit_items { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<supplying_permit> supplying_permit { get; set; }
        public virtual DbSet<supplying_permit_items> supplying_permit_items { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
    }
}
