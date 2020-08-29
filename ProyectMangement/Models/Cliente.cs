using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectMangement.Models
{
    public class Cliente : Base
    {
        [Required(ErrorMessage = "El apellido del es requerido")]
        [MaxLength(100, ErrorMessage = "La longitud maxima del apellido es 100")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }
        [MaxLength(100, ErrorMessage = "La longitud maxima del telefono es 100")]
        [Required(ErrorMessage = "El telefono del es requerido")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        [MaxLength(100, ErrorMessage = "La longitud maxima del email es 100")]
        [Required(ErrorMessage = "El email del es requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Proyecto Proyecto { get; set; }


        

    }
}
