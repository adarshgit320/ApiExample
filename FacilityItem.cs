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
    
    public partial class FacilityItem
    {
        public FacilityItem()
        {
            this.C_FacilityInvoiceDetail = new HashSet<C_FacilityInvoiceDetail>();
        }
    
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> FileId { get; set; }
        public double Amount { get; set; }
        public Nullable<double> OfferAmount { get; set; }
        public int VisitsRequired { get; set; }
    
        public virtual ICollection<C_FacilityInvoiceDetail> C_FacilityInvoiceDetail { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
