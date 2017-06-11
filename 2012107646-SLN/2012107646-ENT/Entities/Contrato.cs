using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Contrato
    {
        public int ContratoID { get; set; }

        public Venta Venta { get; set; }
        public int VentaID { get; set; }

        public Contrato()
        {


        }
    }
}
