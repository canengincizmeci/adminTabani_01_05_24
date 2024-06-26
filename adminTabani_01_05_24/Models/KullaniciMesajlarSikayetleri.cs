﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace adminTabani_01_05_24.Models
{
    public class KullaniciMesajlarSikayetleri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int _sikayetID { get; set; }
        public string _sebep { get; set; }
        public DateTime? _tarih { get; set; }
        public int? _mesajID { get; set; }
        public int? _sikayetciID { get; set; }
        public string mesaj { get; set; }
        public string sikayetci { get; set; }
    }
}