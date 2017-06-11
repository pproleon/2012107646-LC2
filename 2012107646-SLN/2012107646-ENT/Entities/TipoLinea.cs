using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public  class TipoLinea
    {
        public int TipoLineaID { get; set; }

        public ICollection<LineaTelefonica> LineaTelefonica { get; set; }
        public int LineaTelefonicaID { get; set; }



        public TipoLinea()
        {
            LineaTelefonica = new Collection<LineaTelefonica>();
        }

    }
}
