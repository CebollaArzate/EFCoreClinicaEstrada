using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreClinicaEstrada.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotasSoap",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subjetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Evaluacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotasSoap", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terapeutas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CedulaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapeutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terapias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terapias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExpedientesClinicos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedientesClinicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpedientesClinicos_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FisioTerapeutaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PacienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoConsulta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoapId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConDescuento = table.Column<bool>(type: "bit", nullable: false),
                    Realizada = table.Column<bool>(type: "bit", nullable: false),
                    PorcentajeDescuento = table.Column<float>(type: "real", nullable: false),
                    ExpedienteClinicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultas_ExpedientesClinicos_ExpedienteClinicoId",
                        column: x => x.ExpedienteClinicoId,
                        principalTable: "ExpedientesClinicos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Consultas_NotasSoap_SoapId",
                        column: x => x.SoapId,
                        principalTable: "NotasSoap",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Consultas_Terapeutas_FisioTerapeutaId",
                        column: x => x.FisioTerapeutaId,
                        principalTable: "Terapeutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsultaTerapia",
                columns: table => new
                {
                    ConsultasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TerapiasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaTerapia", x => new { x.ConsultasId, x.TerapiasId });
                    table.ForeignKey(
                        name: "FK_ConsultaTerapia_Consultas_ConsultasId",
                        column: x => x.ConsultasId,
                        principalTable: "Consultas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultaTerapia_Terapias_TerapiasId",
                        column: x => x.TerapiasId,
                        principalTable: "Terapias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Terapeutas",
                columns: new[] { "Id", "CedulaProfesional", "Celular", "FechaIngreso", "FechaNacimiento", "Nombre", "RFC", "Titulo" },
                values: new object[,]
                {
                    { new Guid("426ac8d5-7253-450f-8480-5981de63c30f"), "87654321", "7331251176", new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1965, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Estrada Aguilar", "EAAD651015AKA", "Lic. Fisioterapeuta" },
                    { new Guid("4e4db7de-5981-48f0-8637-9f0c1e14465b"), "12345678", "7331525813", new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1993, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin David Estrada Posada", "EAPK930905QD7", "Lic. Fisioterapeuta" }
                });

            migrationBuilder.InsertData(
                table: "Terapias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("9719183b-7cb7-491d-b32b-e2351dcd5bd3"), "Movilidad" },
                    { new Guid("a6a0797c-f23a-40db-a48c-56c616be22d1"), "Fortalecimiento" },
                    { new Guid("c4645e94-0352-4024-be6f-0324301cb878"), "Bicicleta" },
                    { new Guid("df8d035a-dfac-4e0a-906b-2ca18544b7b8"), "Electro Introacticula" },
                    { new Guid("ff8ec6d0-eb58-42ad-ada5-81acb1f71653"), "Recuperacion Activa" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_ExpedienteClinicoId",
                table: "Consultas",
                column: "ExpedienteClinicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_FisioTerapeutaId",
                table: "Consultas",
                column: "FisioTerapeutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_PacienteId",
                table: "Consultas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_SoapId",
                table: "Consultas",
                column: "SoapId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaTerapia_TerapiasId",
                table: "ConsultaTerapia",
                column: "TerapiasId");
            //Me
            migrationBuilder.CreateIndex(
               name: "IX_ConsultaTerapia_ConsultasId",
               table: "ConsultaTerapia",
               column: "ConsultasId");
            //

            migrationBuilder.CreateIndex(
                name: "IX_ExpedientesClinicos_PacienteId",
                table: "ExpedientesClinicos",
                column: "PacienteId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultaTerapia");

            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Terapias");

            migrationBuilder.DropTable(
                name: "ExpedientesClinicos");

            migrationBuilder.DropTable(
                name: "NotasSoap");

            migrationBuilder.DropTable(
                name: "Terapeutas");

            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
