using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string Name { get; set; }
        private List<Distrito> _Distritos;

        public Provincia()
        {
            _Distritos = new List<Distrito>();
        }
    }
}
