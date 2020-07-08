using Caliburn.Micro;
using FaboEditProgi.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace FaboEditProgi.ViewModels
{
    class FelosztasViewModel:Screen
    {
        public FelosztasViewModel()
        {
            SzamlaTipusok = new BindableCollection<SzamlaModel>() {
            new SzamlaModel(){Id=1, Megnevezes = "Áram"},
            new SzamlaModel(){Id=2 ,Megnevezes = "Víz"},
             new SzamlaModel(){Id=3 ,Megnevezes = "Gáz"},
            new SzamlaModel(){Id=4,Megnevezes = "KábelTV"}
           };
        }
        private BindableCollection<SzamlaModel> _szamlaTipusok;

        public BindableCollection<SzamlaModel> SzamlaTipusok
        {
            get { return _szamlaTipusok; }
            set { _szamlaTipusok = value;
                NotifyOfPropertyChange(()=>SzamlaTipusok);
            }
        }
        private SzamlaModel _selectedSzamlaTipus;

        public SzamlaModel SelectedSzamlaTipus
        {
            get { return _selectedSzamlaTipus; }
            set { _selectedSzamlaTipus = value;
                NotifyOfPropertyChange(()=>CanCalculate);
            }
        }
        private string _szamlaszam;

        public string Szamlaszam
        {
            get { return _szamlaszam; }
            set { 
                _szamlaszam = value;
                NotifyOfPropertyChange(() => CanCalculate);
            }
        }
        private int _osszeg;

        public int Osszeg
        {
            get { return _osszeg; }
            set { _osszeg = value;
                NotifyOfPropertyChange(() => CanCalculate);
            }
        }

        private BindableCollection<FelosztasModel> _felosztasok;

        public BindableCollection<FelosztasModel> Felosztasok
        {
            get { return _felosztasok; }
            set {
                 _felosztasok = value;
                NotifyOfPropertyChange(()=>Felosztasok);
            }
        }
        public bool CanCalculate {
            get {
                return SelectedSzamlaTipus != null && !string.IsNullOrEmpty(Szamlaszam) && !string.IsNullOrWhiteSpace(Szamlaszam) && Osszeg !=0;
            }
        }
        public void Calculate() { 
            
        }
    }
}
