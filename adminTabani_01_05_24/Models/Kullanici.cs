﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace adminTabani_01_05_24.Models
{
    public class Kullanici
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int kullanici_id { get; set; }
        public string Ad { get; set; }
        public string KullaniciMaili { get; set; }
        public string kullanici_sifresi { get; set; }
        
    }
}