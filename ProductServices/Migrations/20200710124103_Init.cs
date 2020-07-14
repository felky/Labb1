using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductServices.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Img_Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

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
                table: "Product",
                columns: new[] { "Id", "Img_Url", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://preview.redd.it/9d69elb5ext41.png?width=1024&auto=webp&s=6c0a8defaaed5d5707e889b10cc1f5e527706b46", "Purple mechanical keyboard", 149.99000000000001 },
                    { 2, "https://preview.redd.it/cw9ax8o8fws41.png?width=1024&auto=webp&s=c78e19c619bfc72933084710a656f39b2f347eea", "Galaxy mechanical keyboard", 249.99000000000001 },
                    { 3, "https://preview.redd.it/z5p7t8t2fst41.png?width=1024&auto=webp&s=14090fd249c2bf94fd2a2d5e3c0701f13f635fe6", "Small grey and beige keyboard", 200.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInformation",
                columns: new[] { "Keyboard_Id", "Language", "Layout", "Size", "Switches" },
                values: new object[,]
                {
                    { 1, "US", "ANSI", 60, "MX Blues" },
                    { 2, "US", "ANSI", 60, "Gateron Black" },
                    { 3, "US", "ANSI", 40, "Holy Pandas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductInformation");
        }
    }
}
