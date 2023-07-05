using Microsoft.EntityFrameworkCore.Migrations;

using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace ServicoEnderecos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "regioes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sigla = table.Column<string>(type: "longtext", nullable: false),
                    nome = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table => table.PrimaryKey("pk_regioes", x => x.id))
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "u_fs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    sigla = table.Column<string>(type: "longtext", nullable: false),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    regiao_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_u_fs", x => x.id);
                    table.ForeignKey(
                        name: "fk_u_fs_regioes_regiao_id",
                        column: x => x.regiao_id,
                        principalTable: "regioes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mesorregioes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    uf_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mesorregioes", x => x.id);
                    table.ForeignKey(
                        name: "fk_mesorregioes_u_fs_uf_id",
                        column: x => x.uf_id,
                        principalTable: "u_fs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "regioes_intermediaras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    uf_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_regioes_intermediaras", x => x.id);
                    table.ForeignKey(
                        name: "fk_regioes_intermediaras_u_fs_uf_id",
                        column: x => x.uf_id,
                        principalTable: "u_fs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "microrregioes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    mesorregiao_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_microrregioes", x => x.id);
                    table.ForeignKey(
                        name: "fk_microrregioes_mesorregioes_mesorregiao_id",
                        column: x => x.mesorregiao_id,
                        principalTable: "mesorregioes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "regioes_imediatas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    regiao_intermediaria_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_regioes_imediatas", x => x.id);
                    table.ForeignKey(
                        name: "fk_regioes_imediatas_regioes_intermediaras_regiao_intermediaria",
                        column: x => x.regiao_intermediaria_id,
                        principalTable: "regioes_intermediaras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "municipios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    microrregiao_id = table.Column<int>(type: "int", nullable: false),
                    regiaoimediata_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_municipios", x => x.id);
                    table.ForeignKey(
                        name: "fk_municipios_microrregioes_microrregiao_id",
                        column: x => x.microrregiao_id,
                        principalTable: "microrregioes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_municipios_regioes_imediatas_regiaoimediata_id",
                        column: x => x.regiaoimediata_id,
                        principalTable: "regioes_imediatas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "distritos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(type: "longtext", nullable: false),
                    municipio_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_distritos", x => x.id);
                    table.ForeignKey(
                        name: "fk_distritos_municipios_municipio_id",
                        column: x => x.municipio_id,
                        principalTable: "municipios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "ix_distritos_municipio_id",
                table: "distritos",
                column: "municipio_id");

            migrationBuilder.CreateIndex(
                name: "ix_mesorregioes_uf_id",
                table: "mesorregioes",
                column: "uf_id");

            migrationBuilder.CreateIndex(
                name: "ix_microrregioes_mesorregiao_id",
                table: "microrregioes",
                column: "mesorregiao_id");

            migrationBuilder.CreateIndex(
                name: "ix_municipios_microrregiao_id",
                table: "municipios",
                column: "microrregiao_id");

            migrationBuilder.CreateIndex(
                name: "ix_municipios_regiaoimediata_id",
                table: "municipios",
                column: "regiaoimediata_id");

            migrationBuilder.CreateIndex(
                name: "ix_regioes_imediatas_regiao_intermediaria_id",
                table: "regioes_imediatas",
                column: "regiao_intermediaria_id");

            migrationBuilder.CreateIndex(
                name: "ix_regioes_intermediaras_uf_id",
                table: "regioes_intermediaras",
                column: "uf_id");

            migrationBuilder.CreateIndex(
                name: "ix_u_fs_regiao_id",
                table: "u_fs",
                column: "regiao_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "distritos");

            migrationBuilder.DropTable(
                name: "municipios");

            migrationBuilder.DropTable(
                name: "microrregioes");

            migrationBuilder.DropTable(
                name: "regioes_imediatas");

            migrationBuilder.DropTable(
                name: "mesorregioes");

            migrationBuilder.DropTable(
                name: "regioes_intermediaras");

            migrationBuilder.DropTable(
                name: "u_fs");

            migrationBuilder.DropTable(
                name: "regioes");
        }
    }
}