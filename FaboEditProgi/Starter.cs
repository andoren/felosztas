using Caliburn.Micro;
using FaboEditProgi.Models.Manager;
using FaboEditProgi.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace FaboEditProgi
{
    public class Starter:BootstrapperBase
    {
        public Starter()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {

           
 
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
