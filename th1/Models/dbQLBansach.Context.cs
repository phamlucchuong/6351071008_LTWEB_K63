﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace th1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBanSachEntities1 : DbContext
    {
        public QLBanSachEntities1()
            : base("name=QLBanSachEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETDONTHANG> CHITIETDONTHANGs { get; set; }
        public DbSet<CHUDE> CHUDEs { get; set; }
        public DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public DbSet<SACH> SACHes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TACGIA> TACGIAs { get; set; }
        public DbSet<VIETSACH> VIETSACHes { get; set; }
    }
}
