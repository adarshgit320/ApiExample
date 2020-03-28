//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiExample
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_FacilityInvoice
    {
        public C_FacilityInvoice()
        {
            this.C_FacilityInvoiceDetail = new HashSet<C_FacilityInvoiceDetail>();
        }
    
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public int PatientId { get; set; }
        public int BranchId { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public int PaymentMethod { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string CancelReason { get; set; }
        public Nullable<int> CanceledBy { get; set; }
        public Nullable<System.DateTime> CancelDate { get; set; }
    
        public virtual ICollection<C_FacilityInvoiceDetail> C_FacilityInvoiceDetail { get; set; }
    }
}
