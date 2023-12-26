using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tema4.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Models1",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numar = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models1", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Models3",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models3", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Models4",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models4", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Models5",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models5", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Models2",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numar = table.Column<int>(type: "int", nullable: false),
                    Model1Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models2", x => x.id);
                    table.ForeignKey(
                        name: "FK_Models2_Models1_Model1Id",
                        column: x => x.Model1Id,
                        principalTable: "Models1",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modelsRelations",
                columns: table => new
                {
                    Model3Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Model4Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelsRelations", x => new { x.Model3Id, x.Model4Id });
                    table.ForeignKey(
                        name: "FK_modelsRelations_Models3_Model3Id",
                        column: x => x.Model3Id,
                        principalTable: "Models3",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_modelsRelations_Models4_Model4Id",
                        column: x => x.Model4Id,
                        principalTable: "Models4",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models6",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model5Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models6", x => x.id);
                    table.ForeignKey(
                        name: "FK_Models6_Models5_Model5Id",
                        column: x => x.Model5Id,
                        principalTable: "Models5",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Models2_Model1Id",
                table: "Models2",
                column: "Model1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Models6_Model5Id",
                table: "Models6",
                column: "Model5Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_modelsRelations_Model4Id",
                table: "modelsRelations",
                column: "Model4Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Models2");

            migrationBuilder.DropTable(
                name: "Models6");

            migrationBuilder.DropTable(
                name: "modelsRelations");

            migrationBuilder.DropTable(
                name: "Models1");

            migrationBuilder.DropTable(
                name: "Models5");

            migrationBuilder.DropTable(
                name: "Models3");

            migrationBuilder.DropTable(
                name: "Models4");
        }
    }
}
