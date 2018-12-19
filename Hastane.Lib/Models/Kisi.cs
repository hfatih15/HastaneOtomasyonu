﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
   public abstract class Kisi
    {
        public Guid Id { get; set; } =new Guid();
        public string Ad { get; set; }
        public string  Soyad { get; set; }
        public string  TCKN { get; set; }
        public string Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }

        public override string ToString() => $"{this.Ad}{this.Soyad}";
    }
}
