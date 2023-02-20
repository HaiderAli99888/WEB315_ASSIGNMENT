using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaApp.Migrations
{
    public partial class Topping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "Pizza",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Pizza",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topping",
                table: "Pizza",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "Topping",
                table: "Pizza");
        }
    }
}
