using Microsoft.EntityFrameworkCore.Migrations;

namespace p22.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "policenumber",
                table: "dapp",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "dapp",
                newName: "time");

            migrationBuilder.RenameColumn(
                name: "identitycardnumber",
                table: "dapp",
                newName: "operation");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "dapp",
                newName: "ip");

            migrationBuilder.RenameColumn(
                name: "ppId",
                table: "dapp",
                newName: "loggingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "username",
                table: "dapp",
                newName: "policenumber");

            migrationBuilder.RenameColumn(
                name: "time",
                table: "dapp",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "operation",
                table: "dapp",
                newName: "identitycardnumber");

            migrationBuilder.RenameColumn(
                name: "ip",
                table: "dapp",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "loggingId",
                table: "dapp",
                newName: "ppId");
        }
    }
}
