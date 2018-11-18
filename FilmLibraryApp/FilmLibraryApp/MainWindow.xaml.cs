﻿using System.Windows;
using FilmLibrary.Data.Repositories;
using FilmLibrary.Data.Repositories.Contracts;
using FilmLibraryApp.ViewModels;
using FilmLibraryApp.Views;

namespace FilmLibraryApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel vm)
        {
            this.DataContext = vm;
            this.InitializeComponent();
        }

        private void HomeViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            //ILibraryRepository libraryRepository = new LibraryRepository();
            //HomeViewModel homeViewModelObject = new HomeViewModel();
            //homeViewModelObject.LoadLibraries();

            //this.HomeViewControl.DataContext = homeViewModelObject;
        }
    }
}
