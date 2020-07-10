using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    interface ICalculate
    {
        BindableCollection<FelosztasModel> CalculateWithoutNonAfa(SzamlaModel szamla,decimal osszeg);
        BindableCollection<FelosztasModel> CalculateWithNonAfa(SzamlaModel szamla, decimal osszeg, decimal afaosszeg);
    }
}
