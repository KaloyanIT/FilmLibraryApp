using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FilmLibrary.Data;
using FilmLibraryApp.ViewModels;

namespace FilmLibraryApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new MainWindow();

            var viewModel = new HomeViewModel();

            //viewModel.RequestClose += delegate { window.Close(); };

            window.DataContext = viewModel;
            window.Show();
        }
    }
}
