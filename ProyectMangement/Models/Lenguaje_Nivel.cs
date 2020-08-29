using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectMangement.Models
{
    public class Lenguaje_Nivel
    {
        [Required]
        public int Id { get; set; }
        public List<Nivel> Nivel { get; set; }
        public List<Lenguaje> Lenguaje { get; set; }
    }
}