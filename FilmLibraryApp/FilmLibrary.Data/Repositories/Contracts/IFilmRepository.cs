using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.Data.Models;

namespace FilmLibrary.Data.Repositories.Contracts
{
    public interface IFilmRepository
    {
        Film GetFilmById(int id);

        IQueryable<Film> GetAllFilms();
    }
}
