using Caliburn.Micro;
using FaboEditProgi.Models;
using FaboEditProgi.Models.Manager;
using FaboEditProgi.Models.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FaboEditProgi.ViewModels
{
    class UKodViewModel:Screen
    {
        public UKodViewModel()
        {
           
            Ukodok = service.GetAllUkod();
        }
        UkodService service = new UkodService(new XMLUkodManager());
        #region Addition
        private string _newUkod;

        public string NewUkod
        {
            get { return _newUkod; }
            set { _newUkod = value;
                NotifyOfPropertyChange(()=> NewUkod);
            }
        }
        private string _newMegnevezes;

        public string NewMegnevezes
        {
            get { return _newMegnevezes; }
            set { 
                _newMegnevezes = value;
                NotifyOfPropertyChange(() => NewMegnevezes);
            }
        }

        public void SaveUkod() {
            UkodModel model = new UkodModel() {Megnevezes = NewMegnevezes ,Kod = NewUkod };
            if (service.AddUkod(model)) { 
                Ukodok.Add(model);
                MessageBox.Show("Sikeres mentés.");
                NewUkod = "";
                NewMegnevezes = "";
                
            }
            else MessageBox.Show("Hiba a mentés közben.");
            
        }
        #endregion

        #region Modify 
        private string _modifiedKod;

        public string ModifiedKod
        {
            get { return _modifiedKod; }
            set { _modifiedKod = value;
                NotifyOfPropertyChange(()=>ModifiedKod);
            }
        }
        private string _modifiedMegnevezes;

        public string ModifiedMegnevezes
        {
            get { return _modifiedMegnevezes; }
            set { _modifiedMegnevezes = value;
                NotifyOfPropertyChange(()=>ModifiedMegnevezes);
            }
        }
        private UkodModel _selectedUkod;

        public UkodModel ModificationUkod
        {
            get { return _selectedUkod; }
            set { _selectedUkod = value;
                if (value != null) {
                    ModifiedMegnevezes = value.Megnevezes;
                    ModifiedKod = value.Kod;
                }
                NotifyOfPropertyChange(()=>ModificationUkod);
            }
        }

        public void ModifyUkod() {
            UkodModel newmodel = new UkodModel();
            newmodel.Id = ModificationUkod.Id;
            newmodel.Kod = ModifiedKod;
            newmodel.Megnevezes = ModifiedMegnevezes;
            if (service.ModifyUkod(newmodel))
            {
                Ukodok.Remove(ModificationUkod);
                Ukodok.Add(newmodel);
                MessageBox.Show("Sikeres módosítás!");
                ModificationUkod = null;
                ModifiedMegnevezes = "";
                ModifiedKod = "";
            }
            else MessageBox.Show("Sikertelen módosítás!");

        }

        #endregion
        #region Delete
        private UkodModel _deletedUkod;

        public UkodModel DeletedUkod
        {
            get { return _deletedUkod; }
            set {
                _deletedUkod = value;
                NotifyOfPropertyChange(()=>DeletedUkod);
            }
        }
        public void DeleteUkod() {
            if (service.DeleteUkodById(DeletedUkod.Id))
            {
                Ukodok.Remove(DeletedUkod);
                MessageBox.Show("Törlés sikeres!");
            }
            else {
                MessageBox.Show("A manóba :( Valami hiba történt.");
            }
        }
        #endregion
        #region Shared
        private BindableCollection<UkodModel> _ukodok;

        public BindableCollection<UkodModel> Ukodok
        {
            get { return _ukodok; }
            set { _ukodok = value;
                NotifyOfPropertyChange(()=>Ukodok);
            }
        }
        #endregion

    }
}
