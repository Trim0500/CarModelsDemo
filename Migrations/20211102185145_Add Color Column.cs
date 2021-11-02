using Microsoft.EntityFrameworkCore.Migrations;

namespace CarModelsDemo.Migrations
{
    public partial class AddColorColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "CarModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "CarModels");
        }
    }
}
