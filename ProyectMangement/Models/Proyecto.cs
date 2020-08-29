using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectMangement.Models
{
    public class Proyecto : Base
    {

        public Cliente Cliente { get; set; }


        [Required(ErrorMessage = "Se requiere incluir un cliente")]
        public int ClienteId { get; set; }


       [Required(ErrorMessage = "Se requiere incluir una fecha inicial")]
         [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }


       [Required(ErrorMessage = "Se requiere incluir un fecha final")]
        [DataType(DataType.Date)]
        public DateTime FechaFinal { get; set; }


        [Required(ErrorMessage = "Se requiere incluir un precio")]
        [DataType(DataType.Currency)]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Se requiere incluir cantidad en horas")]

    
        public int Horas { get; set; }
        public Lenguaje_Nivel Lenguaje_Nivel { get; set; }
        public int Lenguaje_NivelId { get; set; }
    }
}