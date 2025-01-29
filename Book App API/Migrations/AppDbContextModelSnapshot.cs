﻿// <auto-generated />
using System;
using Book_App_API.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book_App_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Book_App_API.Domain.Entity.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            Firstname = "Roderick",
                            Surname = "Gordon"
                        },
                        new
                        {
                            Id = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            Firstname = "Brian",
                            Surname = "Williams"
                        },
                        new
                        {
                            Id = new Guid("2d8cef7c-551b-489c-b0b4-312f4b02aa4d"),
                            Firstname = "Joanne",
                            Surname = "Rowling"
                        },
                        new
                        {
                            Id = new Guid("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"),
                            Firstname = "George",
                            Surname = "Orwell"
                        },
                        new
                        {
                            Id = new Guid("40a18991-7508-40d2-8cef-e4b2b6a16d1f"),
                            Firstname = "Jane",
                            Surname = "Austen"
                        },
                        new
                        {
                            Id = new Guid("451bd4fc-5bf0-4485-858d-bbf351274b8a"),
                            Firstname = "Mark",
                            Surname = "Twain"
                        },
                        new
                        {
                            Id = new Guid("f7d3c8b7-bb04-44ea-84c6-b9682ec1ea35"),
                            Firstname = "F. Scott",
                            Surname = "Fitzgerald"
                        },
                        new
                        {
                            Id = new Guid("672c53eb-118c-4d82-b66b-1fd4dccf2cbe"),
                            Firstname = "Ernest",
                            Surname = "Hemingway"
                        },
                        new
                        {
                            Id = new Guid("c48a135d-670c-472d-be24-ee678ac2003f"),
                            Firstname = "Harper",
                            Surname = "Lee"
                        },
                        new
                        {
                            Id = new Guid("cc4ce597-ae78-4180-a1ed-68dd94b7566d"),
                            Firstname = "Isaac",
                            Surname = "Asimov"
                        },
                        new
                        {
                            Id = new Guid("c3b56ffd-b51d-431e-8120-5391f86d2b9b"),
                            Firstname = "Brandon",
                            Surname = "Sanderson"
                        },
                        new
                        {
                            Id = new Guid("d7a19b30-cd0b-4292-a6f7-1dafe478df02"),
                            Firstname = "Carlos",
                            Surname = "Ruiz Zafón"
                        });
                });

            modelBuilder.Entity("Book_App_API.Domain.Entity.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead"),
                            GenreName = "Science Fiction"
                        },
                        new
                        {
                            Id = new Guid("57a1d08a-39f7-4cdb-85e0-20811f714bcb"),
                            GenreName = "Dystopian"
                        },
                        new
                        {
                            Id = new Guid("0db4cd86-f853-4884-bd59-51b154272336"),
                            GenreName = "Action & Adventure"
                        },
                        new
                        {
                            Id = new Guid("a4b21504-11de-430e-bcb7-70bda87975c2"),
                            GenreName = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("cc7b964c-167c-4fd7-ba0e-9dff9edc48c2"),
                            GenreName = "Horror"
                        },
                        new
                        {
                            Id = new Guid("f54d72f0-508d-4d6c-a417-e24383f9ce1b"),
                            GenreName = "Romance"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
