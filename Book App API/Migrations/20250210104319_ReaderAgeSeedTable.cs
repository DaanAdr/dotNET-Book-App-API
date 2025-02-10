using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class ReaderAgeSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReaderAges",
                columns: new[] { "Id", "AgeRange" },
                values: new object[,]
                {
                    { 1, "Picture Books (Ages 0-5)" },
                    { 2, "Early Readers (Ages 5-7)" },
                    { 3, "Chapter Books (Ages 7-9)" },
                    { 4, "Middle Grade (Ages 8-12)" },
                    { 5, "Young Adult (YA) (Ages 12-18)" },
                    { 6, "Adult (Ages 18+)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
