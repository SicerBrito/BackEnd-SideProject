using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DisponibilidadViaje",
                columns: table => new
                {
                    IdDisponibilidadViaje = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Disponibilidad = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisponibilidadViaje", x => x.IdDisponibilidadViaje);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especialidad",
                columns: table => new
                {
                    IdEspecialidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidad", x => x.IdEspecialidad);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(70)", maxLength: 70, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.IdGenero);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NivelIngles",
                columns: table => new
                {
                    IdNivelIngles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nivel = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelIngles", x => x.IdNivelIngles);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.IdPais);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreRol = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.IdRol);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seniority",
                columns: table => new
                {
                    IdSeniority = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seniority", x => x.IdSeniority);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Solicitud",
                columns: table => new
                {
                    IdSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Empresa = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitud", x => x.IdSolicitud);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tecnologia",
                columns: table => new
                {
                    IdTecnologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologia", x => x.IdTecnologia);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id_Usuario);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FkPaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.IdDepartamento);
                    table.ForeignKey(
                        name: "FK_Departamento_Pais_FkPaisId",
                        column: x => x.FkPaisId,
                        principalTable: "Pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
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
                        name: "FK_RefreshToken_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuariosRoles",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosRoles", x => new { x.UsuarioId, x.RolId });
                    table.ForeignKey(
                        name: "FK_UsuariosRoles_Rol_RolId",
                        column: x => x.RolId,
                        principalTable: "Rol",
                        principalColumn: "IdRol",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosRoles_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FkDepartamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.IdCiudad);
                    table.ForeignKey(
                        name: "FK_Ciudad_Departamento_FkDepartamentoId",
                        column: x => x.FkDepartamentoId,
                        principalTable: "Departamento",
                        principalColumn: "IdDepartamento",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombres = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellidos = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FkGeneroId = table.Column<int>(type: "int", nullable: false),
                    FkSeniorityId = table.Column<int>(type: "int", nullable: false),
                    FkEspecialidadId = table.Column<int>(type: "int", nullable: false),
                    FkUbicacionId = table.Column<int>(type: "int", nullable: false),
                    PretensionSalarialUSD = table.Column<int>(type: "int", nullable: false),
                    FkNivelInglesId = table.Column<int>(type: "int", nullable: false),
                    FkDisponibilidadId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.IdPerfil);
                    table.ForeignKey(
                        name: "FK_Perfil_Ciudad_FkUbicacionId",
                        column: x => x.FkUbicacionId,
                        principalTable: "Ciudad",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfil_DisponibilidadViaje_FkDisponibilidadId",
                        column: x => x.FkDisponibilidadId,
                        principalTable: "DisponibilidadViaje",
                        principalColumn: "IdDisponibilidadViaje",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfil_Especialidad_FkEspecialidadId",
                        column: x => x.FkEspecialidadId,
                        principalTable: "Especialidad",
                        principalColumn: "IdEspecialidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfil_Genero_FkGeneroId",
                        column: x => x.FkGeneroId,
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfil_NivelIngles_FkNivelInglesId",
                        column: x => x.FkNivelInglesId,
                        principalTable: "NivelIngles",
                        principalColumn: "IdNivelIngles",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Perfil_Seniority_FkSeniorityId",
                        column: x => x.FkSeniorityId,
                        principalTable: "Seniority",
                        principalColumn: "IdSeniority",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerfilSolicitud",
                columns: table => new
                {
                    IdPerfilSolicitud = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FkPerfilId = table.Column<int>(type: "int", nullable: false),
                    FkSolicitudId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilSolicitud", x => x.IdPerfilSolicitud);
                    table.ForeignKey(
                        name: "FK_PerfilSolicitud_Perfil_FkPerfilId",
                        column: x => x.FkPerfilId,
                        principalTable: "Perfil",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerfilSolicitud_Solicitud_FkSolicitudId",
                        column: x => x.FkSolicitudId,
                        principalTable: "Solicitud",
                        principalColumn: "IdSolicitud",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerfilTecnologia",
                columns: table => new
                {
                    IdPerfilTecnologia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FkPerfilId = table.Column<int>(type: "int", nullable: false),
                    FkTecnologiaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilTecnologia", x => x.IdPerfilTecnologia);
                    table.ForeignKey(
                        name: "FK_PerfilTecnologia_Perfil_FkPerfilId",
                        column: x => x.FkPerfilId,
                        principalTable: "Perfil",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerfilTecnologia_Tecnologia_FkTecnologiaId",
                        column: x => x.FkTecnologiaId,
                        principalTable: "Tecnologia",
                        principalColumn: "IdTecnologia",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "DisponibilidadViaje",
                columns: new[] { "IdDisponibilidadViaje", "Disponibilidad" },
                values: new object[,]
                {
                    { 1, "Si" },
                    { 2, "No" }
                });

            migrationBuilder.InsertData(
                table: "Especialidad",
                columns: new[] { "IdEspecialidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "Especialidad1" },
                    { 2, "Especialidad2" },
                    { 3, "Especialidad3" },
                    { 4, "Especialidad4" },
                    { 5, "Especialidad5" },
                    { 6, "Especialidad6" },
                    { 7, "Especialidad7" },
                    { 8, "Especialidad8" },
                    { 9, "Especialidad9" },
                    { 10, "Especialidad10" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "IdGenero", "Nombre" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Femenino" },
                    { 3, "Desconocido" },
                    { 4, "Helicoptero Apache" },
                    { 5, "Prefiero no decirlo" },
                    { 6, "LGBTTTIOQ" }
                });

            migrationBuilder.InsertData(
                table: "NivelIngles",
                columns: new[] { "IdNivelIngles", "Nivel" },
                values: new object[,]
                {
                    { 1, "Básico" },
                    { 2, "Básico-Intermedio" },
                    { 3, "Intermedio" },
                    { 4, "Intermedio-Avanzado" },
                    { 5, "Avanzado" }
                });

            migrationBuilder.InsertData(
                table: "Pais",
                columns: new[] { "IdPais", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pais1" },
                    { 2, "Pais2" },
                    { 3, "Pais3" },
                    { 4, "Pais4" },
                    { 5, "Pais5" },
                    { 6, "Pais6" },
                    { 7, "Pais7" },
                    { 8, "Pais8" },
                    { 9, "Pais9" },
                    { 10, "Pais10" }
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "IdRol", "NombreRol" },
                values: new object[,]
                {
                    { 1, "Administrador" },
                    { 2, "Gerente" },
                    { 3, "Empleado" },
                    { 4, "Persona" }
                });

            migrationBuilder.InsertData(
                table: "Seniority",
                columns: new[] { "IdSeniority", "Nombre" },
                values: new object[,]
                {
                    { 1, "Ssr+" },
                    { 2, "Jr+" },
                    { 3, "Mid+" }
                });

            migrationBuilder.InsertData(
                table: "Solicitud",
                columns: new[] { "IdSolicitud", "Apellidos", "Email", "Empresa", "Nombres", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido1", "correo1@example.com", "Empresa1", "Nombre1", 1234567890.0 },
                    { 2, "Apellido2", "correo2@example.com", "Empresa2", "Nombre2", 2345678901.0 },
                    { 3, "Apellido3", "correo3@example.com", "Empresa3", "Nombre3", 3456789012.0 },
                    { 4, "Apellido4", "correo4@example.com", "Empresa4", "Nombre4", 4567890123.0 },
                    { 5, "Apellido5", "correo5@example.com", "Empresa5", "Nombre5", 5678901234.0 },
                    { 6, "Apellido6", "correo6@example.com", "Empresa6", "Nombre6", 6789012345.0 },
                    { 7, "Apellido7", "correo7@example.com", "Empresa7", "Nombre7", 7890123456.0 },
                    { 8, "Apellido8", "correo8@example.com", "Empresa8", "Nombre8", 8901234567.0 },
                    { 9, "Apellido9", "correo9@example.com", "Empresa9", "Nombre9", 9012345678.0 },
                    { 10, "Apellido10", "correo10@example.com", "Empresa10", "Nombre10", 1234567890.0 }
                });

            migrationBuilder.InsertData(
                table: "Tecnologia",
                columns: new[] { "IdTecnologia", "Nombre" },
                values: new object[,]
                {
                    { 1, "Java" },
                    { 2, "JavaScript" },
                    { 3, "Python" },
                    { 4, "C#" },
                    { 5, "PHP" },
                    { 6, "Ruby" },
                    { 7, "Swift" },
                    { 8, "Kotlin" },
                    { 9, "TypeScript" },
                    { 10, "C++" },
                    { 11, "Vue.js" },
                    { 12, "React" },
                    { 13, "Angular" },
                    { 14, "Node.js" },
                    { 15, "Django" },
                    { 16, "Flask" },
                    { 17, "Express.js" },
                    { 18, "Laravel" },
                    { 19, "Spring Boot" },
                    { 20, "Ruby on Rails" },
                    { 21, ".NET Core" },
                    { 22, "Go" },
                    { 23, "Vue.js" },
                    { 24, "React Native" },
                    { 25, "Flutter" },
                    { 26, "jQuery" },
                    { 27, "Bootstrap" },
                    { 28, "Sass" },
                    { 29, "LESS" },
                    { 30, "Tailwind CSS" },
                    { 31, "Rust" },
                    { 32, "Dart" },
                    { 33, "Elixir" },
                    { 34, "Haskell" },
                    { 35, "Scala" },
                    { 36, "Erlang" },
                    { 37, "R" },
                    { 38, "Julia" },
                    { 39, "Groovy" },
                    { 40, "Clojure" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id_Usuario", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "britodelgado514@gmail.com", "1234", "Sicer Brito" },
                    { 2, "angedeveloper@gmail.com", "12345", "Angelica Morales" },
                    { 3, "lisethtorres969@gmail.com", "123456", "Konny Alucemna" }
                });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "IdDepartamento", "FkPaisId", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Departamento1" },
                    { 2, 1, "Departamento2" },
                    { 3, 2, "Departamento3" },
                    { 4, 2, "Departamento4" },
                    { 5, 3, "Departamento5" },
                    { 6, 3, "Departamento6" },
                    { 7, 4, "Departamento7" },
                    { 8, 4, "Departamento8" },
                    { 9, 5, "Departamento9" },
                    { 10, 5, "Departamento10" }
                });

            migrationBuilder.InsertData(
                table: "Ciudad",
                columns: new[] { "IdCiudad", "FkDepartamentoId", "Nombre" },
                values: new object[,]
                {
                    { 1, 1, "Ciudad1" },
                    { 2, 1, "Ciudad2" },
                    { 3, 2, "Ciudad3" },
                    { 4, 2, "Ciudad4" },
                    { 5, 3, "Ciudad5" },
                    { 6, 3, "Ciudad6" },
                    { 7, 4, "Ciudad7" },
                    { 8, 4, "Ciudad8" },
                    { 9, 5, "Ciudad9" },
                    { 10, 5, "Ciudad10" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "Apellidos", "Email", "FkDisponibilidadId", "FkEspecialidadId", "FkGeneroId", "FkNivelInglesId", "FkSeniorityId", "FkUbicacionId", "Nombres", "PretensionSalarialUSD" },
                values: new object[,]
                {
                    { 1, "Apellido1", "correo1@example.com", 1, 1, 1, 1, 1, 1, "Nombre1", 60000 },
                    { 2, "Apellido2", "correo2@example.com", 2, 2, 4, 2, 2, 2, "Nombre2", 7000 },
                    { 3, "Apellido3", "correo3@example.com", 1, 3, 1, 3, 3, 3, "Nombre3", 8000 },
                    { 4, "Apellido4", "correo4@example.com", 1, 2, 3, 2, 1, 1, "Nombre4", 5000 },
                    { 5, "Apellido5", "correo5@example.com", 2, 1, 2, 1, 2, 2, "Nombre5", 5000 }
                });

            migrationBuilder.InsertData(
                table: "PerfilSolicitud",
                columns: new[] { "IdPerfilSolicitud", "FkPerfilId", "FkSolicitudId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 1, 4 },
                    { 5, 2, 5 },
                    { 6, 3, 6 },
                    { 7, 1, 7 },
                    { 8, 2, 8 },
                    { 9, 3, 9 },
                    { 10, 1, 10 }
                });

            migrationBuilder.InsertData(
                table: "PerfilTecnologia",
                columns: new[] { "IdPerfilTecnologia", "FkPerfilId", "FkTecnologiaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 1, 4 },
                    { 5, 2, 5 },
                    { 6, 3, 6 },
                    { 7, 1, 7 },
                    { 8, 2, 8 },
                    { 9, 3, 9 },
                    { 10, 1, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_FkDepartamentoId",
                table: "Ciudad",
                column: "FkDepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_FkPaisId",
                table: "Departamento",
                column: "FkPaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkDisponibilidadId",
                table: "Perfil",
                column: "FkDisponibilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkEspecialidadId",
                table: "Perfil",
                column: "FkEspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkGeneroId",
                table: "Perfil",
                column: "FkGeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkNivelInglesId",
                table: "Perfil",
                column: "FkNivelInglesId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkSeniorityId",
                table: "Perfil",
                column: "FkSeniorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_FkUbicacionId",
                table: "Perfil",
                column: "FkUbicacionId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilSolicitud_FkPerfilId",
                table: "PerfilSolicitud",
                column: "FkPerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilSolicitud_FkSolicitudId",
                table: "PerfilSolicitud",
                column: "FkSolicitudId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilTecnologia_FkPerfilId",
                table: "PerfilTecnologia",
                column: "FkPerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilTecnologia_FkTecnologiaId",
                table: "PerfilTecnologia",
                column: "FkTecnologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UsuarioId",
                table: "RefreshToken",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Username",
                table: "Usuario",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosRoles_RolId",
                table: "UsuariosRoles",
                column: "RolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerfilSolicitud");

            migrationBuilder.DropTable(
                name: "PerfilTecnologia");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "UsuariosRoles");

            migrationBuilder.DropTable(
                name: "Solicitud");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Tecnologia");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ciudad");

            migrationBuilder.DropTable(
                name: "DisponibilidadViaje");

            migrationBuilder.DropTable(
                name: "Especialidad");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "NivelIngles");

            migrationBuilder.DropTable(
                name: "Seniority");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
