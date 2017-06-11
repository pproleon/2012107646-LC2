using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012107646_ENT.IRepositories;
using _2012107646_ENT;

namespace _2012107646_PER.Repositories
{
    public class AdministradorEquipoRepository : Repository<AdministradorEquipo>,IAdministradorEquipoRepository
    {
        private readonly PaulDbContext _Context;

        public AdministradorEquipoRepository(PaulDbContext context)
        {
            _Context = context;
        }

        private AdministradorEquipoRepository() { }

        IEnumerable<AdministradorEquipo> IAdministradorEquipoRepository.GetAdministradorEquipoWithEquipoCelular(int pageindex, int pageSize)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Add(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.AddRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        AdministradorEquipo IRepository<AdministradorEquipo>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<AdministradorEquipo> IRepository<AdministradorEquipo>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<AdministradorEquipo> IRepository<AdministradorEquipo>.Find(System.Linq.Expressions.Expression<Func<AdministradorEquipo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Update(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.UpdateRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.Delete(AdministradorEquipo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AdministradorEquipo>.DeleteRange(IEnumerable<AdministradorEquipo> entities)
        {
            throw new NotImplementedException();
        }

    }
}
