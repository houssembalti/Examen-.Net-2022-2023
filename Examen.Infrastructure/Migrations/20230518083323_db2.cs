using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RDVS",
                table: "RDVS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RDVS",
                table: "RDVS",
                columns: new[] { "PrestationFK", "ClientFK", "DateRDv" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RDVS",
                table: "RDVS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RDVS",
                table: "RDVS",
                columns: new[] { "PrestationFK", "ClientFK" });
        }
    }
}
