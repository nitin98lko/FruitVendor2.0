using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitUserApi.Migrations
{
    public partial class Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authers",
                columns: table => new
                {
                    aId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobNum = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authers", x => x.aId);
                });

            migrationBuilder.CreateTable(
                name: "Fruits",
                columns: table => new
                {
                    fId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fPrice = table.Column<double>(type: "float", nullable: false),
                    fQty = table.Column<int>(type: "int", nullable: false),
                    fImg = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fruits", x => x.fId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    oId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fId = table.Column<int>(type: "int", nullable: false),
                    uId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.oId);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cQty = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    fId = table.Column<int>(type: "int", nullable: false),
                    aId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cId);
                    table.ForeignKey(
                        name: "FK_Carts_Authers_aId",
                        column: x => x.aId,
                        principalTable: "Authers",
                        principalColumn: "aId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Fruits_fId",
                        column: x => x.fId,
                        principalTable: "Fruits",
                        principalColumn: "fId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_aId",
                table: "Carts",
                column: "aId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_fId",
                table: "Carts",
                column: "fId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Authers");

            migrationBuilder.DropTable(
                name: "Fruits");
        }
    }
}
