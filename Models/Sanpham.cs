//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Sanpham
    {
        public int id_sanpham { get; set; }
        public string Name { get; set; }
        public Nullable<int> Gia { get; set; }
        public Nullable<int> Giakhuyenmai { get; set; }
        public string Motasanpham { get; set; }
        public string Tinhtrang { get; set; }
        public string Chitiet { get; set; }
        public string Khuyenmai { get; set; }
        public string ThuongHieuID { get; set; }
        public string Url_anh { get; set; }
    
        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}