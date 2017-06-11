using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012107646_ENT.IRepositories;
using _2012107646_ENT;

namespace _2012107646_PER.Repositories
{
    public class DireccionRepository : Repository<Direccion>, IDireccionRepository
    {
        private PaulDbContext _Context;

        public DireccionRepository(PaulDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private DireccionRepository()
        {

        }
    }
}
