﻿// <auto-generated />
using System;
using Book_App_API.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book_App_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250129155936_AuthorTable")]
    partial class AuthorTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
