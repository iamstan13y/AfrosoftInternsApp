using Microsoft.EntityFrameworkCore.Migrations;

namespace AfrosoftInterns.Migrations
{
    public partial class NewCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(6)",
                table: "Interns",
                newName: "Sex");

            migrationBuilder.RenameColumn(
                name: "varchar(100)",
                table: "Interns",
                newName: "Specialty");

            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Interns",
                newName: "FullName");

            migrationBuilder.AlterColumn<string>(
                name: "Sex",
                table: "Interns",
                type: "varchar(6)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Interns",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Interns",
                type: "nvarchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Interns",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Interns",
                type: "varchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "Interns");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Interns");

            migrationBuilder.RenameColumn(
                name: "Specialty",
                table: "Interns",
                newName: "varchar(100)");

            migrationBuilder.RenameColumn(
                name: "Sex",
                table: "Interns",
                newName: "varchar(6)");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Interns",
                newName: "nvarchar(250)");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(100)",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "varchar(6)",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(250)",
                table: "Interns",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)");
        }
    }
}
