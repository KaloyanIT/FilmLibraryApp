using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.Data.Enums;

namespace FilmLibraryApp.Models
{
    public class FilmPOCO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime PublishedDate { get; set; }

        public int Duration { get; set; }

        public Genre Genre { get; set; }

        public int Popularity { get; set; }

        public decimal ImdbRating { get; set; }

        public decimal PersonalRating { get; set; }

        //public int LibraryId { get; set; }

        //public Library Library { get; set; }
    }
}
