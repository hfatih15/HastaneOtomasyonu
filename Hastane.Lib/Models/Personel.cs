using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
   public class Personel:Kisi,IMaasAlabilir
    {
        public PersonelBrans Brans  { get; set; }
        public decimal Maas { get; set; }
    }
    public enum PersonelBrans
    {
        TEMİZLİK,
        MUHASEBE,
        İDARİİSLER
    }
}
