using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addednewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKsWfn9+J7/2DKuz9tpP/Z4vxlI3wAevpPWV1B8oyGPEW4IQrnTD1zW4QtD5Bi0ecw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPPcQFCKgfErUQGHYgU+8wIYsIy43sqkYEFGW3tKNfOrkTkUky1UAzghDyLoLabM7g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPadbQbC/CPM765Eq/j/plxaQTRYbHG6qjLaOXyrhnnzgF6imqxfyeew4rp31iFgEA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFID+CCvMYhpeQ0ko29erRRyGNCO0iX4GqjV/bVl5RzdmF/vwiITgDZ/BkftafkUjA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIQDpooI0MtLwv0nWa4KT2nFJq/NGivcvHHpa/z/3r1EsKJRMKFCFe5hmzopWsU5Rg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC7vYoOt8wWQXH0K7W1MI8qZg4HRoN6PB5IwfZxNx2dm1i4a2d39Kyid16kOD3SXVw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFa9zOhCvAcALOVpFOUceV9Uqk8PAahfhzGhQv62WlDJjorS2ax7oWu55cnbSao8Cg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAF0fPvaV+OVjqy8n5BnildecyLI3YCXMQqjgajLF8yWsWeb8G+7os9ZyK0hNF8EAw==");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UMID", "UserName", "UserType" },
                values: new object[] { "D81B4D15-B3CD-47D5-96B0-44EF8E39E538", 0, "8d3ef0d9-b045-4b8f-a18f-15f2cbfa219b", "AdminAdmin", true, false, null, "ADMINADMIN", "ADMIN ADMIN", "AQAAAAIAAYagAAAAEGlWDK4gdOxb+Nb1GeZHgQthVLsQbk6NnpkfGl+SwKTX1O1yl2K9TN84MR2JEScNag==", null, false, "5a54c967-0b1f-4c38-bda7-5f94e4c1a3f4", false, "54321", "Admin Admin", 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D81B4D15-B3CD-47D5-96B0-44EF8E39E538");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJooLhPBWMuBCRYqIc4BewtJAkEbNLeqBgiu7cV4NL6JcDQJ9Iwc1Rm+kkgFWjotow==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKyLTLyPrEx4eSLbJxgVMJxkx45jrtsJJzHsZheEWoug4w/UTCIdYKMdV/vCEkYfBw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBVscVrnbETQEzEug+ZHSyKb718dAwNjpvnbFbbpXDOOLF1KUM68r8Z76i10ipq5Gw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAED+J9yAjrDs7TP47SJaeAPCiEDVUSnkEPYwEO1uHQP0jkwajt43Ba1bQ2/mJFxIGhg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH3ZrT8Pcw0i7AgrbZ+Vvb3J9nABysUI+f5KJ5N7KuZhDLKIjnLv6M52UyG31Xwhog==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDzQaRNixrNE53loy/f8gbI+r7eWANC5l8yvuaWeuWN1A/2XNhGfnKnlNCLzQ+MzPw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEEdN6078qF3SAUq/yDl4i7P3/3G7IL5ztA6cVNC1oBYEmctgklWBAnwuyDXXeJvmbA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELPV1r4YAoj278KzKRrZVDE/KZXOViuujxy7+AsY8xujjpwUaPfHIsf8B9l+ll7sIg==");
        }
    }
}
