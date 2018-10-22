using System.Collections.Generic;
using System.Linq;
using FilmLibrary.Data.Enums;
using FilmLibrary.Data.Models;
using FilmLibrary.Data.Repositories.Contracts;

namespace FilmLibrary.Data.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private List<Film> films = new List<Film>();

        public FilmRepository()
        {
            this.films.Add(new Film
            {
                Id = 0,
                Title = "Mission impossible: Fallout",
                Genre = Genre.Action
            });

            this.films.Add(new Film
            {
                Id = 1,
                Title = "Mission impossible: 5",
                Genre = Genre.Action
            });
        }
        public IQueryable<Film> GetAllFilms()
        {
            return this.films.AsQueryable();
        }

        public Film GetFilmById(int id)
        {
            var film = this.films.Where(x => x.Id == id).FirstOrDefault();

            return film;
        }
    }
}
