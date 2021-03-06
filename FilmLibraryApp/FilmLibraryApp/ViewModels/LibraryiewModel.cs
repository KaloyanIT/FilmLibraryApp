﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.Models.Library;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;
using Ninject;

namespace FilmLibraryApp.ViewModels
{
    public class LibraryViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private ICommand goToFilmScreen;
        private ICommand goToCreateLibraryScreen;
        private ICommand goToHomeScreen;
        private ICommand getAllLibraries;

        public LibraryViewModel(LibraryModel libraries)
        {
            this.Libraries = libraries;
        }

 
        public LibraryModel Libraries { get; set; }

        //public ICommand GetAllLibraries
        //{
        //    get
        //    {

        //    }
        //}

        public ICommand GoToFilmScreen
        {
            get
            {
                return this.goToFilmScreen ?? (this.goToFilmScreen = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToFilmScreen", "");
                }));
            }
        }

        public ICommand GoToCreateLibraryScreen
        {
            get
            {
                return this.goToCreateLibraryScreen ?? (this.goToCreateLibraryScreen = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToCreateLibraryScreen", "");
                }));
            }
        }

        public ICommand GoToHomeScreen
        {
            get
            {
                return this.goToHomeScreen ?? (this.goToHomeScreen = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToHomeScreen", "");
                }));
            }
        }
    }
}
