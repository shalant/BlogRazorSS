using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class Addingnormalizedusername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79223ca5-9a6b-4254-9cf8-5857390521f9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83b07c1-c0bd-4b1d-923d-b85f189c916b", "SUPERADMIN@BLOGGIE.COM", "SUPERADMIN@BLOGGIE.COM", "AQAAAAEAACcQAAAAEKU5gliJCNx8eKXpdWiP+JlrWEche5u6XnV9fBJgWvPkZQKlSnwA+YdbrOcpCe/Nww==", "44e7dee7-3b7b-4c80-884a-c9f9854cd923" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79223ca5-9a6b-4254-9cf8-5857390521f9",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dc90131-16cd-491b-8436-48e2852a6199", null, null, "AQAAAAEAACcQAAAAEMGsN4lina8InGU+z8FfOLf3jtls80BQoL6CrGUPA8u4GDKYo0oCxbQp93oe+bKheQ==", "5a1f35d1-811c-439e-b68f-11b6ed6e062a" });
        }
    }
}
