using CineFlex.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineFlex.Persistence.Configurations.Entities
{
    public class BookingConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book {
                    Id = 1,
                    Cinima = "Cinima",
                    Movie = "New movie",
                    Seat = "New seat"
                },
                new Book
                {
                    Id = 2,
                    Cinima = "Cinima",
                    Movie = "New movie",
                    Seat = "New seat"
                }
                );
        }
    }
}
