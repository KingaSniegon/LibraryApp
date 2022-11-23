using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(

                name: "BorrowBookId",
                table: "BorrowedBooks",
                newName: "BorrowedBookId"

                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
