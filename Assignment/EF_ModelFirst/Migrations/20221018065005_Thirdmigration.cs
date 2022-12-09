using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_ModelFirst.Migrations
{
    public partial class Thirdmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "ProductionUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", maxLength: 700, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayDuration = table.Column<int>(type: "int", nullable: true),
                    BoxOfficeCollection = table.Column<double>(type: "float", nullable: true),
                    Seasons = table.Column<int>(type: "int", nullable: true),
                    EpisodPerSeason = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomersOrders",
                columns: table => new
                {
                    CustomersCustomerId = table.Column<int>(type: "int", nullable: false),
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersOrders", x => new { x.CustomersCustomerId, x.OrdersOrderId });
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Customers_CustomersCustomerId",
                        column: x => x.CustomersCustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomersOrders_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductionUnits",
                columns: new[] { "Id", "BoxOfficeCollection", "Category", "Discriminator", "Name", "PlayDuration", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, 12222.0, "Spy", "Movies", "Dr.No", 150, 1963 },
                    { 2, 122.0, "Comedy", "Movies", "Golmal", 180, 1976 }
                });

            migrationBuilder.InsertData(
                table: "ProductionUnits",
                columns: new[] { "Id", "Discriminator", "EpisodPerSeason", "Name", "ReleaseYear", "Seasons" },
                values: new object[,]
                {
                    { 3, "WebSeries", 100, "Ramayan", 1986, 2 },
                    { 4, "WebSeries", 50, "House of Cards", 2005, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomersOrders_OrdersOrderId",
                table: "CustomersOrders",
                column: "OrdersOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersOrders");

            migrationBuilder.DropTable(
                name: "ProductionUnits");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
