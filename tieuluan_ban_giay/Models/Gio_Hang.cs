//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Gio_Hang
    {
        public int Ma_Gio_Hang { get; set; }
        public int Ma_Khach_Hang { get; set; }
        public string TenSanPham { get; set; }
        public string SoLuongSanPham { get; set; }
    
        public virtual Khach_Hang Khach_Hang { get; set; }
    }
}
