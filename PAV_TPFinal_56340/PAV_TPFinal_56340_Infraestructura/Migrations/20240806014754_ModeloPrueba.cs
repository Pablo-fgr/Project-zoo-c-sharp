using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PAV_TPFinal_56340_Infraestructura_Datos.Migrations
{
    /// <inheritdoc />
    public partial class ModeloPrueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Dni", "Domicilio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("142286b8-1d89-4a02-9161-8448fc0faa77"), "87654321", "Tucumán", "María" },
                    { new Guid("6f3ae0a3-c399-4cfd-b46d-452964c41ba5"), "12345678", "Tucumán", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Especies",
                columns: new[] { "Id", "Codigo", "Nombre", "PorcentajePesoCarne", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("1f837e86-8df3-4966-883e-9097eacfa844"), 3, "Tigre", 0.5, 0 },
                    { new Guid("68b21844-5450-4308-8e91-f69c95f3d0e4"), 1, "León", 0.69999999999999996, 0 },
                    { new Guid("92d652f1-4179-43a2-928b-e3cd8250f5d0"), 4, "Rinoceronte", 0.0, 1 },
                    { new Guid("cf252142-47cb-4009-a4fe-07b9ed1acccd"), 2, "Jirafa", 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Codigo", "Nombre" },
                values: new object[,]
                {
                    { new Guid("15946849-ef18-4e65-8af9-5bfd6d31bdd4"), 2, "Canadá" },
                    { new Guid("4b532ae6-2b8c-449c-a4af-02aaf8d9b685"), 3, "Singapur" },
                    { new Guid("bbe99c51-a00e-48b0-b227-c59d11682764"), 1, "Australia" },
                    { new Guid("f2de77ba-94bb-4b0c-af89-6a8db44c41a8"), 4, "Sudáfrica" }
                });

            migrationBuilder.InsertData(
                table: "Sectores",
                columns: new[] { "Id", "EmpleadoId", "Latitud", "Limite", "Longitud", "Numero", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("84c872ab-d971-435e-aadf-934c881a137b"), new Guid("142286b8-1d89-4a02-9161-8448fc0faa77"), -26.254660999999999, 10, -65.522726000000006, 3, 1 },
                    { new Guid("8b1d8c9f-6fa8-49a5-8328-0135f9df0eb0"), new Guid("142286b8-1d89-4a02-9161-8448fc0faa77"), -26.257249999999999, 10, -65.523514000000006, 4, 0 },
                    { new Guid("c204d5d8-9284-482b-b7e0-a6fd4297bb0d"), new Guid("6f3ae0a3-c399-4cfd-b46d-452964c41ba5"), -26.250724000000002, 10, -65.522827000000007, 1, 1 },
                    { new Guid("e9d7e1dc-b743-4364-8c49-e103625a547b"), new Guid("6f3ae0a3-c399-4cfd-b46d-452964c41ba5"), -26.252358999999998, 10, -65.521511000000004, 2, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("1f837e86-8df3-4966-883e-9097eacfa844"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("68b21844-5450-4308-8e91-f69c95f3d0e4"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("92d652f1-4179-43a2-928b-e3cd8250f5d0"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("cf252142-47cb-4009-a4fe-07b9ed1acccd"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("15946849-ef18-4e65-8af9-5bfd6d31bdd4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("4b532ae6-2b8c-449c-a4af-02aaf8d9b685"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("bbe99c51-a00e-48b0-b227-c59d11682764"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("f2de77ba-94bb-4b0c-af89-6a8db44c41a8"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("84c872ab-d971-435e-aadf-934c881a137b"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("8b1d8c9f-6fa8-49a5-8328-0135f9df0eb0"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("c204d5d8-9284-482b-b7e0-a6fd4297bb0d"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("e9d7e1dc-b743-4364-8c49-e103625a547b"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("142286b8-1d89-4a02-9161-8448fc0faa77"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("6f3ae0a3-c399-4cfd-b46d-452964c41ba5"));

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
    }
}
