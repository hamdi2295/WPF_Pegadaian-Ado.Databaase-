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
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.TRANSACTIONs = new HashSet<TRANSACTION>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string IDENTITY_TYPE { get; set; }
        public string IDENTITY_NUMBER { get; set; }
        public string GENDER { get; set; }
        public string BORN_PLACE { get; set; }
        public System.DateTime BORN_DATE { get; set; }
        public string PROVINCE { get; set; }
        public string REGENCY { get; set; }
        public string SUB_DISTRICT { get; set; }
        public string ADDRESS { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string BANK_ACCOUNT { get; set; }
        public int ROLE_ID { get; set; }
        public string NUMBER_NPWP { get; set; }
        public string PICTURE_NPWP { get; set; }
        public string PICTURE_IDENTITY { get; set; }
    
        public virtual ROLE ROLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACTION> TRANSACTIONs { get; set; }
    }
}
