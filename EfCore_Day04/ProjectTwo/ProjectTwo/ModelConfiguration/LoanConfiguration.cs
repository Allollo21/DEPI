using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTwo.Models;

namespace ProjectTwo.ModelConfiguration
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => new { l.BookId, l.BorrowerId, l.LoanDate });

            builder.Property(l => l.LoanDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(l => l.ReturnDate)
                .IsRequired(false);

            // Many-to-Many: Book to Borrower through Loan
            builder.HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(l => l.Borrower)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BorrowerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
