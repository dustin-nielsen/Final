using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class QuoteContext : DbContext
    {
        //Constructor
        public QuoteContext (DbContextOptions<QuoteContext> options) : base(options)
        {

        }

        public DbSet<Quote> Quotes { get; set; }

        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quote>().HasData(

                new Quote
                {
                    QuoteId = 1,
                    QuoteText = "Fortune favors the bold",
                    Author = "Virgil",
                    Date = "151 AD",
                    Subject = "Bravery",
                    Citation = "(Virgil, 151)",
                },
                new Quote
                {
                    QuoteId = 2,
                    QuoteText = "You must be the change you wish to see in the world",
                    Author = "Mahatma Gandhi",
                    Date = "30 July 1989",
                    Subject = "Change",
                    Citation = "(Gandhi, 1989)",
                },
                new Quote
                {
                    QuoteId = 3,
                    QuoteText = "Tis better to have loved and lost than to have never loved at all",
                    Author = "Alfred, Lord Tennyson",
                    Date = "1850",
                    Subject = "Love",
                    Citation = "(In Memoriam A. H. H., Alfred)",
                }
            );
        }
    }
}
