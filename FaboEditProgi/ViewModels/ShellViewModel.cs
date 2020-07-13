using Caliburn.Micro;
using FaboEditProgi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.ViewModels
{
    class ShellViewModel:Conductor<Screen>
    {
        public ShellViewModel()
        {
            ActivateItemAsync(new FelosztasViewModel(new Calculator()));
        }
        public void ExitWindow()
        {
            TryCloseAsync();
        }
        public void Ukod() {
            ActivateItemAsync(new UKodViewModel());
        }
        public void Home() {
            ActivateItemAsync(new FelosztasViewModel(new Calculator()));
        }
    }
}
