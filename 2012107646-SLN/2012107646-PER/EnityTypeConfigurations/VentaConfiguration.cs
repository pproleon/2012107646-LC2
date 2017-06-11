using _2012107646_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_PER.EnityTypeConfigurations
{
    class VentaConfiguration : EntityTypeConfiguration<Venta>
    {
        public VentaConfiguration()
        {
            ToTable("Venta");
            HasKey(a => a.VentaID);

            HasRequired(a => a.CentroAtencion)
                .WithMany(a => a.Venta);

            HasRequired(a => a.Contrato)
                .WithRequiredPrincipal(a => a.Venta);

            HasRequired(a => a.TipoPago)
                .WithMany(a => a.Venta);

            HasRequired(a => a.Cliente)
                .WithMany(a => a.Venta);

            HasRequired(a => a.Evaluacion)
                .WithRequiredPrincipal(a => a.Venta);

            HasRequired(a => a.LineaTelefonica)
                .WithRequiredPrincipal(a => a.Venta);
        }
    }
}
