using System;
using System.Collections.Generic;
using System.Linq;
using FilmLibrary.Data.Models;
using FilmLibrary.Data.Repositories.Contracts;

namespace FilmLibrary.Data.Repositories
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly List<Library> libraries;

        public LibraryRepository()
        {
            this.libraries = new List<Library>();

            this.libraries.Add(new Library()
            {
                Id = 0,
                Title = "Chill library",
                DateCreated = DateTime.Now
            });

            this.libraries.Add(new Library()
            {
                Id = 1,
                Title = "Romantic library",
                DateCreated = DateTime.Now
            });
        }
        public IQueryable<Library> GetAllLibraries()
        {
            return this.libraries.AsQueryable();
        }

        public Library Create(string title)
        {
            var library = new Library();
            library.Id = this.libraries.Last().Id + 1;
            library.Title = title;
            library.DateCreated = DateTime.Now;

            return library;
        }

        public Library GetLibraryById(int id)
        {
            var library = this.libraries.Where(x => x.Id == id).FirstOrDefault();

            return library;
        }
    }
}
