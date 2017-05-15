using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Venta
    {
        public int VentaId { get; set; }

        private LineaTelefonica _LineaTelefonica;
        private Evaluacion _Evaluacion;
        private Contrato _Contrato;
        private TipoPago _TIpoPago;
        private CentroAtencion _CentroAtencion;
        private Cliente _Cliente;

        public Venta()
        {
            _LineaTelefonica = new LineaTelefonica();
            _Evaluacion = new Evaluacion();
            _Contrato = new Contrato();
            _TIpoPago = new TipoPago();
        }

        public Venta(CentroAtencion centroAtencion, Cliente cliente)
        {
            _LineaTelefonica = new LineaTelefonica();
            _Evaluacion = new Evaluacion();
            _Contrato = new Contrato();
            _TIpoPago = new TipoPago();

            _CentroAtencion = centroAtencion;
            _Cliente = cliente;
        }
    }
}
