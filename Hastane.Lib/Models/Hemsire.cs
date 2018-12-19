using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
    public class Hemsire:Kisi,IMaasAlabilir
    {
        public decimal Maas { get; set; }
        public Servis Servis { get; set; }
        public bool AtandiMi { get; set; }

    }

    public enum Servis
    {
        KBB,
        GÖZ,
        DAHİLİYE,
        ORTOPEDİ
    }
}
