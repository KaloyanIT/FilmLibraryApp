using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibraryApp.ViewModels;
using Ninject.Modules;

namespace FilmLibraryApp.Common
{
    public class IocConfiguration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<MainWindowViewModel>().ToSelf().InTransientScope();
            this.Bind<MainWindow>().ToSelf().InTransientScope();


        }
    }
}
