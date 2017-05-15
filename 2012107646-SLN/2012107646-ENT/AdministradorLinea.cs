using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class AdministradorLinea
    {

        public int AdministradorLineaId { get; set; }
        public string Name { get; set; }
     

        public List<LineaTelefonica> _Lineas{get;set;}

        public List<LineaTelefonica> Lineas
        {
            get { return _Lineas; }
            private set { _Lineas = value; }
        }

        public AdministradorLinea()
        {
            Lineas = new List<LineaTelefonica>();
        }

        public void AgregarLinea(string numero)
        {
            Lineas.Add(new LineaTelefonica(numero));
        }
    }
}
