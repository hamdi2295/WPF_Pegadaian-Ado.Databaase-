﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PegadaianEntities1 : DbContext
    {
        public PegadaianEntities1()
            : base("name=PegadaianEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DETAIL_BUSINESS> DETAIL_BUSINESS { get; set; }
        public virtual DbSet<DETAIL_TYPE_VEHICLE> DETAIL_TYPE_VEHICLE { get; set; }
        public virtual DbSet<ELECTRONIC> ELECTRONICs { get; set; }
        public virtual DbSet<GOLD> GOLDs { get; set; }
        public virtual DbSet<GOLD_SAVING> GOLD_SAVING { get; set; }
        public virtual DbSet<HANDPHONE> HANDPHONEs { get; set; }
        public virtual DbSet<INSTALLMENT> INSTALLMENTs { get; set; }
        public virtual DbSet<INSTALLMENT_TYPE> INSTALLMENT_TYPE { get; set; }
        public virtual DbSet<JEWELRY> JEWELRies { get; set; }
        public virtual DbSet<OUTLET> OUTLETs { get; set; }
        public virtual DbSet<PRECIOUS_METAL> PRECIOUS_METAL { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TRANSACTION> TRANSACTIONs { get; set; }
        public virtual DbSet<TYPE_BUSINESS_FINANCING> TYPE_BUSINESS_FINANCING { get; set; }
        public virtual DbSet<TYPE_LAPTOP> TYPE_LAPTOP { get; set; }
        public virtual DbSet<TYPE_VEHICLE> TYPE_VEHICLE { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
    }
}