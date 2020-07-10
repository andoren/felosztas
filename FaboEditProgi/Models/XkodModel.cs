using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    public class XkodModel
    {
        public XkodModel()
        {

        }
        public XkodModel(int Id, string Megnevezes, string Kod, UkodModel Ukod,string NettoTartozik,string NettoKovetel,string AfaTartozik,string AfaKovetel):this(Id,Megnevezes,Kod,Ukod)
        {
            this.NettoTartozik = NettoTartozik;
            this.NettoKovetel = NettoKovetel;
            this.AfaTartozik = AfaTartozik;
            this.AfaKovetel = AfaKovetel;
        }
        public XkodModel(int Id, string Megnevezes, string Kod,UkodModel Ukod):this(Id,Megnevezes,Kod)
        {

            this.Ukod = Ukod;
        }
        public XkodModel(int Id, string Megnevezes, string Kod)
        {
            this.Id = Id;
            this.Megnevezes = Megnevezes;
            this.Kod = Kod;
           
        }
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nettoTartozk;

        public string NettoTartozik
        {
            get { return _nettoTartozk; }
            set { _nettoTartozk = value; }
        }
        private string _nettoKovetel;

        public string NettoKovetel
        {
            get { return _nettoKovetel; }
            set { _nettoKovetel = value; }
        }
        private string _afaTartozik;

        public string AfaTartozik
        {
            get { return _afaTartozik; }
            set { _afaTartozik = value; }
        }
        private string _afaKovetel;

        public string AfaKovetel
        {
            get { return _afaKovetel; }
            set { _afaKovetel = value; }
        }

        private string _megnevezes;

        public string Megnevezes
        {
            get { return _megnevezes; }
            set { _megnevezes = value; }
        }

        private string _kod;

        public string Kod
        {
            get { return _kod; }
            set { _kod = value; }
        }
        private UkodModel _ukod;

        public UkodModel Ukod
        {
            get { return _ukod; }
            set { _ukod = value; }
        }


    }
}
