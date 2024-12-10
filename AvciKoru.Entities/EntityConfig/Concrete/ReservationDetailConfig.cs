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
    public class ReservationDetailConfig : BaseConfig<ReservationDetail>
    {
        public override void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            base.Configure(builder);
            
        }
    }
}
