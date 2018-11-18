using System.Windows;
using System.Windows.Controls;
using FilmLibraryApp.ViewModels;

namespace FilmLibraryApp.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            this.InitializeComponent();
            this.DataContext = new HomeViewModel();
        }
    }
}
