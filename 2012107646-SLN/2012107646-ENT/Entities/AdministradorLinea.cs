using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class AdministradorLinea
    {

       
            public int AdministradorLineaID { get; set; }

            public ICollection<LineaTelefonica> LineaTelefonica { get; set; }

            public AdministradorLinea()
            {
                LineaTelefonica = new Collection<LineaTelefonica>();
            }
        }
    }
