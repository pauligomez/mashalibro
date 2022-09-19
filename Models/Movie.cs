using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;

       
        public string Genero { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}