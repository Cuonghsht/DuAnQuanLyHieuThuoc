//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DUAN1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int IdVoucher { get; set; }
        public string NameVoucher { get; set; }
        public System.DateTime NSX { get; set; }
        public System.DateTime HSD { get; set; }
        public decimal VoucherValue { get; set; }
        public int Quantity { get; set; }
        public int idtt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual TrangThaiVoucher TrangThaiVoucher { get; set; }
    }
}
