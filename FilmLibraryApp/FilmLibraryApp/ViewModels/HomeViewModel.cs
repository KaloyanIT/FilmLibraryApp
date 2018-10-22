using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FilmLibraryApp.Commands;
using FilmLibraryApp.ViewModels.Base;

namespace FilmLibraryApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {

        }

        public DelegateCommand RequestClose { get; internal set; }
    }
}
