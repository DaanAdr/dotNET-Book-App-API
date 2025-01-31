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

            modelBuilder.Entity("Book_App_API.Domain.Entity.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReaderAgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f286225-210d-4f5a-b34e-b272a642f285"),
                            Pages = 464,
                            PublishDate = new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Tunnels"
                        },
                        new
                        {
                            Id = new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"),
                            Pages = 655,
                            PublishDate = new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Deeper"
                        },
                        new
                        {
                            Id = new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"),
                            Pages = 577,
                            PublishDate = new DateTime(2009, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Freefall"
                        },
                        new
                        {
                            Id = new Guid("29700f2e-bfb5-4441-9497-517ae383c403"),
                            Pages = 508,
                            PublishDate = new DateTime(2010, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Closer"
                        },
                        new
                        {
                            Id = new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"),
                            Pages = 443,
                            PublishDate = new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Spiral"
                        },
                        new
                        {
                            Id = new Guid("a60c9e93-ed11-42da-933b-2a866171ee9a"),
                            Pages = 402,
                            PublishDate = new DateTime(2013, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            Title = "Terminal"
                        },
                        new
                        {
                            Id = new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"),
                            Pages = 328,
                            PublishDate = new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"),
                            Title = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182"),
                            Pages = 253,
                            PublishDate = new DateTime(1950, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReaderAgeId = new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"),
                            Title = "I, Robot"
                        });
                });

            modelBuilder.Entity("Book_App_API.Domain.Entity.BookAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f7d0dc28-f16c-4dd6-9322-dbdafafa967d"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("7f286225-210d-4f5a-b34e-b272a642f285")
                        },
                        new
                        {
                            Id = new Guid("fdafe8de-64eb-4567-806d-b15cdab4289b"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("7f286225-210d-4f5a-b34e-b272a642f285")
                        },
                        new
                        {
                            Id = new Guid("5f35c608-b3fe-4d7e-bc39-ae18103bd52a"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1")
                        },
                        new
                        {
                            Id = new Guid("5159bc11-ea6f-41d4-a6cb-6a87ae04da48"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1")
                        },
                        new
                        {
                            Id = new Guid("f8c7e27d-7f68-4907-9094-fdb8385be436"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("50dc71f8-2738-484f-a6cc-c1615e203517")
                        },
                        new
                        {
                            Id = new Guid("0f69155e-9481-47b1-8ebd-8ddc97260c32"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("50dc71f8-2738-484f-a6cc-c1615e203517")
                        },
                        new
                        {
                            Id = new Guid("d9bdbc7f-9e4f-4fce-8e61-ebfbd537fdbc"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("29700f2e-bfb5-4441-9497-517ae383c403")
                        },
                        new
                        {
                            Id = new Guid("6c0d69a1-bcc7-48aa-98d1-ad0fa42c6eed"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("29700f2e-bfb5-4441-9497-517ae383c403")
                        },
                        new
                        {
                            Id = new Guid("2dc89b14-dacc-43be-85cc-184eaca40f68"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef")
                        },
                        new
                        {
                            Id = new Guid("bd50453c-74f1-4914-90a9-a66c6aa241e6"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef")
                        },
                        new
                        {
                            Id = new Guid("1902008b-e2ea-463f-bdbb-fafc0257a12c"),
                            AuthorId = new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"),
                            BookId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833")
                        },
                        new
                        {
                            Id = new Guid("97c64e37-307d-40ab-9668-924c18f669d3"),
                            AuthorId = new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"),
                            BookId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833")
                        },
                        new
                        {
                            Id = new Guid("9a3c0b15-0da5-4467-b934-7a59b66eeccb"),
                            AuthorId = new Guid("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"),
                            BookId = new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9")
                        },
                        new
                        {
                            Id = new Guid("466e4a05-0e7c-4922-8356-77ae89aa4696"),
                            AuthorId = new Guid("cc4ce597-ae78-4180-a1ed-68dd94b7566d"),
                            BookId = new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182")
                        });
                });

            modelBuilder.Entity("Book_App_API.Domain.Entity.BookGenre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("BookGenres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("059a8bce-3ebe-41dc-97fb-3ebabab72f58"),
                            BookId = new Guid("7f286225-210d-4f5a-b34e-b272a642f285"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("d1788eac-54ea-4e46-bd94-d4837df891b2"),
                            BookId = new Guid("7f286225-210d-4f5a-b34e-b272a642f285"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("de7c3a6d-24fc-4f17-8278-1b486c954a9e"),
                            BookId = new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("e300d359-efd8-4bf3-97cd-eb796b26630c"),
                            BookId = new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("2722c800-811c-40f0-a51f-5d398bbabf18"),
                            BookId = new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("ec0c213a-0fff-4f55-a0c4-76cf364e4e89"),
                            BookId = new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("65e6179b-ffe8-44c7-ae55-0f436c9c880e"),
                            BookId = new Guid("29700f2e-bfb5-4441-9497-517ae383c403"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("4bd61133-f76b-49c9-9502-b31a68ccc237"),
                            BookId = new Guid("29700f2e-bfb5-4441-9497-517ae383c403"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("57dff9b8-204a-48d7-8457-0ecbddd379cb"),
                            BookId = new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("77628f88-67a8-4b7a-af07-dd8b1b709f76"),
                            BookId = new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("bddbd5ee-4506-40f1-a3a1-7e7f7fc0c5f2"),
                            BookId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            GenreId = new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479")
                        },
                        new
                        {
                            Id = new Guid("0e1acd54-aac7-415a-8a23-f088d87c9094"),
                            BookId = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("9a01e76b-102c-464c-a8d8-6435c5bda08f"),
                            BookId = new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
                        },
                        new
                        {
                            Id = new Guid("cab052f4-1ecb-4c01-a086-50a213e5f065"),
                            BookId = new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"),
                            GenreId = new Guid("57a1d08a-39f7-4cdb-85e0-20811f714bcb")
                        },
                        new
                        {
                            Id = new Guid("af97b263-1dc0-45a8-b462-94c94ae223ca"),
                            BookId = new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182"),
                            GenreId = new Guid("7369fec7-9646-42b4-8266-bfce860e7ead")
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

            modelBuilder.Entity("Book_App_API.Domain.Entity.ReaderAge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AgeRange")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReaderAges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba9cc1c4-fc08-4ded-a5fd-289f4748cec0"),
                            AgeRange = "Picture Books (Ages 0-5)"
                        },
                        new
                        {
                            Id = new Guid("7bb41b2d-f163-4604-bd7a-e15ae0d9fbfe"),
                            AgeRange = "Early Readers (Ages 5-7)"
                        },
                        new
                        {
                            Id = new Guid("1c09c0dc-946b-412c-82f5-a877cc383bf2"),
                            AgeRange = "Chapter Books (Ages 7-9)"
                        },
                        new
                        {
                            Id = new Guid("6e7f81e0-74f2-4706-9e6f-d891007877fc"),
                            AgeRange = "Middle Grade (Ages 8-12)"
                        },
                        new
                        {
                            Id = new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"),
                            AgeRange = "Young Adult (YA) (Ages 12-18)"
                        },
                        new
                        {
                            Id = new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"),
                            AgeRange = "Adult (Ages 18+)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
