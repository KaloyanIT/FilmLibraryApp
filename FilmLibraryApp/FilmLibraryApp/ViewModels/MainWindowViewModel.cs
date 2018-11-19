using System.Collections.Generic;
using System.Linq;
using FilmLibraryApp.Common;
using FilmLibraryApp.ViewModels.Base;
using FilmLibraryApp.ViewModels.Contracts;
using Ninject;

namespace FilmLibraryApp.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ICanNavigateViewModel currentViewModel;
        private ICollection<ICanNavigateViewModel> canNavigateViewModels;

        public ICollection<ICanNavigateViewModel> CanNavigateViewModels
        {
            get
            {
                if (this.canNavigateViewModels == null)
                {
                    this.canNavigateViewModels = new List<ICanNavigateViewModel>();
                }

                return this.canNavigateViewModels;
            }
        }

        public ICanNavigateViewModel CurrentViewModel
        {
            get
            {
                return this.currentViewModel;
            }
            set
            {
                this.SetProperty(ref this.currentViewModel, value, "CurrentViewModel");
                this.currentViewModel = value;
            }
        }

        private void ChangeViewModel(ICanNavigateViewModel viewModel)
        {
            if (!this.CanNavigateViewModels.Contains(viewModel))
            {
                this.CanNavigateViewModels.Add(viewModel);
            }

            this.CurrentViewModel = this.CanNavigateViewModels.FirstOrDefault(vm => vm == viewModel);
        }

        private void OnGoHomeScreen(object obj)
        {
            this.ChangeViewModel(this.CanNavigateViewModels.ElementAt(0));
        }

        private void OnGoLibraryScreen(object obj)
        {
            this.ChangeViewModel(this.CanNavigateViewModels.ElementAt(1));
        }

        private void OnGoFilmScreen(object obj)
        {
            this.ChangeViewModel(this.CanNavigateViewModels.ElementAt(2));
        }

        public MainWindowViewModel(IKernel kernel)
        {
            this.CanNavigateViewModels.Add(kernel.Get<HomeViewModel>());
            this.CanNavigateViewModels.Add(kernel.Get<LibraryViewModel>());
            this.CanNavigateViewModels.Add(kernel.Get<FilmViewModel>());

            this.CurrentViewModel = this.CanNavigateViewModels.ElementAt(0);

            Mediator.Subscribe("GoToHomeScreen", this.OnGoHomeScreen);
            Mediator.Subscribe("GoToLibraryScreen", this.OnGoLibraryScreen);
            Mediator.Subscribe("GoToFilmScreen", this.OnGoFilmScreen);
        }
    }
}
