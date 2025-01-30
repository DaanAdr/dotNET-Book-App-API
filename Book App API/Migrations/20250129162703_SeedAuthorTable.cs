using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedAuthorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Firstname", "Surname" },
                values: new object[,]
                {
                    { new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), "Roderick", "Gordon" },
                    { new Guid("2d8cef7c-551b-489c-b0b4-312f4b02aa4d"), "Joanne", "Rowling" },
                    { new Guid("40a18991-7508-40d2-8cef-e4b2b6a16d1f"), "Jane", "Austen" },
                    { new Guid("451bd4fc-5bf0-4485-858d-bbf351274b8a"), "Mark", "Twain" },
                    { new Guid("672c53eb-118c-4d82-b66b-1fd4dccf2cbe"), "Ernest", "Hemingway" },
                    { new Guid("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"), "George", "Orwell" },
                    { new Guid("c3b56ffd-b51d-431e-8120-5391f86d2b9b"), "Brandon", "Sanderson" },
                    { new Guid("c48a135d-670c-472d-be24-ee678ac2003f"), "Harper", "Lee" },
                    { new Guid("cc4ce597-ae78-4180-a1ed-68dd94b7566d"), "Isaac", "Asimov" },
                    { new Guid("d7a19b30-cd0b-4292-a6f7-1dafe478df02"), "Carlos", "Ruiz Zafón" },
                    { new Guid("f7d3c8b7-bb04-44ea-84c6-b9682ec1ea35"), "F. Scott", "Fitzgerald" },
                    { new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), "Brian", "Williams" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("2d8cef7c-551b-489c-b0b4-312f4b02aa4d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("40a18991-7508-40d2-8cef-e4b2b6a16d1f"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("451bd4fc-5bf0-4485-858d-bbf351274b8a"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("672c53eb-118c-4d82-b66b-1fd4dccf2cbe"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("c3b56ffd-b51d-431e-8120-5391f86d2b9b"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("c48a135d-670c-472d-be24-ee678ac2003f"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("cc4ce597-ae78-4180-a1ed-68dd94b7566d"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("d7a19b30-cd0b-4292-a6f7-1dafe478df02"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("f7d3c8b7-bb04-44ea-84c6-b9682ec1ea35"));

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"));
        }
    }
}
