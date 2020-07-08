using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace FaboEditProgi.ViewModels
{
    class ShellViewModel:Conductor<Screen>
    {
        public ShellViewModel()
        {
            ActivateItemAsync(new FelosztasViewModel());
        }
        public void ExitWindow()
        {
            TryCloseAsync();
        }
    }
}
