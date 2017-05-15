using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class EquipoCelular
    {
        public int EquipoCelularId { get; set; }
       
        public string Marca { get; private set; }
        public string Gama { get; private set; }
        public Decimal Precio { get; private set; }
        public string Estado { get; set; }


        public EquipoCelular()
        {

        }

        public EquipoCelular(string marca, string gama)
        {
            Marca = marca;
            Gama = gama;
            Precio = CalcularPrecio(marca, gama);
        }

        private Decimal CalcularPrecio(string marca, string Gama)
        {
            if (marca == "Samsung" && Gama == "Alta")
                return 600.00m;
            else if (marca == "Samsung" && Gama == "Media")
                return 300.00m;
            else
                return 200.00m;
        }
    }
}
