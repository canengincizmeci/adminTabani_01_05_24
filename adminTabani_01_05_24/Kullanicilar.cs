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
    
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            this.AdminMesajlar = new HashSet<AdminMesajlar>();
            this.Haberler = new HashSet<Haberler>();
            this.HaberSikayetler = new HashSet<HaberSikayetler>();
            this.HaberYorumlar = new HashSet<HaberYorumlar>();
            this.KullaniciGirisler = new HashSet<KullaniciGirisler>();
            this.KullaniciMesajlar = new HashSet<KullaniciMesajlar>();
            this.KullaniciMesajlar1 = new HashSet<KullaniciMesajlar>();
            this.ResimSikayetler = new HashSet<ResimSikayetler>();
            this.SiirSikayetler = new HashSet<SiirSikayetler>();
            this.YaziSikayetler = new HashSet<YaziSikayetler>();
            this.Resimler = new HashSet<Resimler>();
            this.ResimYorumlar = new HashSet<ResimYorumlar>();
            this.Siirler = new HashSet<Siirler>();
            this.SiirYorumlar = new HashSet<SiirYorumlar>();
            this.Tartismalar = new HashSet<Tartismalar>();
            this.TartismaSikayetler = new HashSet<TartismaSikayetler>();
            this.TartismaYorumlar = new HashSet<TartismaYorumlar>();
            this.Yazilar = new HashSet<Yazilar>();
            this.YaziYorumlar = new HashSet<YaziYorumlar>();
            this.KullaniciMesajlarSikayet = new HashSet<KullaniciMesajlarSikayet>();
        }
    
        public int kullanici_id { get; set; }
        public string Ad { get; set; }
        public string kullaniciMail { get; set; }
        public string kullanici_sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdminMesajlar> AdminMesajlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Haberler> Haberler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HaberSikayetler> HaberSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HaberYorumlar> HaberYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciGirisler> KullaniciGirisler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciMesajlar> KullaniciMesajlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciMesajlar> KullaniciMesajlar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResimSikayetler> ResimSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiirSikayetler> SiirSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YaziSikayetler> YaziSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resimler> Resimler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResimYorumlar> ResimYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siirler> Siirler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiirYorumlar> SiirYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tartismalar> Tartismalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TartismaSikayetler> TartismaSikayetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TartismaYorumlar> TartismaYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yazilar> Yazilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YaziYorumlar> YaziYorumlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciMesajlarSikayet> KullaniciMesajlarSikayet { get; set; }
    }
}
