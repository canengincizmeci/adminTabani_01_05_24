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
    
    public partial class Resimler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resimler()
        {
            this.ResimSikayetler = new HashSet<ResimSikayetler>();
            this.ResimYorumlar = new HashSet<ResimYorumlar>();
        }
    
        public int resimID { get; set; }
        public string dosyaYolu { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public Nullable<int> paylasan { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public Nullable<bool> onay { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResimSikayetler> ResimSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResimYorumlar> ResimYorumlar { get; set; }
    }
}
