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
   
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AdminGirisler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int giris_id { get; set; }
        public Nullable<System.DateTime> girisTarih { get; set; }
        public Nullable<int> girisKod { get; set; }
        public Nullable<bool> girisBasarisi1 { get; set; }
        public Nullable<bool> girisBasarisi2 { get; set; }
    }
}
