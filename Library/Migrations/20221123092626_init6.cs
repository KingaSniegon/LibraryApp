using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_BorrowedBooks_Books_BookId",
            //    table: "BorrowedBooks");

            //migrationBuilder.DropIndex(
            //    name: "IX_BorrowedBooks_BookId",
            //    table: "BorrowedBooks");

            //migrationBuilder.DropColumn(
            //    name: "BookId",
            //    table: "BorrowedBooks");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BorrowedBookId",
                table: "BorrowedBooks",
                column: "BorrowedBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBook_Book",
                table: "BorrowedBooks",
                column: "BorrowedBookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBook_Book",
                table: "BorrowedBooks");

            migrationBuilder.DropIndex(
                name: "IX_BorrowedBooks_BorrowedBookId",
                table: "BorrowedBooks");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BorrowedBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_BookId",
                table: "BorrowedBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
