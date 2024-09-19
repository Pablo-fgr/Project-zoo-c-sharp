using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAV_TPFinal_56340_Infraestructura_Datos.Migrations
{
    /// <inheritdoc />
    public partial class ModeloInicialDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Dni", "Domicilio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"), "12345678", "Tucumán", "Luis" },
                    { new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"), "87654321", "Tucumán", "María" }
                });

            migrationBuilder.InsertData(
                table: "Especies",
                columns: new[] { "Id", "Codigo", "Nombre", "PorcentajePesoCarne", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("05c85532-133f-47df-9ef3-8c6f979c6bdd"), 4, "Rinoceronte", 0.0, 1 },
                    { new Guid("c19e408a-d9e0-4d2c-8ef2-913b4a21f327"), 2, "Jirafa", 0.0, 1 },
                    { new Guid("c94eb08b-7268-4f9b-b64c-78ce32efb358"), 3, "Tigre", 0.5, 0 },
                    { new Guid("ea9dea9d-92ca-43be-bf7c-fe257b8dbdfb"), 1, "León", 0.69999999999999996, 0 }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { new Guid("573d1328-176a-4398-b43d-a60b3ddf7f43"), 1, "Australia" },
                    { new Guid("bc4d6cf0-30ad-4b09-9e35-539942c9e59e"), 3, "Singapur" },
                    { new Guid("be8c440c-a689-4cb9-9ad8-a8cd9dc18970"), 4, "Sudáfrica" },
                    { new Guid("cffb2f99-8072-48b4-8e48-61696cb83842"), 2, "Canadá" }
                });

            migrationBuilder.InsertData(
                table: "Sectores",
                columns: new[] { "Id", "EmpleadoId", "Latitud", "Limite", "Longitud", "Numero", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("1c23e32a-2b66-4689-a70c-9899afde5658"), new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"), -26.252358999999998, 10, -65.521511000000004, 2, 0 },
                    { new Guid("3e564cbc-225a-49e4-a1da-043b53b8ec1d"), new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"), -26.250724000000002, 10, -65.522827000000007, 1, 1 },
                    { new Guid("5a334e17-193a-4cab-a485-27acb30bb671"), new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"), -26.254660999999999, 10, -65.522726000000006, 3, 1 },
                    { new Guid("60514f2b-bed5-4835-a13f-cf6cbe5ca5c4"), new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"), -26.257249999999999, 10, -65.523514000000006, 4, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("05c85532-133f-47df-9ef3-8c6f979c6bdd"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("c19e408a-d9e0-4d2c-8ef2-913b4a21f327"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("c94eb08b-7268-4f9b-b64c-78ce32efb358"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("ea9dea9d-92ca-43be-bf7c-fe257b8dbdfb"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("573d1328-176a-4398-b43d-a60b3ddf7f43"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bc4d6cf0-30ad-4b09-9e35-539942c9e59e"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("be8c440c-a689-4cb9-9ad8-a8cd9dc18970"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cffb2f99-8072-48b4-8e48-61696cb83842"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("1c23e32a-2b66-4689-a70c-9899afde5658"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("3e564cbc-225a-49e4-a1da-043b53b8ec1d"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("5a334e17-193a-4cab-a485-27acb30bb671"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("60514f2b-bed5-4835-a13f-cf6cbe5ca5c4"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("3e45eb64-d60e-49a0-8731-f8bb1962ff3d"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("f2208f6b-9e57-4cf1-87ff-91957be8e699"));
        }
    }
}
