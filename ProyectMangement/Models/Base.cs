using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectMangement.Models
{
    public class Base
    {
        [Required]
        public int Id { get; set; }
        [Display(Prompt = "Nombre o descripción", Name = "Nombre o descripción")]
        [MaxLength(100, ErrorMessage = "La longitud maxima del nombre es 100")]
        [Required(ErrorMessage = "El nombre  es requerido")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        
    }
}
