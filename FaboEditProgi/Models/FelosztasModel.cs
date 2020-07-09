using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    class FelosztasModel
    {
        public FelosztasModel(int Id, UkodModel Ukod, XkodModel Xkod, int Percentage, int AfaMertek,decimal TeljesOsszeg):this(Id,Ukod,Xkod,Percentage,AfaMertek)
        {

            this.TeljesOsszeg = TeljesOsszeg;
            
        }
        public FelosztasModel(int Id, UkodModel Ukod, XkodModel Xkod, int Percentage, int AfaMertek)
        {
            this.Id = Id;
            this.Ukod = Ukod;
            this.Xkod = Xkod;
            this.Percentage = Percentage;
            this.AfaMertek = AfaMertek;
        }
        public FelosztasModel(string Megnevezes, decimal NettoOsszeg, decimal AfaOsszeg)
        {
            this.Xkod = new XkodModel(1,Megnevezes,"");
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


        public void CalculateNettoOsszeg()
        {
            
                NettoOsszeg= ((TeljesOsszeg * (Percentage / (decimal)100)) * (AfaMertek==0?1: (((decimal)100- AfaMertek)/100) ));
            
          
        }


        private decimal _afaOsszeg;

        public decimal AfaOsszeg
        {
            get { return _afaOsszeg; }
            set { _afaOsszeg = value; }
        }
        public void CalculateAfaOsszeg()
        {
            AfaOsszeg = ((AfaMertek / (decimal)100) * (TeljesOsszeg * (Percentage / (decimal)100)));
        }
        public decimal Osszesen {
            get {
                return NettoOsszeg + AfaOsszeg;
            }
        }
        private decimal _teljesOsszeg;

        public decimal TeljesOsszeg
        {
            get { return _teljesOsszeg; }
            set { _teljesOsszeg = value; }
        }


    }
}
