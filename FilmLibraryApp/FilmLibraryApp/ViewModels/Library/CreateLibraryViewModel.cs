using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;

namespace FilmLibraryApp.ViewModels.Library
{
    public class CreateLibraryViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private ICommand goToLibraryScreen;

        public CreateLibraryViewModel()
        {

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
    }
}
