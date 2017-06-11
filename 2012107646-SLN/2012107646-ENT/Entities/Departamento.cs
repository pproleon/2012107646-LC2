using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }

        public ICollection<Provincia> Provincia { get; set; }
        public int ProvinciaID { get; set; }

        public Departamento()
        {

            Provincia = new Collection<Provincia>();
        }

    }
}
