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
    
    public partial class Yazilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Yazilar()
        {
            this.YaziSikayetler = new HashSet<YaziSikayetler>();
            this.YaziYorumlar = new HashSet<YaziYorumlar>();
        }
    
        public int yazi_id { get; set; }
        public string Baslik { get; set; }
        public string icerik { get; set; }
        public Nullable<int> yazar_id { get; set; }
        public Nullable<bool> onay { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YaziSikayetler> YaziSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YaziYorumlar> YaziYorumlar { get; set; }
    }
}
