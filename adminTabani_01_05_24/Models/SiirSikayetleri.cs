﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace adminTabani_01_05_24.Models
{
    public class SiirSikayetleri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sikayetID { get; set; }
        public string _sebep { get; set; }
        public DateTime? _tarih { get; set; }
        public int? _sikayetci_id { get; set; }
        public int? _siir_id { get; set; }
        public string SiirBaslik { get; set; }
        public string sikayetciAD { get; set; }
        public string siir { get; set; }
    }
}