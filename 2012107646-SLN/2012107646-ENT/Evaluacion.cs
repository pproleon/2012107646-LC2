using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
   public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        
        private EquipoCelular _EquipoCelular;
        private EstadoEvaluacion _EstadoEvaluacion;
        private TipoEvaluacion _TipoEvaluacion;
        private Plan _Plan;
        private Cliente _Cliente;
        private LineaTelefonica _LineaTelefonica;
        private CentroAtencion _CentroAtencion;

        public Evaluacion()
        {
            _EquipoCelular = new EquipoCelular();
            _EstadoEvaluacion = new EstadoEvaluacion();
            _TipoEvaluacion = new TipoEvaluacion();
        }

        public Evaluacion(Plan plan, Cliente cliente,
                        LineaTelefonica lineaTelefonica,
                        CentroAtencion centroAtencion)
        {
            _EquipoCelular = new EquipoCelular();
            _EstadoEvaluacion = new EstadoEvaluacion();
            _TipoEvaluacion = new TipoEvaluacion();

            _Plan = plan;
            _Cliente = cliente;
            _LineaTelefonica = lineaTelefonica;
            _CentroAtencion = centroAtencion;
        }
    }
}
