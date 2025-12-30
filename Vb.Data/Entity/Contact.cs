using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vb.Data.Entity;

public class Contact
{
    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public string ContactType { get; set; }
    public string Information { get; set; }
    public bool IsDefault { get; set; }
}

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(x => x.CustomerId).IsRequired(true);
        builder.Property(x => x.ContactType).IsRequired(true).HasMaxLength(10);
        builder.Property(x => x.Information).IsRequired(true).HasMaxLength(100);
        builder.Property(x => x.IsDefault).IsRequired(true).HasDefaultValue(false);

        builder.HasIndex(x => x.CustomerId);
        builder.HasIndex(x => new { x.Information, x.ContactType }).IsUnique(true);
        //birden fazla kolonu indexleyip kombine ederken new {} içine yazarak kombine edilebiliyor
    }
}