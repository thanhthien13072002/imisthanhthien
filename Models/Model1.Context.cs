﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThietKeWebsiteBan_DienThoai_NguyenThanhThien_2001206972.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SanphamEntities1 : DbContext
    {
        public SanphamEntities1()
            : base("name=SanphamEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieux { get; set; }
    }
}
