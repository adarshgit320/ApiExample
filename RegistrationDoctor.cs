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
    
    public partial class RegistrationDoctor
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int RegistrationId { get; set; }
        public System.DateTime AppointmentDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsPrimary { get; set; }
        public Nullable<int> Specialization { get; set; }
    
        public virtual Doctor Doctor { get; set; }
    }
}
