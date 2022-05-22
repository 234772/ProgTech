﻿using MVVM.View;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new LibraryView()
            {
                DataContext = new LibraryViewModel()
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
