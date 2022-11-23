using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowedBooks",
                table: "BorrowedBooks");

            migrationBuilder.DropColumn(
                name: "BorrowedBookId",
                 table: "BorrowedBooks");

            migrationBuilder.AddColumn<string>(
               name: "BorrowBookId",
               table: "BorrowedBooks",
               type: "int",
               nullable: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BorrowedBookId",
                table: "BorrowedBooks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowedBooks",
                table: "BorrowedBooks",
                column: "BorrowedBookId");
        }
    }
}
