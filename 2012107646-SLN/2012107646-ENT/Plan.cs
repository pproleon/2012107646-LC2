using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }
        private TipoPlan _TipoPlan;

        public Plan()
        {
            _TipoPlan = new TipoPlan();
        }

    }
}
