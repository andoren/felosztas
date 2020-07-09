using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    class XkodModel
    {
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
