using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Name { get; set; }
        public List<Provincia> _Provincias;
        public Departamento()
        {
            _Provincias = new List<Provincia>();
        }
    }
}
