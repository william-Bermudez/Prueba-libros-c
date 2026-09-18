using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Prueba.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Autor { get; set; }
        [Required]
        [StringLength(13, MinimumLength = 10)]
        public string ISBN { get; set; }

        [Precision(18, 2)]
        public decimal precio { get; set; }


        public bool disponibilidad { get; set; }


        //el codigo sera public DbSet<Libro> Libro { get; set; } 

    }
}
