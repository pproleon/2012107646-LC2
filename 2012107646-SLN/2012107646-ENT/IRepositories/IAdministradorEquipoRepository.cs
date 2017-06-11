using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT.IRepositories
{
    public interface IAdministradorEquipoRepository: IRepository<AdministradorEquipo>
    {
        IEnumerable<AdministradorEquipo> GetAdministradorEquipoWithEquipoCelular(int pageindex, int pageSize);
    }
}
