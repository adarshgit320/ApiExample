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
    
    public partial class Specialization
    {
        public Specialization()
        {
            this.DoctorSpecializations = new HashSet<DoctorSpecialization>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsSingleBilling { get; set; }
    
        public virtual ICollection<DoctorSpecialization> DoctorSpecializations { get; set; }
    }
}
