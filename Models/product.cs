//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web12.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.newarrivals = new HashSet<newarrival>();
            this.orderdetails = new HashSet<orderdetail>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<double> price { get; set; }
        public string img { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
        public string img3 { get; set; }
        public string description { get; set; }
        public string meta { get; set; }
        public Nullable<bool> hdie { get; set; }
        public Nullable<int> order { get; set; }
        public Nullable<System.DateTime> datebegin { get; set; }
        public Nullable<int> categoryid { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<newarrival> newarrivals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderdetail> orderdetails { get; set; }
    }
}
