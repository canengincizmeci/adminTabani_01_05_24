//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adminTabani_01_05_24
{
    using System;
    using System.Collections.Generic;
    
    public partial class Haberler
    {
        public int HaberID { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public Nullable<int> paylasan { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
    }
}
