using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibraryApp.Models.Library
{
    public class LibraryPOCO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        //public ICollection<Film> Films { get; set; }
    }
}
