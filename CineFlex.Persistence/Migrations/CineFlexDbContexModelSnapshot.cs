﻿// <auto-generated />
using System;
using CineFlex.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CineFlex.Persistence.Migrations
{
    [DbContext(typeof(CineFlexDbContex))]
    partial class CineFlexDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CineFlex.Domain.CinemaEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactInformation = "0937363056",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "First location",
                            Name = "First name"
                        },
                        new
                        {
                            Id = 2,
                            ContactInformation = "0937363056",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Location = "second location",
                            Name = "second name"
                        });
                });

            modelBuilder.Entity("CineFlex.Domain.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ReleaseYear")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Trailer",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseYear = "1999",
                            Title = "Sample Movie"
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Sci Fi",
                            LastModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReleaseYear = "2022",
                            Title = "Sample Movie"
                        });
                });

            modelBuilder.Entity("CineFlex.Domain.Seats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Movie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RowNumber")
                        .HasColumnType("integer");

                    b.Property<string>("SeatDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SeatPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("SeatStatus")
                        .HasColumnType("integer");

                    b.Property<int>("SeatType")
                        .HasColumnType("integer");

                    b.Property<string>("cinemaEntity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Seats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2023, 5, 23, 11, 45, 35, 461, DateTimeKind.Local).AddTicks(9819),
                            Movie = "new movie",
                            RowNumber = 1,
                            SeatDescription = "description",
                            SeatPrice = 100m,
                            SeatStatus = 2,
                            SeatType = 1,
                            cinemaEntity = "new cinima"
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2023, 5, 23, 11, 45, 35, 461, DateTimeKind.Local).AddTicks(9840),
                            Movie = "new Movie()",
                            RowNumber = 1,
                            SeatDescription = "description",
                            SeatPrice = 100m,
                            SeatStatus = 2,
                            SeatType = 1,
                            cinemaEntity = "new CinemaEntity()"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}