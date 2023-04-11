using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Classtask.Migrations
{
    public partial class CreatElearn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrption",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Main",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrption",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "Main",
                table: "Sliders");
        }
    }
}
