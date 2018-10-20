using System.Data.Entity;
using FilmLibrary.Data.Models;

namespace FilmLibrary.Data
{
    public class FilmLibraryContext : DbContext
    {
        public FilmLibraryContext() : base("name=FilmLibraryDBConnectionString")
        {
            Database.SetInitializer<FilmLibraryContext>(new CreateDatabaseIfNotExists<FilmLibraryContext>());
        }

        public DbSet<Film> Films { get; set; }

        public DbSet<Library> Libraries { get; set; }
    }
}
