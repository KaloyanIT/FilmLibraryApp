using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;

namespace FilmLibraryApp.ViewModels
{
    public class CreateFilmViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private ICommand goToFilmScreen;

        public CreateFilmViewModel()
        {

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
    }
}
