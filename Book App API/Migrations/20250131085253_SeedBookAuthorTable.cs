using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Book_App_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedBookAuthorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { new Guid("0f69155e-9481-47b1-8ebd-8ddc97260c32"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("50dc71f8-2738-484f-a6cc-c1615e203517") },
                    { new Guid("1902008b-e2ea-463f-bdbb-fafc0257a12c"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833") },
                    { new Guid("2dc89b14-dacc-43be-85cc-184eaca40f68"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef") },
                    { new Guid("466e4a05-0e7c-4922-8356-77ae89aa4696"), new Guid("cc4ce597-ae78-4180-a1ed-68dd94b7566d"), new Guid("f0a778ad-c4e1-4b25-b85a-93a104c88182") },
                    { new Guid("5159bc11-ea6f-41d4-a6cb-6a87ae04da48"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1") },
                    { new Guid("5f35c608-b3fe-4d7e-bc39-ae18103bd52a"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("7b05a2f6-6606-4d6a-ba67-759097a75ed1") },
                    { new Guid("6c0d69a1-bcc7-48aa-98d1-ad0fa42c6eed"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("29700f2e-bfb5-4441-9497-517ae383c403") },
                    { new Guid("97c64e37-307d-40ab-9668-924c18f669d3"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("e4a6087f-f8c0-473e-8abe-2abeba324833") },
                    { new Guid("9a3c0b15-0da5-4467-b934-7a59b66eeccb"), new Guid("82b4c82e-23ff-4fbd-b9c4-1220990dafd4"), new Guid("0787e8cb-bdd6-43b1-91ea-1c4b2237fab9") },
                    { new Guid("bd50453c-74f1-4914-90a9-a66c6aa241e6"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("2a8579aa-8a88-468f-92f0-feda72a621ef") },
                    { new Guid("d9bdbc7f-9e4f-4fce-8e61-ebfbd537fdbc"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("29700f2e-bfb5-4441-9497-517ae383c403") },
                    { new Guid("f7d0dc28-f16c-4dd6-9322-dbdafafa967d"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("7f286225-210d-4f5a-b34e-b272a642f285") },
                    { new Guid("f8c7e27d-7f68-4907-9094-fdb8385be436"), new Guid("0f14ebe0-ae44-49ae-b412-796d8ed108a8"), new Guid("50dc71f8-2738-484f-a6cc-c1615e203517") },
                    { new Guid("fdafe8de-64eb-4567-806d-b15cdab4289b"), new Guid("fbbb4392-3c14-4625-9449-fa7e19fdf565"), new Guid("7f286225-210d-4f5a-b34e-b272a642f285") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("0f69155e-9481-47b1-8ebd-8ddc97260c32"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("1902008b-e2ea-463f-bdbb-fafc0257a12c"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("2dc89b14-dacc-43be-85cc-184eaca40f68"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("466e4a05-0e7c-4922-8356-77ae89aa4696"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5159bc11-ea6f-41d4-a6cb-6a87ae04da48"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("5f35c608-b3fe-4d7e-bc39-ae18103bd52a"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("6c0d69a1-bcc7-48aa-98d1-ad0fa42c6eed"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("97c64e37-307d-40ab-9668-924c18f669d3"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("9a3c0b15-0da5-4467-b934-7a59b66eeccb"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("bd50453c-74f1-4914-90a9-a66c6aa241e6"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("d9bdbc7f-9e4f-4fce-8e61-ebfbd537fdbc"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f7d0dc28-f16c-4dd6-9322-dbdafafa967d"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("f8c7e27d-7f68-4907-9094-fdb8385be436"));

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: new Guid("fdafe8de-64eb-4567-806d-b15cdab4289b"));
        }
    }
}
