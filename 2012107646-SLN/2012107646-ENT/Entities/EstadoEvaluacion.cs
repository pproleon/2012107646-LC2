using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class EstadoEvaluacion
    {
        public int EstadoEvaluacionID { get; set; }

        public ICollection<Evaluacion> Evaluacion { get; set; }
        public int EvaluacionID { get; set; }

        public EstadoEvaluacion()
        {
            Evaluacion = new Collection<Evaluacion>();
        }
    }
}
