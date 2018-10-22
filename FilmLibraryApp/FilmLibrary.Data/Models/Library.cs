using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Models
{
    public class Library
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
