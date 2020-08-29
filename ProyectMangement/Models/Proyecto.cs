using System;
using System.Collections.Generic;

namespace ProyectMangement.Models
{
    public class Proyecto
    {
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public double Precio { get; set; }
        public Lenguaje_Nivel Lenguaje_Nivel { get; set; }        
        public int Lenguaje_NivelId { get; set; }
    }
}