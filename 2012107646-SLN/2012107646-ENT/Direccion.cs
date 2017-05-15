using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Name { get; set; }
        private Ubigeo _Ubigeo;
        public Direccion()
        {
            _Ubigeo = new Ubigeo();
        }
    }
}
