using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace easygroceries.Migrations
{
    public partial class sqlite_migration_745 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Customers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
