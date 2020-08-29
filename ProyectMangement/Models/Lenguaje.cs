using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectMangement.Models
{
    public class Lenguaje : Base
    {
        public List<Nivel> Niveles { get; set; }       
        public Lenguaje_Nivel Lenguaje_Nivel { get; set; }
        public int Lenguaje_NivelId { get; set; }
    }
}
