using Caliburn.Micro;
using FaboEditProgi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.Models.Service
{
    class UkodService : IUkodManager
    {
        public UkodService(IUkodManager manager)
        {
            this.manager = manager;
        }
        private IUkodManager manager;
        public bool AddUkod(UkodModel ukod)
        {
            return manager.AddUkod(ukod);
        }

        public bool DeleteUkodById(int id)
        {
            return manager.DeleteUkodById(id);
        }

        public BindableCollection<UkodModel> GetAllUkod()
        {
            return manager.GetAllUkod();
        }

        public UkodModel GetUkodById(int id)
        {
            return manager.GetUkodById(id);
        }

        public bool ModifyUkod(UkodModel ukod)
        {
            return manager.ModifyUkod(ukod);
        }
    }
}
