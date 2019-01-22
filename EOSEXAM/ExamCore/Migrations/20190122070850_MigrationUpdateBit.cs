using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamCore.Migrations
{
    public partial class MigrationUpdateBit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IsRight",
                table: "ResultDetail",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "IsRight",
                table: "Option",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsRight",
                table: "ResultDetail",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "IsRight",
                table: "Option",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
