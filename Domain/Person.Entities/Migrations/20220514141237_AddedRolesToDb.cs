using Microsoft.EntityFrameworkCore.Migrations;

namespace Persons.Entities.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a8ec5a5-1d46-4fdd-b86e-017f132b43a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ecb5fd2-617e-49d0-a3e1-961834e70caf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5fed81c-09da-470e-aec0-2bcecd6a3bb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2bb71df-1002-4d48-8c30-b60f3b093867");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db955b81-bcec-4f83-85ae-baf1a8dc8abd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5fec672-5a41-40a9-bdf2-7175addee065");*/

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
                keyValue: "2d049515-84b1-4201-8143-3da0fd770875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5112995b-c5e0-40ac-9b5b-f2eb394a4e65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6220eb29-bc07-4ccd-ac49-1c0caf416c2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb19e457-7cb2-4da8-a374-258fe38fce23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df08ff8e-356b-418e-bc1e-f0f56f0d2376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df95bb5e-e932-4c38-b0c0-c9e522ce4992");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e5fec672-5a41-40a9-bdf2-7175addee065", "03a1ff33-f28d-421b-b098-4a9c389f653d", "EM", "Employee" },
                    { "0a8ec5a5-1d46-4fdd-b86e-017f132b43a6", "f6f568a5-fe89-41fc-aaa3-4a317d5c26c1", "SP", "Sales Person" },
                    { "2ecb5fd2-617e-49d0-a3e1-961834e70caf", "c373c28f-223b-40a1-b774-3d093dd8ddef", "IN", "Individual Customer" },
                    { "a5fed81c-09da-470e-aec0-2bcecd6a3bb4", "3e8c102f-ff4e-4068-809d-2ed2ad54b9a6", "SC", "Store Contact" },
                    { "db955b81-bcec-4f83-85ae-baf1a8dc8abd", "af274ea3-a0c7-4ceb-9e41-b44c6d37eea0", "VC", "Vendor Contact" },
                    { "b2bb71df-1002-4d48-8c30-b60f3b093867", "5397fd9e-92a8-468b-9f48-71034209fe95", "GC", "General Contact" }
                });
        }
    }
}
