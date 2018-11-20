using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.Data.Repositories.Contracts;

namespace FilmLibraryApp.Models.Library
{
    public class LibraryModel : ObservableCollection<LibraryPOCO>
    {
        private readonly ILibraryRepository libraryRepository;

        public LibraryModel(ILibraryRepository libraryRepository)
        {
            this.libraryRepository = libraryRepository;
            this.GetAll();
        }      

        //public ICollection<Film> Films { get; set; }

        public void GetAll()
        {
            var libraries = this.libraryRepository.GetAllLibraries();
            ICollection<LibraryPOCO> libraryModels = new List<LibraryPOCO>();

            foreach(var library in libraries)
            {
                var currLib = new LibraryPOCO();
                currLib.Id = library.Id;
                currLib.Title = library.Title;
                currLib.DateCreated = library.DateCreated;

                this.Add(currLib);
            }            
        }

        public void AddLibrary(string title)
        {
            var library = this.libraryRepository.Create(title);

            var currLib = new LibraryPOCO();
            currLib.Id = library.Id;
            currLib.Title = library.Title;
            currLib.DateCreated = library.DateCreated;

            this.Add(currLib);
        }
    }
}
