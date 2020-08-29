using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectMangement.Models
{
    public class Cliente : Base
    {
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Proyecto Proyecto { get; set; }
        public int ProyectoId { get; set; }

        

    }
}
