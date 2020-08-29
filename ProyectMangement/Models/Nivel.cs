using System.Collections.Generic;

namespace ProyectMangement.Models
{
    public class Nivel : Base
    {
        public List<Lenguaje> Lenguajes { get; set; }
        public int LenguajeId { get; set; }
        public Lenguaje_Nivel Lenguaje_Nivel { get; set; }
        public int Lenguaje_NivelId { get; set; }
    }
}