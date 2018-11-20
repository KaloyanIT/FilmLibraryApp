using System;
using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.Models.Library;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;

namespace FilmLibraryApp.ViewModels.Library
{
    public class CreateLibraryViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private ICommand goToLibraryScreen;
        private ICommand createLibrary;

        public CreateLibraryViewModel(LibraryModel libraries)
        {
            this.Libraries = libraries;
        }

        public string LibraryTitle { get; set; }

        public ICommand CreateLibrary
        {
            get
            {
                return this.createLibrary ?? (this.createLibrary = new RelayCommand(x =>
                {
                    if(string.IsNullOrEmpty(this.LibraryTitle))
                    {
                        throw new ArgumentException("Invalid library name.");
                    }

                    this.Libraries.AddLibrary(this.LibraryTitle);
                }));
            }
        }

        public ICommand GoToLibraryScreen
        {
            get
            {
                return this.goToLibraryScreen ?? (this.goToLibraryScreen = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToFilmScreen", "");
                }));
            }
        }

        public LibraryModel Libraries { get; set; }
    }
}
