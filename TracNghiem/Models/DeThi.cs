//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TracNghiem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeThi
    {
        public DeThi()
        {
            this.BaiThis = new HashSet<BaiThi>();
        }
    
        public int IdDeThi { get; set; }
        public Nullable<int> MaCauHoi { get; set; }
        public Nullable<int> ThoiGian { get; set; }
        public Nullable<int> DiemTungCau { get; set; }
        public Nullable<int> MaNganHangCauHoi { get; set; }
    
        public virtual ICollection<BaiThi> BaiThis { get; set; }
        public virtual NganHangCauHoi NganHangCauHoi { get; set; }
    }
}
