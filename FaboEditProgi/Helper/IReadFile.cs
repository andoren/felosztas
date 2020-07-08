using Caliburn.Micro;
using FaboEditProgi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Helper
{
    interface IReadFile
    {

        BindableCollection<XkodModel> ReadXKodsByUkodID(int Id);
        BindableCollection<UkodModel> ReadUKods();
        BindableCollection<FelosztasModel> ReadFelosztasok();
    }
}
