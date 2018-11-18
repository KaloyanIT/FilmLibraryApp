using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;

namespace FilmLibraryApp.ViewModels
{
    public class FilmViewModel : BaseViewModel, ICanNavigateViewModel
    {
        private ICommand goToHomeScreen;
        private ICommand goToLibraryScreen;

        public FilmViewModel()
        {
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
