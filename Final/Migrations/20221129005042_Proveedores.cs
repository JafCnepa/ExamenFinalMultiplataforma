using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.Migrations
{
    public partial class Proveedores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Distritos_Distritoscodigo_distrito",
                table: "Proveedores");

            migrationBuilder.AlterColumn<int>(
                name: "Distritoscodigo_distrito",
                table: "Proveedores",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "telefono",
                table: "Proveedores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Distritos_Distritoscodigo_distrito",
                table: "Proveedores",
                column: "Distritoscodigo_distrito",
                principalTable: "Distritos",
                principalColumn: "codigo_distrito");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Distritos_Distritoscodigo_distrito",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "telefono",
                table: "Proveedores");

            migrationBuilder.AlterColumn<int>(
                name: "Distritoscodigo_distrito",
                table: "Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Distritos_Distritoscodigo_distrito",
                table: "Proveedores",
                column: "Distritoscodigo_distrito",
                principalTable: "Distritos",
                principalColumn: "codigo_distrito",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
