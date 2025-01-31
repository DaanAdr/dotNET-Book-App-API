using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookGenres",
                columns: new[] { "Id", "BookId", "GenreId" },
                values: new object[,]
                {
                    { new Guid("059a8bce-3ebe-41dc-97fb-3ebabab72f58"), new Guid("7f286225-210d-4f5a-b34e-b272a642f285"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("0e1acd54-aac7-415a-8a23-f088d87c9094"), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("2722c800-811c-40f0-a51f-5d398bbabf18"), new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("4bd61133-f76b-49c9-9502-b31a68ccc237"), new Guid("29700f2e-bfb5-4441-9497-517ae383c403"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("57dff9b8-204a-48d7-8457-0ecbddd379cb"), new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("65e6179b-ffe8-44c7-ae55-0f436c9c880e"), new Guid("29700f2e-bfb5-4441-9497-517ae383c403"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("77628f88-67a8-4b7a-af07-dd8b1b709f76"), new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("9a01e76b-102c-464c-a8d8-6435c5bda08f"), new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("af97b263-1dc0-45a8-b462-94c94ae223ca"), new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("bddbd5ee-4506-40f1-a3a1-7e7f7fc0c5f2"), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("cab052f4-1ecb-4c01-a086-50a213e5f065"), new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9"), new Guid("57a1d08a-39f7-4cdb-85e0-20811f714bcb") },
                    { new Guid("d1788eac-54ea-4e46-bd94-d4837df891b2"), new Guid("7f286225-210d-4f5a-b34e-b272a642f285"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("de7c3a6d-24fc-4f17-8278-1b486c954a9e"), new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479") },
                    { new Guid("e300d359-efd8-4bf3-97cd-eb796b26630c"), new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") },
                    { new Guid("ec0c213a-0fff-4f55-a0c4-76cf364e4e89"), new Guid("50dc71f8-2738-484f-a6cc-c1615e203517"), new Guid("7369fec7-9646-42b4-8266-bfce860e7ead") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("059a8bce-3ebe-41dc-97fb-3ebabab72f58"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("0e1acd54-aac7-415a-8a23-f088d87c9094"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("2722c800-811c-40f0-a51f-5d398bbabf18"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("4bd61133-f76b-49c9-9502-b31a68ccc237"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("57dff9b8-204a-48d7-8457-0ecbddd379cb"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("65e6179b-ffe8-44c7-ae55-0f436c9c880e"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("77628f88-67a8-4b7a-af07-dd8b1b709f76"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("9a01e76b-102c-464c-a8d8-6435c5bda08f"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("af97b263-1dc0-45a8-b462-94c94ae223ca"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("bddbd5ee-4506-40f1-a3a1-7e7f7fc0c5f2"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("cab052f4-1ecb-4c01-a086-50a213e5f065"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("d1788eac-54ea-4e46-bd94-d4837df891b2"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("de7c3a6d-24fc-4f17-8278-1b486c954a9e"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("e300d359-efd8-4bf3-97cd-eb796b26630c"));

            migrationBuilder.DeleteData(
                table: "BookGenres",
                keyColumn: "Id",
                keyValue: new Guid("ec0c213a-0fff-4f55-a0c4-76cf364e4e89"));
        }
    }
}
