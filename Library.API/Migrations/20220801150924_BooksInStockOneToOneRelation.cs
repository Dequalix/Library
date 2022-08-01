using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.API.Migrations
{
    public partial class BooksInStockOneToOneRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInStock",
                table: "BooksInStock");

            migrationBuilder.DropIndex(
                name: "IX_BooksInStock_BookId",
                table: "BooksInStock");

            migrationBuilder.DropColumn(
                name: "BooksInStockId",
                table: "BooksInStock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInStock",
                table: "BooksInStock",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksInStock",
                table: "BooksInStock");

            migrationBuilder.AddColumn<int>(
                name: "BooksInStockId",
                table: "BooksInStock",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksInStock",
                table: "BooksInStock",
                column: "BooksInStockId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksInStock_BookId",
                table: "BooksInStock",
                column: "BookId",
                unique: true);
        }
    }
}
