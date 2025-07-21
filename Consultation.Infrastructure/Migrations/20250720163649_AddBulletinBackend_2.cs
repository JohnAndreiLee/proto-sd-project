using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBulletinBackend_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bulletin",
                table: "Bulletin");

            migrationBuilder.RenameTable(
                name: "Bulletin",
                newName: "Bulletins");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Bulletins",
                newName: "Content");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bulletins",
                table: "Bulletins",
                column: "BulletinID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEB87mzTBRQct6yHyOjTYALu/BbnKJgTFNpl3VAu4CnIxDgrVXc0f2aVNtebpaw9r2Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMpCBUUnt4gH9bNl98wXytLzA/DPgkVuDTBkgg3MZ62aJedtL178npYY4NpWmAI8Mg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBt06Rb6GV/eAc9z/s3syGwEG4+QILDye1i9OoLqYS8v+XNsUxZKerYHcqAdDybiQg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENKf82Es280DIwyTOiQG60XOeXLyPsoelL4MKyKhM75KibfVhUZteKWk/Ox0agjZEQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPKlWWA8Espc8oTaGtTcyViC11gXFVxpb43P0E49gHl/rN+XSoHbGZ0HMd/c4CAttA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO2efGZ/nCndkFdvaK3vrs8pPqOnZVCHBUjaTw5bQRJ0SIZQDV+HbHauCCWXET13eA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJuVj0aBJ0ZHauCKWfKWpYSLZf8gjHZRYeQQk2L8oQxnSotsjr5IzG8pfGAss74lQg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECwBlR/5jO6JZD8wpsy/q8t9WZ8VRDQ2MGqE5abSCjLpyFZ8caIOSDx/UbjA28RjSg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Bulletins",
                table: "Bulletins");

            migrationBuilder.RenameTable(
                name: "Bulletins",
                newName: "Bulletin");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Bulletin",
                newName: "Description");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bulletin",
                table: "Bulletin",
                column: "BulletinID");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJRHc7Xh5qIVPFh0DePn/Tox0knJ7IlYA1LxQEqkIX5Qki2byx10kEigol9QBVum6w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEA2jcDa8dpefuUwHvYpw6ixKl3Sj7pRW/zzkl3LPY43NHWZfaRtTRptj1C+AMYk46Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPVOpJj3fQg4NxekyShWBUq7z4ZOMx7HJL+Jr3nFgtNW2phiQFRsjQM0xFYO9R5i8g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKPaOmd6c0x55ZfCkgQJo2KWbZjC+24G5q5k5emU4HHO6lSFvbp9qDDVDrfHpfWvcA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM5ixnXphzm9S0sRzns/8yte0H8E2vJLDJm3dlvDH0UOkYvJDAwwJZjZmBUwKaT76A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAxBvzzGQjlHHOA85iXM9vrapPDsDnq91DWDcYF7b4c7EIRoXHWLdLKL+OG0+ylKnA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEL9Ody0dgO4m4Zd0PxxxQW5dkTuiKtkZkJYhiybYsUlr/sj5UhdKnhMuimkuwb1fBQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGZOwG9I+EL9HLbn61Vu9qDUWxdfsprbEq4xAE0UmvQ0aW4TMrd0+b/9dKGOeko81w==");
        }
    }
}
