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
    public class ReservationConfig:BaseConfig<Reservation>
    {
        public override void Configure(EntityTypeBuilder<Reservation> builder)
        {
            base.Configure(builder);
            
        }
    }
}
