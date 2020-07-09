using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using System.Linq;
namespace FaboEditProgi.Models
{
    class Calculator : ICalculate
    {
        public BindableCollection<FelosztasModel> CalculateWithNonAfa(SzamlaModel szamla, decimal osszeg, decimal afaosszeg)
        {
            BindableCollection<FelosztasModel> felosztasok = new BindableCollection<FelosztasModel>();
            foreach (var felosztas in szamla.Felosztasok)
            {
               
                felosztas.TeljesOsszeg = osszeg-afaosszeg;
                felosztas.CalculateNettoOsszeg();
                felosztas.CalculateAfaOsszeg();
                felosztasok.Add(felosztas);
            }
            FelosztasModel aosszesen = new FelosztasModel("Áfás összesen:", CalculateFelosztasokNetto(felosztasok), CalculateFelosztasokAfa(felosztasok));
            felosztasok.Add(aosszesen);
            
            foreach (var felosztas in szamla.Felosztasok)
            {
                FelosztasModel felosztasCopy = new FelosztasModel(felosztas.Id,felosztas.Ukod,felosztas.Xkod,felosztas.Percentage,0);

                felosztasCopy.TeljesOsszeg = afaosszeg;
                felosztasCopy.CalculateNettoOsszeg();
                felosztasCopy.CalculateAfaOsszeg();
                felosztasok.Add(felosztasCopy);
            }
            FelosztasModel amosszesen = new FelosztasModel("Áfamentes összesen:", CalculateFelosztasokAfaMentesNetto(felosztasok,afaosszeg), 0);
            FelosztasModel osszesen = new FelosztasModel("Mindösszesen: ", CalculateFelosztasokNetto(felosztasok), CalculateFelosztasokAfa(felosztasok));
            felosztasok.Add(amosszesen);
            felosztasok.Add(osszesen);
            return felosztasok;


        }

        public BindableCollection<FelosztasModel> CalculateWithoutNonAfa(SzamlaModel szamla, decimal osszeg)
        {
            BindableCollection<FelosztasModel> felosztasok = new BindableCollection<FelosztasModel>();
            foreach (var felosztas in szamla.Felosztasok)
            {
                felosztas.TeljesOsszeg = osszeg;
                felosztas.CalculateNettoOsszeg();
                felosztas.CalculateAfaOsszeg();
                felosztasok.Add(felosztas);
            }
            FelosztasModel osszesen = new FelosztasModel("Mindösszesen: ", CalculateFelosztasokNetto(felosztasok), CalculateFelosztasokAfa(felosztasok));
            felosztasok.Add(osszesen);
            return felosztasok;

            
        }
        private decimal CalculateFelosztasokNetto(BindableCollection<FelosztasModel> felosztasok) {
            return felosztasok.Where(x=>x.Xkod.Megnevezes != "Mindösszesen"&& x.Xkod.Megnevezes != "Áfás összesen:" && x.Xkod.Megnevezes != "Áfamentes összesen:" ).Sum(x=>x.NettoOsszeg);
        }
        private decimal CalculateFelosztasokAfa(BindableCollection<FelosztasModel> felosztasok) {
            return felosztasok.Where(x => x.Xkod.Megnevezes != "Mindösszesen" && x.Xkod.Megnevezes != "Áfás összesen:" && x.Xkod.Megnevezes != "Áfamentes összesen:").Sum(x => x.AfaOsszeg);
        }
        private decimal CalculateFelosztasokAfaMentesNetto(BindableCollection<FelosztasModel> felosztasok, decimal osszeg)
        {
            return felosztasok.Where(x=>x.TeljesOsszeg == osszeg).Sum(x => x.NettoOsszeg);
        }
    }
}
