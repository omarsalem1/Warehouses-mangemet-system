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
    
    public partial class exchane_permit_items
    {
        public int exc_permit_id { get; set; }
        public string item_name { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<System.DateTime> prod_date { get; set; }
        public Nullable<System.DateTime> exp_date { get; set; }
        public string supplier_name { get; set; }
    
        public virtual exchang_permit exchang_permit { get; set; }
        public virtual Item Item { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
