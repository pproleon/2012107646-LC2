using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class AdministradorEquipo
    {
        public int AdministradorEquipoId { get; set; }
        public string Name { get; set; }
       

        public List<EquipoCelular> _Equipos{get;set;}

        public AdministradorEquipo()
        {
            Equipos = new List<EquipoCelular>();
        }

        public List<EquipoCelular> Equipos
        {
            get { return _Equipos; }
            private set { _Equipos = value; }
        }

        public void AgregarEquipo(EquipoCelular equipo)
        {
            Equipos.Add(equipo);
        }

    }
}
