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
    
    public partial class exchang_permit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public exchang_permit()
        {
            this.exchane_permit_items = new HashSet<exchane_permit_items>();
        }
    
        public int exc_permit_id { get; set; }
        public Nullable<int> warehouse_out_id { get; set; }
        public Nullable<int> warehouse_in_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<exchane_permit_items> exchane_permit_items { get; set; }
        public virtual warehouse warehouse { get; set; }
        public virtual warehouse warehouse1 { get; set; }
    }
}
