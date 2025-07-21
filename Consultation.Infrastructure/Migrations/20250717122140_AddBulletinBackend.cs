using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultation.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddBulletinBackend : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Bulletin",
                newName: "FileCount");

            migrationBuilder.RenameColumn(
                name: "Notify",
                table: "Bulletin",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Bulletin",
                newName: "Author");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Bulletin",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Bulletin");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Bulletin",
                newName: "Notify");

            migrationBuilder.RenameColumn(
                name: "FileCount",
                table: "Bulletin",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Bulletin",
                newName: "ImageURL");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0A52E15B-95E6-40FE-9110-9A44817BFF39",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENhOziLJgeq9CatDfgL1qoocfnbCa1YZc0JesLGjI5VSbk1bfnQJywwUcYNQosQdhQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1226920F-9508-44B3-845A-ABABBBCBCF5D",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPmRNerKzv7/4Hyqcez0BtVfYCiDHEmFdfNg1RIj/rKilp7FNNU0tLz5dz0RkAa1Fg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273F528F-5330-411F-9C6B-01543D6249C3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELbKsQKa34fI17GQ/jJSlxKsnWaOTsfxI1L3FjJmbeAYyhkNIcaSTW0vSELQuxKayw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53D8F920-EBEC-4DF3-8C53-21F6D123F0D9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEMco9RI7YneDKQgKXqyAAs1YwQAWlSqbbzmAjjeytt/lhwpxzkPYTKZA/MwUsukURA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59CF8531-68E4-466B-BAEC-45305FE16A14",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEIM4Cf2wY7mLd5Gmtk8L7hKRAH3PUPY5iRW9kWGVGOEvT19EuJZA14cgRVh94CY1HQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6B187E9D-FD71-4F1D-AFDF-EA1D91E818EF",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAoez450Xh/EVhdpQASC9VyC347ESWzcZoZtddx9gQ2+5AFwR3E9FpjhU+PZIMwEfA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78B4AF2A-672F-43C5-B819-5F0B407B7187",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGtTUIDHRvyM65WP9RtBFMQT8WqFwUTyd6SSxKqIFTrkGcv6aVUgTLrs6IZt32ghjA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D0B26692-E380-4374-985F-239B56D06C20",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBLnDh2Jcs+tEmJmQUDV3QxMQW58smNxPn/W9x8yNjb0kujB7vU12310qvaK3hYmdA==");
        }
    }
}
