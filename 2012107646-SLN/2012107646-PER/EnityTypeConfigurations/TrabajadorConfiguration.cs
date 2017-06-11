using _2012107646_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_PER.EnityTypeConfigurations
{
    class TrabajadorConfiguration : EntityTypeConfiguration<Trabajador>
    {
           public TrabajadorConfiguration()
        {
            ToTable("Trabajor");
            HasKey(a => a.TrabajadorID);

            HasRequired(a => a.TipoTrabajador)
                .WithMany(a => a.Trabajador);

        }
    }
}
