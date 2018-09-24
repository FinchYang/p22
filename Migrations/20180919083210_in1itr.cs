using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace p22.Migrations
{
    public partial class in1itr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dapp",
                columns: table => new
                {
                    ppId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    policenumber = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    identitycardnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dapp", x => x.ppId);
                });

            migrationBuilder.CreateTable(
                name: "xiao",
                columns: table => new
                {
                    qqId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    policenumber = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    name = table.Column<string>(nullable: false),
                    identitycardnumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xiao", x => x.qqId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dapp");

            migrationBuilder.DropTable(
                name: "xiao");
        }
    }
}
