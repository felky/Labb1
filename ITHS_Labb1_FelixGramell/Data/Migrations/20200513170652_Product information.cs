using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_Labb1_FelixGramell.Data.Migrations
{
    public partial class Productinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductInformation",
                columns: table => new
                {
                    Keyboard_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Switches = table.Column<string>(nullable: true),
                    Layout = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInformation", x => x.Keyboard_Id);
                });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Keyboard_Id", "Language", "Layout", "Size", "Switches" },
                values: new object[] { 1, "US", "ANSI", 60, "MX Blues" });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Keyboard_Id", "Language", "Layout", "Size", "Switches" },
                values: new object[] { 2, "US", "ANSI", 60, "Gateron Black" });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Keyboard_Id", "Language", "Layout", "Size", "Switches" },
                values: new object[] { 3, "US", "ANSI", 40, "Holy Pandas" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductInformation");
        }
    }
}
