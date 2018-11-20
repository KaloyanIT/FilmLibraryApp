using FilmLibrary.Data.Repositories;
using FilmLibrary.Data.Repositories.Contracts;
using FilmLibraryApp.ViewModels;
using FilmLibraryApp.ViewModels.Library;
using Ninject.Modules;

namespace FilmLibraryApp.Common
{
    public class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<MainWindowViewModel>().ToSelf().InSingletonScope();
            this.Bind<MainWindow>().ToSelf().InTransientScope();

            this.Bind<FilmViewModel>().ToSelf().InSingletonScope();
            this.Bind<CreateFilmViewModel>().ToSelf().InSingletonScope();
            this.Bind<LibraryViewModel>().ToSelf().InSingletonScope();
            this.Bind<CreateLibraryViewModel>().ToSelf().InSingletonScope();
            this.Bind<HomeViewModel>().ToSelf().InSingletonScope();
            this.Bind<IFilmRepository>().To<FilmRepository>().InSingletonScope();
            this.Bind<ILibraryRepository>().To<LibraryRepository>().InSingletonScope();
        }
    }
}
