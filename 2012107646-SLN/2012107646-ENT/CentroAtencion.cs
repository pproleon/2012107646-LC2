using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }
        public string Name { get; set; }

        public Direccion _Direccion { get; set; }
        public CentroAtencion()
        {
            _Direccion = new Direccion();
        }
    }
}
