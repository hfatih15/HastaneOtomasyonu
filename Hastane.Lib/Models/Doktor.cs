using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Models
{
   public class Doktor:Kisi,IMaasAlabilir
    {
        public decimal Maas { get; set; }
        public Servis Servis { get; set; }
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
    }
}
