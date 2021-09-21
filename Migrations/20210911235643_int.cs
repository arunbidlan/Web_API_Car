using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API_Car.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Car",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Car",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Car",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Car",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
