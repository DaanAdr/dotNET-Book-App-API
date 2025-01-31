using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Pages", "PublishDate", "ReaderAgeId", "Title" },
                values: new object[,]
                {
                    { new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"), 328, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"), "Nineteen Eighty-Four" },
                    { new Guid("29700f2e-bfb5-4441-9497-517ae383c403"), 508, new DateTime(2010, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Closer" },
                    { new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"), 443, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Spiral" },
                    { new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"), 577, new DateTime(2009, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Freefall" },
                    { new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"), 655, new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Deeper" },
                    { new Guid("7f286225-210d-4f5a-b34e-b272a642f285"), 464, new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Tunnels" },
                    { new Guid("a60c9e93-ed11-42da-933b-2a866171ee9a"), 402, new DateTime(2013, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Terminal" },
                    { new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182"), 253, new DateTime(1950, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"), "I, Robot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29700f2e-bfb5-4441-9497-517ae383c403"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7f286225-210d-4f5a-b34e-b272a642f285"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a60c9e93-ed11-42da-933b-2a866171ee9a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182"));
        }
    }
}
