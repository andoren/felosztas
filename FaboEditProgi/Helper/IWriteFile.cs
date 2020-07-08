using FaboEditProgi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Helper
{
    interface IWriteFile
    {
        bool InitFile();
        bool AppandUkod(UkodModel ukod);
        bool AppandXkod(XkodModel xkod);
        bool AppandFelosztas(FelosztasModel ukod);
        bool ModifyUkod(UkodModel ukod);
        bool ModifyXkod(XkodModel xkod);
        bool ModifyFelosztas(FelosztasModel ukod);
        bool RemoveUkod(UkodModel ukod);
        bool RemoveXkod(XkodModel xkod);
        bool RemoveFelosztas(FelosztasModel ukod);
    }
}
