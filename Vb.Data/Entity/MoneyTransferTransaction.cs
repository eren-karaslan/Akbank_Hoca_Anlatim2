using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Vb.Base.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vb.Data.Entity;

[Table("MoneyTransferTransaction", Schema = "dbo")]
public class MoneyTransferTransaction : BaseEntity
{
    public int FromAccountId { get; set; }
    public virtual Account FromAccount { get; set; }

    public int ToAccountId { get; set; }
    public virtual Account ToAccount { get; set; }

    public string ReferenceNumber { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public string TransferType { get; set; }
}


public class MoneyTransferTransactionConfiguration : IEntityTypeConfiguration<MoneyTransferTransaction>
{
    public void Configure(EntityTypeBuilder<MoneyTransferTransaction> builder)
    {
        // BaseEntity'den gelen standart alanlar
        builder.Property(x => x.InsertDate).IsRequired(true);
        builder.Property(x => x.InsertUserId).IsRequired(true);
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.UpdateUserId).IsRequired(false);
        builder.Property(x => x.IsActive).IsRequired(true).HasDefaultValue(true);

        // Transaction'a özel alanlar
        builder.Property(x => x.FromAccountId).IsRequired(true);
        builder.Property(x => x.ToAccountId).IsRequired(true);
        builder.Property(x => x.TransactionDate).IsRequired(true);
        builder.Property(x => x.Amount).IsRequired(true).HasPrecision(18, 4);
        builder.Property(x => x.Description).IsRequired(false).HasMaxLength(300);
        builder.Property(x => x.TransferType).IsRequired(true).HasMaxLength(10);
        builder.Property(x => x.ReferenceNumber).IsRequired(true).HasMaxLength(50);

        builder.HasIndex(x => x.ReferenceNumber);

    }
}