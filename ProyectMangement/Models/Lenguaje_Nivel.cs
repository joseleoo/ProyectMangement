using System.Collections.Generic;

namespace ProyectMangement.Models
{
    public class Lenguaje_Nivel
    {
        public int Id { get; set; }
        public List<Nivel> Nivel { get; set; }
        public List<Lenguaje> Lenguaje { get; set; }
    }
}