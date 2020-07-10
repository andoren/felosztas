using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models.Interfaces
{
    interface IUkodManager
    {
        BindableCollection<UkodModel> GetAllUkod();
        bool AddUkod(UkodModel ukod);
        bool ModifyUkod(UkodModel ukod);
        bool DeleteUkodById(int id);
        UkodModel GetUkodById(int id);
    }
}
