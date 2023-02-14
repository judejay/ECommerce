using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easygroceries.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerSecondName = table.Column<string>(type: "TEXT", nullable: true),
                    MembershipId = table.Column<int>(type: "INTEGER", nullable: false),
                    Discount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    HouseNumberName = table.Column<string>(type: "TEXT", nullable: true),
                    StreetName = table.Column<string>(type: "TEXT", nullable: true),
                    Town = table.Column<string>(type: "TEXT", nullable: true),
                    Postcode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Groceries",
                columns: table => new
                {
                    GroceryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Slug = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groceries", x => x.GroceryId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalPrice = table.Column<decimal>(type: " decimal(8,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseOrders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Active", "Country", "CustomerFirstName", "CustomerSecondName", "Discount", "HouseNumberName", "MembershipId", "Postcode", "StreetName", "Town" },
                values: new object[] { 1, false, "UK", "Bill", "Gates", 0m, "222", 0, "NW5 8MM", "High street", "Newark" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Active", "Country", "CustomerFirstName", "CustomerSecondName", "Discount", "HouseNumberName", "MembershipId", "Postcode", "StreetName", "Town" },
                values: new object[] { 2, false, "UK", "Jon", "Snow", 0m, "1", 0, "SW1 1LP", "Main street", "London" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 1, "Juicy apples", "https://images.pexels.com/photos/1453713/pexels-photo-1453713.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Apples", 1.50m, 50, "apples" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 2, "Fresh bananas", "https://images.pexels.com/photos/1093038/pexels-photo-1093038.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Bananas", 3.50m, 50, "bananas" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 3, "Juicy watermelon", "https://images.pexels.com/photos/1313267/pexels-photo-1313267.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Watermelon", 2.50m, 50, "watermelon" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 4, "Juicy grapefruit", "https://images.pexels.com/photos/2247211/pexels-photo-2247211.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Grapefruit", 2m, 50, "grapefruit" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 5, "The best of cows", "https://images.pexels.com/photos/248412/pexels-photo-248412.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Milk", 1.99m, 50, "milk" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 6, "Easy toast", "https://images.pexels.com/photos/166021/pexels-photo-166021.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Bread", 1.99m, 50, "bread" });

            migrationBuilder.InsertData(
                table: "Groceries",
                columns: new[] { "GroceryId", "Description", "Image", "Name", "Price", "Quantity", "Slug" },
                values: new object[] { 7, "Wild chicken", "https://images.pexels.com/photos/600615/pexels-photo-600615.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Eggs", 1.99m, 50, "eggs" });

            migrationBuilder.InsertData(
                table: "PurchaseOrders",
                columns: new[] { "Id", "CustomerId", "TotalPrice" },
                values: new object[] { 1, 2, 40m });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CustomerId",
                table: "PurchaseOrders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groceries");

            migrationBuilder.DropTable(
                name: "PurchaseOrders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
