//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlnt.DB.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DoDoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoDoc()
        {
            this.ThuocBaoVeTV = new HashSet<ThuocBaoVeTV>();
        }
    
        public string MaDoc { get; set; }
        public string MucDoDoc { get; set; }
        public string LuuY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuocBaoVeTV> ThuocBaoVeTV { get; set; }
    }
}
