using System.Linq;
using FilmLibrary.Data.Models;

namespace FilmLibrary.Data.Repositories.Contracts
{
    public interface ILibraryRepository
    {
        Library GetLibraryById(int id);

        IQueryable<Library> GetAllLibraries();

        Library Create(string title);
    }
}
