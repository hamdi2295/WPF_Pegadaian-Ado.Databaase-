//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf_Pegadaian.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INSTALLMENT
    {
        public int ID { get; set; }
        public System.DateTime INSTALLMENT_DATE { get; set; }
        public Nullable<System.DateTime> DUE_DATE { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> INSTALLMENT_AMOUNT { get; set; }
        public int TRANSACTION_ID { get; set; }
    
        public virtual TRANSACTION TRANSACTION { get; set; }
    }
}