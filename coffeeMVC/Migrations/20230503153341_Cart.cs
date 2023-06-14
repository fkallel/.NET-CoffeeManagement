using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coffeeMVC.Migrations
{
    /// <inheritdoc />
    public partial class Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartViewModelId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CartViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CartViewModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_CartViewModel_CartViewModelId",
                        column: x => x.CartViewModelId,
                        principalTable: "CartViewModel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartViewModelId",
                table: "Products",
                column: "CartViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartViewModelId",
                table: "CartItem",
                column: "CartViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartViewModel_CartViewModelId",
                table: "Products",
                column: "CartViewModelId",
                principalTable: "CartViewModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartViewModel_CartViewModelId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "CartViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartViewModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartViewModelId",
                table: "Products");
        }
    }
}
