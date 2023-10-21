using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SueldoBase = table.Column<int>(type: "int", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talla", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEstado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoProteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProteccion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_IdPaisFk",
                        column: x => x.IdPaisFk,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estado_TipoEstado_IdTipoEstadoFk",
                        column: x => x.IdTipoEstadoFk,
                        principalTable: "TipoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuarioFk = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_usuario_IdUsuarioFk",
                        column: x => x.IdUsuarioFk,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userRol",
                columns: table => new
                {
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => new { x.IdUsuarioFk, x.IdRolFk });
                    table.ForeignKey(
                        name: "FK_userRol_rol_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRol_usuario_IdUsuarioFk",
                        column: x => x.IdUsuarioFk,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamentoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Departamento_IdDepartamentoFk",
                        column: x => x.IdDepartamentoFk,
                        principalTable: "Departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPrenda = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnitCop = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    ValorUnitUsd = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoProteccionFk = table.Column<int>(type: "int", nullable: false),
                    IdGeneroFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prenda_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prenda_Genero_IdGeneroFk",
                        column: x => x.IdGeneroFk,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prenda_TipoProteccion_IdTipoProteccionFk",
                        column: x => x.IdTipoProteccionFk,
                        principalTable: "TipoProteccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(type: "int", maxLength: 10000, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "date", maxLength: 100, nullable: false),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cliente_TipoPersona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaIngreso = table.Column<DateTime>(type: "date", maxLength: 100, nullable: false),
                    IdCargoFk = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleado_Cargo_IdCargoFk",
                        column: x => x.IdCargoFk,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empleado_Municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nit = table.Column<int>(type: "int", nullable: false),
                    RazonSocial = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentanteLegal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NitProveedor = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdMunicipioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedor_Municipio_IdMunicipioFk",
                        column: x => x.IdMunicipioFk,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proveedor_TipoPersona_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "TipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodInv = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorVtaCop = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    ValorVtaUsd = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventario_Prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orden_Cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orden_Empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orden_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "date", maxLength: 100, nullable: false),
                    IdEmpleadoFk = table.Column<int>(type: "int", nullable: false),
                    IdClienteFk = table.Column<int>(type: "int", nullable: false),
                    IdFormaPagoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_IdClienteFk",
                        column: x => x.IdClienteFk,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Empleado_IdEmpleadoFk",
                        column: x => x.IdEmpleadoFk,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_FormaPago_IdFormaPagoFk",
                        column: x => x.IdFormaPagoFk,
                        principalTable: "FormaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InventarioTalla",
                columns: table => new
                {
                    IdInventarioFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false),
                    InventarioId = table.Column<int>(type: "int", nullable: true),
                    TallaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioTalla", x => new { x.IdInventarioFk, x.IdTallaFk });
                    table.ForeignKey(
                        name: "FK_InventarioTalla_Inventario_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InventarioTalla_Talla_TallaId",
                        column: x => x.TallaId,
                        principalTable: "Talla",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleOrden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CantidadProducir = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    CantidadProducida = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    IdOrdenFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    IdColorFk = table.Column<int>(type: "int", nullable: false),
                    IdEstadoFk = table.Column<int>(type: "int", nullable: false),
                    IdInventarioFk = table.Column<int>(type: "int", nullable: false),
                    InventarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Color_IdColorFk",
                        column: x => x.IdColorFk,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Estado_IdEstadoFk",
                        column: x => x.IdEstadoFk,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Inventario_InventarioId",
                        column: x => x.InventarioId,
                        principalTable: "Inventario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Orden_IdOrdenFk",
                        column: x => x.IdOrdenFk,
                        principalTable: "Orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleOrden_Prenda_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cantidad = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    ValorUnit = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    IdVentaFk = table.Column<int>(type: "int", nullable: false),
                    IdInventarioFk = table.Column<int>(type: "int", nullable: false),
                    IdTallaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Inventario_IdInventarioFk",
                        column: x => x.IdInventarioFk,
                        principalTable: "Inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Talla_IdTallaFk",
                        column: x => x.IdTallaFk,
                        principalTable: "Talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Venta_IdVentaFk",
                        column: x => x.IdVentaFk,
                        principalTable: "Venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnit = table.Column<int>(type: "int", maxLength: 1000, nullable: false),
                    stockmin = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    stockmax = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    InsumoProveedorIdInsumoFk = table.Column<int>(type: "int", nullable: true),
                    InsumoProveedorIdProoveedorFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InsumoPrenda",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdPrendaFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoPrenda", x => new { x.IdInsumoFk, x.IdPrendaFk });
                    table.ForeignKey(
                        name: "FK_InsumoPrenda_Insumo_IdPrendaFk",
                        column: x => x.IdPrendaFk,
                        principalTable: "Insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoPrenda_Prenda_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "Prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "InsumoProveedores",
                columns: table => new
                {
                    IdInsumoFk = table.Column<int>(type: "int", nullable: false),
                    IdProoveedorFk = table.Column<int>(type: "int", nullable: false),
                    InsumoProveedorIdInsumoFk = table.Column<int>(type: "int", nullable: true),
                    InsumoProveedorIdProoveedorFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsumoProveedores", x => new { x.IdInsumoFk, x.IdProoveedorFk });
                    table.ForeignKey(
                        name: "FK_InsumoProveedores_InsumoProveedores_InsumoProveedorIdInsumoF~",
                        columns: x => new { x.InsumoProveedorIdInsumoFk, x.InsumoProveedorIdProoveedorFk },
                        principalTable: "InsumoProveedores",
                        principalColumns: new[] { "IdInsumoFk", "IdProoveedorFk" });
                    table.ForeignKey(
                        name: "FK_InsumoProveedores_Insumo_IdInsumoFk",
                        column: x => x.IdInsumoFk,
                        principalTable: "Insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsumoProveedores_Proveedor_IdProoveedorFk",
                        column: x => x.IdProoveedorFk,
                        principalTable: "Proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdMunicipioFk",
                table: "Cliente",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdTipoPersonaFk",
                table: "Cliente",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdPaisFk",
                table: "Departamento",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdColorFk",
                table: "DetalleOrden",
                column: "IdColorFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdEstadoFk",
                table: "DetalleOrden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdOrdenFk",
                table: "DetalleOrden",
                column: "IdOrdenFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_IdPrendaFk",
                table: "DetalleOrden",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleOrden_InventarioId",
                table: "DetalleOrden",
                column: "InventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdInventarioFk",
                table: "DetalleVenta",
                column: "IdInventarioFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdTallaFk",
                table: "DetalleVenta",
                column: "IdTallaFk");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_IdVentaFk",
                table: "DetalleVenta",
                column: "IdVentaFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdCargoFk",
                table: "Empleado",
                column: "IdCargoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdMunicipioFk",
                table: "Empleado",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_MunicipioId",
                table: "Empresas",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_IdTipoEstadoFk",
                table: "Estado",
                column: "IdTipoEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Insumo_InsumoProveedorIdInsumoFk_InsumoProveedorIdProoveedor~",
                table: "Insumo",
                columns: new[] { "InsumoProveedorIdInsumoFk", "InsumoProveedorIdProoveedorFk" });

            migrationBuilder.CreateIndex(
                name: "IX_InsumoPrenda_IdPrendaFk",
                table: "InsumoPrenda",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoProveedores_IdProoveedorFk",
                table: "InsumoProveedores",
                column: "IdProoveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_InsumoProveedores_InsumoProveedorIdInsumoFk_InsumoProveedorI~",
                table: "InsumoProveedores",
                columns: new[] { "InsumoProveedorIdInsumoFk", "InsumoProveedorIdProoveedorFk" });

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_IdPrendaFk",
                table: "Inventario",
                column: "IdPrendaFk");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioTalla_InventarioId",
                table: "InventarioTalla",
                column: "InventarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioTalla_TallaId",
                table: "InventarioTalla",
                column: "TallaId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_IdDepartamentoFk",
                table: "Municipio",
                column: "IdDepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdClienteFk",
                table: "Orden",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdEmpleadoFk",
                table: "Orden",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Orden_IdEstadoFk",
                table: "Orden",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdEstadoFk",
                table: "Prenda",
                column: "IdEstadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdGeneroFk",
                table: "Prenda",
                column: "IdGeneroFk");

            migrationBuilder.CreateIndex(
                name: "IX_Prenda_IdTipoProteccionFk",
                table: "Prenda",
                column: "IdTipoProteccionFk");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdMunicipioFk",
                table: "Proveedor",
                column: "IdMunicipioFk");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_IdTipoPersonaFk",
                table: "Proveedor",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_IdUsuarioFk",
                table: "RefreshToken",
                column: "IdUsuarioFk");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_IdRolFk",
                table: "userRol",
                column: "IdRolFk");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdClienteFk",
                table: "Venta",
                column: "IdClienteFk");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdEmpleadoFk",
                table: "Venta",
                column: "IdEmpleadoFk");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_IdFormaPagoFk",
                table: "Venta",
                column: "IdFormaPagoFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Insumo_InsumoProveedores_InsumoProveedorIdInsumoFk_InsumoPro~",
                table: "Insumo",
                columns: new[] { "InsumoProveedorIdInsumoFk", "InsumoProveedorIdProoveedorFk" },
                principalTable: "InsumoProveedores",
                principalColumns: new[] { "IdInsumoFk", "IdProoveedorFk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedor_Municipio_IdMunicipioFk",
                table: "Proveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedor_TipoPersona_IdTipoPersonaFk",
                table: "Proveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Insumo_InsumoProveedores_InsumoProveedorIdInsumoFk_InsumoPro~",
                table: "Insumo");

            migrationBuilder.DropTable(
                name: "DetalleOrden");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "InsumoPrenda");

            migrationBuilder.DropTable(
                name: "InventarioTalla");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "userRol");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Talla");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "FormaPago");

            migrationBuilder.DropTable(
                name: "Prenda");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoProteccion");

            migrationBuilder.DropTable(
                name: "TipoEstado");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pais");

            migrationBuilder.DropTable(
                name: "TipoPersona");

            migrationBuilder.DropTable(
                name: "InsumoProveedores");

            migrationBuilder.DropTable(
                name: "Insumo");

            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}
