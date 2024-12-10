using AvciKoru.Entities.Entities.Concrete;
using AvciKoru.Entities.EntityConfig.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.EntityConfig.Concrete
{
    public class OdaConfig : BaseConfig<Oda>
    {

        public override void Configure(EntityTypeBuilder<Oda> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.HasIndex(p => p.Name).IsUnique();

        }
    }
}
