﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tieuluan_ban_giay.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLBangiayyEntities : DbContext
    {
        public QLBangiayyEntities()
            : base("name=QLBangiayyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CT_DatHang> CT_DatHang { get; set; }
        public virtual DbSet<Danh_Gia> Danh_Gia { get; set; }
        public virtual DbSet<Don_Dat_Hang> Don_Dat_Hang { get; set; }
        public virtual DbSet<Giay> Giays { get; set; }
        public virtual DbSet<Gio_Hang> Gio_Hang { get; set; }
        public virtual DbSet<Khach_Hang> Khach_Hang { get; set; }
        public virtual DbSet<Khuyen_Mai> Khuyen_Mai { get; set; }
        public virtual DbSet<Quan_Tri> Quan_Tri { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<The_Loai> The_Loai { get; set; }
    }
}
