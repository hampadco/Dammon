using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dammon.Migrations
{
    /// <inheritdoc />
    public partial class Accuont : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeGroup = table.Column<double>(type: "float", nullable: false),
                    TitleGroup = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CodeTotal = table.Column<double>(type: "float", nullable: false),
                    TitleTotal = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    CodeMoin = table.Column<double>(type: "float", nullable: false),
                    TitleMoin = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Nature = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    Account_type = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
