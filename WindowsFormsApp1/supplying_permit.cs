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
    using System.Collections.Generic;
    
    public partial class supplying_permit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplying_permit()
        {
            this.supplying_permit_items = new HashSet<supplying_permit_items>();
        }
    
        public int supp_permit_id { get; set; }
        public Nullable<int> warehouse_id { get; set; }
        public string supplier_name { get; set; }
    
        public virtual supplier supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supplying_permit_items> supplying_permit_items { get; set; }
        public virtual warehouse warehouse { get; set; }
    }
}
