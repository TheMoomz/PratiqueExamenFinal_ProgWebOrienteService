using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalServeur.Migrations
{
    /// <inheritdoc />
    public partial class seedPasswrd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5327c04f-8a30-432e-9efa-278cdf69afed", "AQAAAAIAAYagAAAAEAka4aYD53rPVW3ck3uf8rm65iyCP7LL1Gr2w2Jxv0wk0Kbz0epWlay6y6Eo8mnZvQ==", "c97ceb7b-4ef1-423b-b280-e0e365cb357c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2525f7cc-1cdf-4a8e-aa89-30dad00e1dc4", "AQAAAAIAAYagAAAAEOagZPJjU7nvVzYFnFceYBVp4/E//FisO0g+PI1eGmp9yJU4HfOsuoOaLxj5PM9T9Q==", "e2511565-cafd-4f9d-8ce5-84fdad51cc63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c2fc218-ab55-4274-aef4-052adbee59e0", "AQAAAAIAAYagAAAAEGF+8Aat/i3zHnEvYjiUVYVYa9BbVV19VxUwVHY5sJgZso3MDWAkUcFo3UR4JgK1Aw==", "15b814bc-ec29-4cfd-adb3-e7928ddd2dc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02fcbdca-10b8-4e37-973b-e62a1276848d", "AQAAAAIAAYagAAAAEPMOqYWvWbxXGCjvPDSILYpmGSB0QK60zHmgAN3p8wfeDMJ8SF713/uLv+wXVb/q1Q==", "c8641ce7-95b4-481c-903e-ac15c5b92b93" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111114",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d41ea38-de90-436b-b80b-c3ac99131894", null, "30e628b3-3484-4454-ae06-3dc4d29ef08c" });
        }
    }
}
