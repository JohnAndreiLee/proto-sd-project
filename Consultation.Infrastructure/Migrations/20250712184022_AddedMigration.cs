using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMh5h8t2+NQPSrFpnygxusyXQafru4pr4d5/4tU8FuA5h2UlcP2EMdstc1BIF+e8OA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENj4Xus0c4Wa/NbtvQgF6g0ETvgsi6ndRbJ7H78m9WjPyV8kcJQFnq2/BPMhEzFy0g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM+3rlPn7HPh9PNix/9B/QDno5Lk2eNH2oRDkX28e1hafXZOHb6ejbNQMVpEeG5eKg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGKZ3Ghfsz9XR/41QAzO+tFY1BVf11jgTxvPksSSco9WuO7xCP4nfkOl0J9REXGi6w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKKM5bsEwaWxqowtdAKxz4A0S5A33vdnb92myEXE7cWIHnfY/hdPkwXz2PRYi3nghA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBsffiZoxIFgbwwUWY9VH90gh//dN3BjCCMtSZ962p1HgTuovVrsXGS/6JnLIWtAqA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIG5jButwoJ4JYY+4qNfa5qxkFZGPY6GQfJ75BlTwCeGgWTJyosYMMIp8oKd60fYeQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL939oWFDMN8AEltpkM5juLwhNityo0qCh3Lkn/UBHsnWuV+GCfBFMubT1yh750DZA==");
        }
    }
}
