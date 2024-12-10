using AvciKoru.Entities.Entities.Abstract;
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
    public class CategoryConfig:BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Description).HasMaxLength(100);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.HasIndex(p => p.Name).IsUnique();

            builder.HasData(
            new Category { Id = Guid.NewGuid().ToString(), Name = "Temizlik", Description = "Temizlik", CreateDate = DateTime.Now },
            new Category { Id = Guid.NewGuid().ToString(), Name = "Yiyecek", Description = "Yiyecek", CreateDate = DateTime.Now },
            new Category { Id = Guid.NewGuid().ToString(), Name = "Icecek", Description = "Icecek", CreateDate = DateTime.Now },
            new Category { Id = Guid.NewGuid().ToString(), Name = "Hizmet", Description = "Hizmet", CreateDate = DateTime.Now });



        }
    }
}
