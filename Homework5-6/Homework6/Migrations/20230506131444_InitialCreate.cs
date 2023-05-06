using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Homework6.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    gr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gr_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gr_temp = table.Column<decimal>(type: "decimal(5,1)", precision: 5, scale: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.gr_id);
                });

            migrationBuilder.CreateTable(
                name: "Analyzes",
                columns: table => new
                {
                    an_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    an_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    an_cost = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    an_price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    an_group = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analyzes", x => x.an_id);
                    table.ForeignKey(
                        name: "FK_Analyzes_Groups_an_group",
                        column: x => x.an_group,
                        principalTable: "Groups",
                        principalColumn: "gr_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ord_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ord_datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ord_an = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ord_id);
                    table.ForeignKey(
                        name: "FK_Orders_Analyzes_ord_an",
                        column: x => x.ord_an,
                        principalTable: "Analyzes",
                        principalColumn: "an_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analyzes_an_group",
                table: "Analyzes",
                column: "an_group");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ord_an",
                table: "Orders",
                column: "ord_an");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Analyzes");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
