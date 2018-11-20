using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using FilmLibrary.Data;
using FilmLibrary.Data.Repositories;
using FilmLibrary.Data.Repositories.Contracts;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels;
using Ninject;

namespace FilmLibraryApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel iocKernel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.iocKernel = new StandardKernel();
            this.iocKernel.Load(new IocConfiguration());

            var app = this.iocKernel.Get<MainWindow>();

            //MainWindow app = new MainWindow();
            //MainWindowViewModel context = new MainWindowViewModel();

            //app.DataContext = context;
            app.Show();

            //MainWindow window = new MainWindow();
            //ILibraryRepository libraryRepository = new LibraryRepository();
            //var viewModel = new HomeViewModel(libraryRepository);

            ////viewModel.RequestClose += delegate { window.Close(); };
            //App.Current.MainWindow = window;
            //window.DataContext = viewModel;
            //window.Show();
        }

        private void APP_DispatcherUnhandledException(object sender,
           DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
            e.Handled = true;
        }
    }
}
