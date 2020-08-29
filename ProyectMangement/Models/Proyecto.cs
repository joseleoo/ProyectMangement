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
        public List<Lenguaje_Nivel> Lenguaje_Nivel { get; set; }        
        public Lenguaje Lenguaje { get; set; }
        public int LenguajeId { get; set; }
    }
}