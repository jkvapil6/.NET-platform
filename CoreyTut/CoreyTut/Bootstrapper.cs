﻿using Caliburn.Micro;
using CoreyTut.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace CoreyTut
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
