using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { new Guid("0db4cd86-f853-4884-bd59-51b154272336"), "Action & Adventure" },
                    { new Guid("57a1d08a-39f7-4cdb-85e0-20811f714bcb"), "Dystopian" },
                    { new Guid("7369fec7-9646-42b4-8266-bfce860e7ead"), "Science Fiction" },
                    { new Guid("a4b21504-11de-430e-bcb7-70bda87975c2"), "Mystery" },
                    { new Guid("cc7b964c-167c-4fd7-ba0e-9dff9edc48c2"), "Horror" },
                    { new Guid("f54d72f0-508d-4d6c-a417-e24383f9ce1b"), "Romance" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0db4cd86-f853-4884-bd59-51b154272336"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("57a1d08a-39f7-4cdb-85e0-20811f714bcb"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7369fec7-9646-42b4-8266-bfce860e7ead"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("a4b21504-11de-430e-bcb7-70bda87975c2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cc7b964c-167c-4fd7-ba0e-9dff9edc48c2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f54d72f0-508d-4d6c-a417-e24383f9ce1b"));
        }
    }
}
