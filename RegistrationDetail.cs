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
    
    public partial class RegistrationDetail
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public double RegistrationFee { get; set; }
        public double ServiceCharges { get; set; }
        public double Tax { get; set; }
        public Nullable<double> TaxPercent { get; set; }
        public double DiscountAmount { get; set; }
        public string DiscountType { get; set; }
        public int PaymentMethod { get; set; }
        public string PaymentTransactionId { get; set; }
    
        public virtual Registration Registration { get; set; }
    }
}
