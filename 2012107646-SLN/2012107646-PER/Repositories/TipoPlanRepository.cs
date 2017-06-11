using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2012107646_ENT;
using _2012107646_ENT.IRepositories;

namespace _2012107646_PER.Repositories
{
    public class TipoPlanRepository : Repository<TipoPlan>, ITipoPlanRepository
    {
        private PaulDbContext _Context;

        public TipoPlanRepository(PaulDbContext _Context)
        {
            // TODO: Complete member initialization
            this._Context = _Context;
        }

        private TipoPlanRepository()
        {

        }
    }
}
