using System.Collections.ObjectModel;
using FilmLibrary.Data.Models;
using FilmLibrary.Data.Repositories.Contracts;
using FilmLibraryApp.Commands;
using FilmLibraryApp.ViewModels.Base;

namespace FilmLibraryApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ILibraryRepository libraryRepository;

        public HomeViewModel(ILibraryRepository libraryRepository)
        {
            this.libraryRepository = libraryRepository;
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
    }
}
