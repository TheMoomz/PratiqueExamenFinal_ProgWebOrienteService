using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalServeur.Migrations
{
    /// <inheritdoc />
    public partial class seedNewUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MimeType",
                table: "Picture",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Picture",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "459c1d12-9c29-40b9-81c0-e7082baa20ef", "AQAAAAIAAYagAAAAEHTGUadh4s0/CV8ShxKYrbMZkEUGhd535URtHY3K6tIgHpwGkpD8Cwa3AJbxT2lTmw==", "76dbb116-5508-4110-90e1-0847c59aeaf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b30a36b-2a1f-445c-ab17-a8b65ef98315", "AQAAAAIAAYagAAAAEI8xsOCCdW3DbPLFUqVTyS1gjIpm17F9DNPHjmYI46FqWpYyWQs95N8/VT5eLIz0oQ==", "11b59b13-f1ef-48a3-a7d7-c098104c44ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6d219a6-d51f-44f6-a4ac-83511a03e8c2", "AQAAAAIAAYagAAAAEO41b8VK+OXl+5ZpAHxVygEXpBheElQxYXfmsqsKY6J43OjjIh5s7NM4UzUUCJoO/A==", "78b4f07f-0e29-402f-9904-061ce8acfb1e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "11111111-1111-1111-1111-111111111114", 0, "3d41ea38-de90-436b-b80b-c3ac99131894", "m@m.m", false, false, null, "M@M.M", "MARC", null, null, false, "30e628b3-3484-4454-ae06-3dc4d29ef08c", false, "Marc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111114");

            migrationBuilder.AlterColumn<string>(
                name: "MimeType",
                table: "Picture",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "Picture",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "463b1a1a-0340-4206-8f2e-ebf901a99267", "AQAAAAEAACcQAAAAEFHoOBMDwcOQer02gdczcpq4hkAF+Es914XXr7swRMaZLuHKjd2yqe3Nw/0lQ9hGng==", "81300e7e-a01b-40f5-9641-f88e02372671" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faf82f9f-7dba-482a-8667-cdf2a5bf87bb", "AQAAAAEAACcQAAAAELpX5bVqds+iuTT64NUYpZraWMEwewL0OzI5thd9Vq1Cvaz0N4ivK9AvlZCv/v+m9Q==", "56f8e726-04e8-4a81-858c-0f000d10c7df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "329cbf8c-df8a-428f-9859-34acdbc2ecbb", "AQAAAAEAACcQAAAAEBDNUV4/TL/8PmS2Qpp5UH8Y7wjsS6misJiUkvdVD1gvTWVJKU06jYMpYxJS77l60Q==", "22067a43-96ca-4075-94ed-3fd2fb2fabfd" });
        }
    }
}
