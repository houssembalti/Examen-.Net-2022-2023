using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasKey(r => new { r.PrestationFK, r.ClientFK ,r.DateRDv});
            builder.HasOne(r => r.Client).WithMany(c => c.RDVList).HasForeignKey(r => r.ClientFK);
            builder.HasOne(r => r.Prestation).WithMany(p => p.rendezvouslist).HasForeignKey(r => r.PrestationFK);
        }
    }
}
