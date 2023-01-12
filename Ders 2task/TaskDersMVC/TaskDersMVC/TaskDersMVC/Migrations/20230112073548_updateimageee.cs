using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDersMVC.Migrations
{
    public partial class updateimageee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "prodacts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "prodacts");
        }
    }
}
