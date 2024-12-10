﻿using AvciKoru.Entities.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvciKoru.Entities.EntityConfig.Abstract
{
    public abstract class BaseConfig<T> : 
        IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasDefaultValue(new Guid().ToString());

            builder.Property(p=>p.CreateDate).HasDefaultValue(new DateTime());
            builder.Property(p=>p.SiteId).HasDefaultValue("");
        }

       
    }
}
