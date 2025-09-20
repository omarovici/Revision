using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Revision.Migrations
{
    /// <inheritdoc />
    public partial class Edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "EmpTable",
                newName: "EmployeeName");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeName",
                table: "EmpTable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EmpTable",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "EmpTable");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "EmpTable",
                newName: "EmpName");

            migrationBuilder.AlterColumn<string>(
                name: "EmpName",
                table: "EmpTable",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
