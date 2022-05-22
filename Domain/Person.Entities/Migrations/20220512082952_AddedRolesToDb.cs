using Microsoft.EntityFrameworkCore.Migrations;

namespace Persons.Entities.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17789cf8-1026-4e31-b1a4-1d124d8db7a8", "6db14bfa-fd86-4f98-bff6-61e0f66e9a0f", "Employee", "EM" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff140e88-0284-425d-9bf2-a3a34678cf95", "25f7a2bf-baef-4021-9bc0-dcf2a30496e3", "Sales Person", "SP" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "923f45bb-773c-4c5a-9b33-4797d47dd659", "ac2cc384-0464-46f2-9fde-3a16f76e1bef", "Individual Customer", "IN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51620088-d468-4eb4-b4d5-7bfa8baeba35", "3693bcde-91fa-4cc2-9def-bbeaedcedfe0", "Store Contact", "SC" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ddb37cba-6dad-4cb8-9952-9fdd6ff7db7f", "27aa7e79-0188-468c-86fd-03c9e197266a", "Vendor Contact", "VC" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3868cb19-bdfb-4ae7-bd21-38c62c6f4870", "ef0cd33c-0ec6-4742-8c2a-70ec6823b276", "General Contact", "GC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17789cf8-1026-4e31-b1a4-1d124d8db7a8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3868cb19-bdfb-4ae7-bd21-38c62c6f4870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51620088-d468-4eb4-b4d5-7bfa8baeba35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "923f45bb-773c-4c5a-9b33-4797d47dd659");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddb37cba-6dad-4cb8-9952-9fdd6ff7db7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff140e88-0284-425d-9bf2-a3a34678cf95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da35697a-0d6a-4ff2-9023-dfd0950568f7", "3989dee1-bd11-4b10-af19-8588e5424c75", "EM", "Employee" },
                    { "6f6d4080-3beb-4050-89a2-ef28d409a086", "bc3b4aaa-4e61-4f2a-91ec-9962436f2511", "SP", "Sales Person" },
                    { "bea42a2a-ccce-48cf-ae48-f4d4d211e882", "4eb242be-fe2f-423d-b5d4-2034729a1320", "IN", "Individual Customer" },
                    { "852b7d9c-697c-444a-89bd-e0557daaeed6", "0bb833a8-cb2f-40a7-b6ac-ab83496dd63a", "SC", "Store Contact" },
                    { "5d3f1757-f49f-4fff-bc05-7692b2220059", "580ffbe7-27fe-4a6d-96e5-b412ce494998", "VC", "Vendor Contact" },
                    { "423c78c8-206d-4a5b-881d-065c2862b112", "77b80645-3993-4e7d-a34c-3d456322b9ad", "GC", "General Contact" }
                });
        }
    }
}
