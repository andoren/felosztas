using Caliburn.Micro;
using FaboEditProgi.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace FaboEditProgi.ViewModels
{
    class FelosztasViewModel:Screen
    {
        public FelosztasViewModel(ICalculate calculate)
        {
            SzamlaTipusok = new BindableCollection<SzamlaModel>() {
            new SzamlaModel(){Id=1, Megnevezes = "Áram",Felosztasok = new FelosztasModel[]{
                new FelosztasModel(1,new UkodModel(1,"Rákóczi","U011112"),new XkodModel(1,"Konyha","X0000001"),40,27),
                new FelosztasModel(2,new UkodModel(1,"Rákóczi","U011111"),new XkodModel(1,"Idős","X0000002"),45,0),
                new FelosztasModel(3,new UkodModel(1,"Rákóczi","U011111"),new XkodModel(1,"Szenvedély","X0000003"),11,0),
                new FelosztasModel(4,new UkodModel(1,"Rákóczi","U011111"),new XkodModel(1,"Hajléktalan","X0000004"),4,0),
            } }

           };
            this.Calculator = calculate;
        }

        private ICalculate _calculator;

        public ICalculate Calculator

        {
            get { return _calculator; }
            set { _calculator = value; }
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
        private bool _isAfaMentes;

        public bool IsAfaMentes
        {
            get { return _isAfaMentes; }
            set { _isAfaMentes = value;
                NotifyOfPropertyChange(()=>CanCalculate);
            }
        }
        private decimal _afaMentesOsszeg;

        public decimal AfaMentesOsszeg
        {
            get { return _afaMentesOsszeg; }
            set { _afaMentesOsszeg = value;
                NotifyOfPropertyChange(()=>CanCalculate);
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
                bool can = true;
                if (SelectedSzamlaTipus == null) can = false;
                else if (string.IsNullOrEmpty(Szamlaszam) && string.IsNullOrWhiteSpace(Szamlaszam)) can = false;
                else if (Osszeg == 0) can = false;
                else if (IsAfaMentes) if (AfaMentesOsszeg == 0) can = false;

                return can;          
            }
        }
        public void Calculate() {
            if(!IsAfaMentes)Felosztasok = Calculator.CalculateWithoutNonAfa(SelectedSzamlaTipus,Osszeg);
            else Felosztasok = Calculator.CalculateWithNonAfa(SelectedSzamlaTipus, Osszeg, AfaMentesOsszeg);
        }
    }
}
