using System.Collections.ObjectModel;
using System.Windows.Input;
using FilmLibrary.Data.Models;
using FilmLibrary.Data.Repositories.Contracts;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;

namespace FilmLibraryApp.ViewModels
{
    public class HomeViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private readonly ILibraryRepository libraryRepository;
        private ICommand goToFilmScreen;
        private ICommand goToLibraryScreen;

        public HomeViewModel()
        {
            this.LoadLibraries();
        }

        public DelegateCommand RequestClose { get; internal set; }

        public ObservableCollection<Library> Libraries { get; set; }

        public void LoadLibraries()
        {
            ObservableCollection<Library> libraries = new ObservableCollection<Library>();

            libraries.Add(
                new Library() { Id = 0, Title = "Test1" }
            );

            this.Libraries = libraries;
        }

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

        public ICommand GoToLibraryScreen
        {
            get
            {
                return this.goToLibraryScreen ?? (this.goToLibraryScreen = new RelayCommand(x =>
                {
                    Mediator.Notify("GoToLibraryScreen", "");
                }));
            }
        }
    }
}
