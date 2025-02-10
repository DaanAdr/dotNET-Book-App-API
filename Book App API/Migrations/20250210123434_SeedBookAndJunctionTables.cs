using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookAndJunctionTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Pages", "PublishDate", "ReaderAgeId", "Title" },
                values: new object[,]
                {
                    { 1, 464, new DateTime(2007, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Tunnels" },
                    { 2, 655, new DateTime(2009, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Deeper" },
                    { 3, 577, new DateTime(2009, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Freefall" },
                    { 4, 508, new DateTime(2010, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Closer" },
                    { 5, 443, new DateTime(2011, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Spiral" },
                    { 6, 402, new DateTime(2013, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Terminal" },
                    { 7, 328, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Nineteen Eighty-Four" },
                    { 8, 253, new DateTime(1950, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "I, Robot" }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "AuthorId", "BookId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 2, 3 },
                    { 1, 3, 5 },
                    { 1, 4, 7 },
                    { 1, 5, 9 },
                    { 1, 6, 11 },
                    { 2, 1, 2 },
                    { 2, 2, 4 },
                    { 2, 3, 6 },
                    { 2, 4, 8 },
                    { 2, 5, 10 },
                    { 2, 6, 12 },
                    { 4, 7, 13 },
                    { 10, 8, 14 }
                });

            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "BookId", "GenreId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 3 },
                    { 3, 1, 5 },
                    { 4, 1, 7 },
                    { 5, 1, 9 },
                    { 6, 1, 11 },
                    { 1, 2, 2 },
                    { 2, 2, 4 },
                    { 3, 2, 6 },
                    { 4, 2, 8 },
                    { 5, 2, 10 },
                    { 6, 2, 12 },
                    { 7, 2, 14 },
                    { 8, 2, 15 },
                    { 7, 3, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { 10, 8 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumns: new[] { "BookId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
