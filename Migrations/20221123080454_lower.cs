using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace @new.Migrations
{
    /// <inheritdoc />
    public partial class lower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Students",
                newName: "Id");
        }
    }
}
