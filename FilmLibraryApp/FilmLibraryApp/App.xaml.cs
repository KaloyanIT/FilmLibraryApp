using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FilmLibrary.Data;
using FilmLibrary.Data.Repositories;
using FilmLibrary.Data.Repositories.Contracts;
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

            //MainWindow window = new MainWindow();
            //ILibraryRepository libraryRepository = new LibraryRepository();
            //var viewModel = new HomeViewModel(libraryRepository);

            ////viewModel.RequestClose += delegate { window.Close(); };
            //App.Current.MainWindow = window;
            //window.DataContext = viewModel;
            //window.Show();
        }
    }
}
