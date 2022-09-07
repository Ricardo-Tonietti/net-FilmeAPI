using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPi.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Cinema> Cinemas { get; set; }

    }
}
