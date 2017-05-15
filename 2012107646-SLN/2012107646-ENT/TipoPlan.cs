using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class TipoPlan
    {
        public int TipoPlanId { get; set; }
        public string Name { get; set; }
        public string Descripcion { get; set; }

        //implementar prepago y postpago
        public TipoPlan()
        {

        }

        public TipoPlan(string descripcion)
        {
            Descripcion = descripcion;
        }

    }
}
