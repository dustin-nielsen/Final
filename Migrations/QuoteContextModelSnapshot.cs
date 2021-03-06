// <auto-generated />
using Final.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final.Migrations
{
    [DbContext(typeof(QuoteContext))]
    partial class QuoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("Final.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("QuoteText")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            Author = "Virgil",
                            Citation = "(Virgil, 151)",
                            Date = "151 AD",
                            QuoteText = "Fortune favors the bold",
                            Subject = "Bravery"
                        },
                        new
                        {
                            QuoteId = 2,
                            Author = "Mahatma Gandhi",
                            Citation = "(Gandhi, 1989)",
                            Date = "30 July 1989",
                            QuoteText = "You must be the change you wish to see in the world",
                            Subject = "Change"
                        },
                        new
                        {
                            QuoteId = 3,
                            Author = "Alfred, Lord Tennyson",
                            Citation = "(In Memoriam A. H. H., Alfred)",
                            Date = "1850",
                            QuoteText = "Tis better to have loved and lost than to have never loved at all",
                            Subject = "Love"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
