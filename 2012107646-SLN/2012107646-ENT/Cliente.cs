using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Calificacion { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nombres, string apellidos, string calificacion)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Calificacion = calificacion;
        }
    }
}
