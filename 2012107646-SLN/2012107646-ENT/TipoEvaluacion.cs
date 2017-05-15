using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class TipoEvaluacion
    {  //Renovacion Portabilidad y LineaNueva
        public int TipoEvaluacionId { get; set; }
        public string Name { get; set; }
        
        public TipoEvaluacion(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoEvaluacion()
        {

        }

        public string Descripcion { get; set; }
    }
}
