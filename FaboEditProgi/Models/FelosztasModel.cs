using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    class FelosztasModel
    {
        public FelosztasModel(int Id, UkodModel Ukod, XkodModel Xkod, int Percentage, int AfaMertek,decimal NettoOsszeg,decimal AfaOsszeg,decimal Osszesen)
        {
            this.Id = Id;
            this.Ukod = Ukod;
            this.Xkod = Xkod;
            this.Percentage = Percentage;
            this.AfaMertek = AfaMertek;
            this.NettoOsszeg = NettoOsszeg;
            this.AfaOsszeg = AfaOsszeg;
            
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private UkodModel _ukod;

        public UkodModel Ukod
        {
            get { return _ukod; }
            set {
                _ukod = value; 
                
            }
        }
        private XkodModel _xkod;

        public XkodModel Xkod
        {
            get { return _xkod; }
            set { 
                _xkod = value;
                
            }
        }

        private int _percentage;

        public int Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }
        private int _afaMertek;

        public int AfaMertek
        {
            get { return _afaMertek; }
            set { _afaMertek = value; }
        }
        private decimal _nettoOsszeg;

        public decimal NettoOsszeg
        {
            get { return _nettoOsszeg; }
            set { _nettoOsszeg = value; }
        }
        private decimal _afaOsszeg;

        public decimal AfaOsszeg
        {
            get { return _afaOsszeg; }
            set { _afaOsszeg = value; }
        }
        public decimal Osszesen
        {
            get { return NettoOsszeg + AfaOsszeg; }
          
        }


    }
}
