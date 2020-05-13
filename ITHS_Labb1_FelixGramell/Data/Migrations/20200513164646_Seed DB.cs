using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_Labb1_FelixGramell.Data.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Img_Url", "Name", "Price" },
                values: new object[] { 1, "https://preview.redd.it/9d69elb5ext41.png?width=1024&auto=webp&s=6c0a8defaaed5d5707e889b10cc1f5e527706b46", "Purple mechanical keyboard", 149.99000000000001 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Img_Url", "Name", "Price" },
                values: new object[] { 2, "https://preview.redd.it/cw9ax8o8fws41.png?width=1024&auto=webp&s=c78e19c619bfc72933084710a656f39b2f347eea", "Galaxy mechanical keyboard", 249.99000000000001 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Img_Url", "Name", "Price" },
                values: new object[] { 3, "https://preview.redd.it/z5p7t8t2fst41.png?width=1024&auto=webp&s=14090fd249c2bf94fd2a2d5e3c0701f13f635fe6", "Small grey and beige keyboard", 200.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
