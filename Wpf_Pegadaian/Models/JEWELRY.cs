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
    
    public partial class JEWELRY
    {
        public int ID { get; set; }
        public string PICTURE { get; set; }
        public int TRANSACTION_ID { get; set; }
        public int GOLD_ID { get; set; }
        public Nullable<decimal> WEIGHT { get; set; }
        public Nullable<int> UNIT { get; set; }
        public string NAME { get; set; }
    
        public virtual GOLD GOLD { get; set; }
        public virtual TRANSACTION TRANSACTION { get; set; }
    }
}
