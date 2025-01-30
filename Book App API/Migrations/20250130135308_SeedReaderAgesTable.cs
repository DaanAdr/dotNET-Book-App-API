using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedReaderAgesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReaderAges",
                columns: new[] { "Id", "AgeRange" },
                values: new object[,]
                {
                    { new Guid("1c09c0dc-946b-412c-82f5-a877cc383bf2"), "Chapter Books (Ages 7-9)" },
                    { new Guid("6e7f81e0-74f2-4706-9e6f-d891007877fc"), "Middle Grade (Ages 8-12)" },
                    { new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"), "Adult (Ages 18+)" },
                    { new Guid("7bb41b2d-f163-4604-bd7a-e15ae0d9fbfe"), "Early Readers (Ages 5-7)" },
                    { new Guid("ba9cc1c4-fc08-4ded-a5fd-289f4748cec0"), "Picture Books (Ages 0-5)" },
                    { new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), "Young Adult (YA) (Ages 12-18)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("1c09c0dc-946b-412c-82f5-a877cc383bf2"));

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("6e7f81e0-74f2-4706-9e6f-d891007877fc"));

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("729ca0c2-2b61-45e5-82c7-78b6680bdd31"));

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("7bb41b2d-f163-4604-bd7a-e15ae0d9fbfe"));

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("ba9cc1c4-fc08-4ded-a5fd-289f4748cec0"));

            migrationBuilder.DeleteData(
                table: "ReaderAges",
                keyColumn: "Id",
                keyValue: new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"));
        }
    }
}
