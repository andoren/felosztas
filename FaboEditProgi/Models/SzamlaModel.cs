using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models
{
    class SzamlaModel
    {
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
        private FelosztasModel[] _felosztasok;

        public FelosztasModel[] Felosztasok
        {
            get { return _felosztasok; }
            set { _felosztasok = value; }
        }


    }
}
