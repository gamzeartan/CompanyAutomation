﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmaOtomasyon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBFIRMAEntities : DbContext
    {
        public DBFIRMAEntities()
            : base("name=DBFIRMAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLADMIN> TBLADMIN { get; set; }
        public virtual DbSet<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        public virtual DbSet<TBLFATURADETAY> TBLFATURADETAY { get; set; }
        public virtual DbSet<TBLFIRMA> TBLFIRMA { get; set; }
        public virtual DbSet<TBLGOREV> TBLGOREV { get; set; }
        public virtual DbSet<TBLISLEMDETAY> TBLISLEMDETAY { get; set; }
        public virtual DbSet<TBLKATEGORI> TBLKATEGORI { get; set; }
        public virtual DbSet<TBLNOT> TBLNOT { get; set; }
        public virtual DbSet<TBLPERSONEL> TBLPERSONEL { get; set; }
        public virtual DbSet<TBLTAKIP> TBLTAKIP { get; set; }
        public virtual DbSet<TBLURUN> TBLURUN { get; set; }
        public virtual DbSet<TBLURUNISLEM> TBLURUNISLEM { get; set; }
        public virtual DbSet<TBLURUNSATIS> TBLURUNSATIS { get; set; }
    }
}
