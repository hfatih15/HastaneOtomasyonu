using Hastane.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Lib.Business
{
    public class DoktorBusiness : IAtama<Doktor, Hemsire>
    {
        public void AtamaYap(Doktor nereye, Hemsire neyi)
        {
            if (neyi.AtandiMi)
            {
                throw new Exception("Atama yapılmıs önceden");
            }
            if (nereye.Servis!=neyi.Servis)
            {
                throw new Exception("aynı servis olmalı");
            }
            neyi.AtandiMi = true;
            nereye.Hemsireler.Add(neyi);
        }

        public void Cikart(Doktor nereden, Hemsire neyi)
        {
            neyi.AtandiMi = false;
            nereden.Hemsireler.Remove(neyi);
        }
    }
}
