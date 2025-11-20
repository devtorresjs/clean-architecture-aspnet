using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tec.ProductCatalog.EFCore.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "Active"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageUrl", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pago de matrícula para estudiantes.", "https://example.com/images/matricula.jpg", "Matrícula Semestral", 350.00m, "Active", 9999 },
                    { 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suscripción anual a biblioteca virtual.", "https://example.com/images/biblioteca.jpg", "Acceso Biblioteca Digital", 45.00m, "Active", 9999 },
                    { 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emisión de certificado académico oficial.", "https://example.com/images/certificado.jpg", "Certificado de Estudios", 15.00m, "Active", 9999 },
                    { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acceso a curso virtual de inglés nivel básico.", "https://example.com/images/ingles_basico.jpg", "Curso de Inglés Básico", 120.00m, "Active", 500 },
                    { 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso completo de C# para principiantes.", "https://example.com/images/csharp.jpg", "Curso de Programación C#", 199.99m, "Active", 300 },
                    { 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uso de laboratorios en línea para prácticas.", "https://example.com/images/lab_virtual.jpg", "Acceso a Laboratorios Virtuales", 60.00m, "Active", 9999 },
                    { 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evaluación especial por suficiencia académica.", "https://example.com/images/examen.jpg", "Examen de Suficiencia", 25.00m, "Active", 9999 },
                    { 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acceso a tutorías personalizadas.", "https://example.com/images/tutorias.jpg", "Servicio de Tutorías", 75.00m, "Active", 500 },
                    { 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kit básico de materiales para laboratorio.", "https://example.com/images/material_lab.jpg", "Material de Laboratorio", 35.00m, "Active", 800 },
                    { 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso virtual de matemáticas avanzadas.", "https://example.com/images/matematica.jpg", "Curso de Matemática Avanzada", 150.00m, "Active", 400 },
                    { 11, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emisión de carnet para estudiantes.", "https://example.com/images/carnet.jpg", "Carnet Universitario", 10.00m, "Active", 9999 },
                    { 12, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acceso al estacionamiento del campus.", "https://example.com/images/parking.jpg", "Estacionamiento Mensual", 25.00m, "Active", 200 },
                    { 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paquete de 200 impresiones.", "https://example.com/images/impresiones.jpg", "Impresiones y Fotocopias", 8.50m, "Active", 9999 },
                    { 14, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Membresía mensual del gimnasio estudiantil.", "https://example.com/images/gimnasio.jpg", "Acceso a Gimnasio", 18.00m, "Active", 150 },
                    { 15, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taller presencial de desarrollo de liderazgo.", "https://example.com/images/liderazgo.jpg", "Taller de Liderazgo", 90.00m, "Active", 200 },
                    { 16, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Membresía mensual para sala de cómputo.", "https://example.com/images/computo.jpg", "Acceso a Sala de Cómputo", 12.00m, "Active", 500 },
                    { 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Licencia anual de software educativo.", "https://example.com/images/software.jpg", "Software Educativo", 70.00m, "Active", 400 },
                    { 18, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso práctico de robótica y electrónica.", "https://example.com/images/robotica.jpg", "Curso de Robótica", 220.00m, "Active", 150 },
                    { 19, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acceso anual al club universitario.", "https://example.com/images/debate.jpg", "Membresía Club de Debate", 30.00m, "Active", 350 },
                    { 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso presencial de fotografía artística.", "https://example.com/images/fotografia.jpg", "Curso de Fotografía", 160.00m, "Active", 100 },
                    { 21, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taller de redacción académica.", "https://example.com/images/redaccion.jpg", "Taller de Redacción", 40.00m, "Active", 250 },
                    { 22, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paquete de materiales escolares.", "https://example.com/images/material_didactico.jpg", "Material Didáctico", 20.00m, "Active", 900 },
                    { 23, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acceso premium a plataforma virtual.", "https://example.com/images/plataforma.jpg", "Acceso Plataforma Virtual", 50.00m, "Active", 9999 },
                    { 24, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Póliza anual de seguro para estudiantes.", "https://example.com/images/seguro.jpg", "Seguro Estudiantil", 35.00m, "Active", 9999 },
                    { 25, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso completo de diseño gráfico.", "https://example.com/images/diseno.jpg", "Curso de Diseño Gráfico", 180.00m, "Active", 180 },
                    { 26, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clase grupal de instrumentos musicales.", "https://example.com/images/musica.jpg", "Taller de Música", 55.00m, "Active", 120 },
                    { 27, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso introductorio de gastronomía.", "https://example.com/images/cocina.jpg", "Curso de Cocina", 95.00m, "Active", 140 },
                    { 28, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Membresía mensual al laboratorio químico.", "https://example.com/images/lab_quimica.jpg", "Acceso Laboratorio de Química", 30.00m, "Active", 200 },
                    { 29, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seminario avanzado para emprendedores.", "https://example.com/images/emprendimiento.jpg", "Taller de Emprendimiento", 110.00m, "Active", 170 },
                    { 30, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Curso avanzado de Microsoft Excel.", "https://example.com/images/excel.jpg", "Curso de Excel Profesional", 75.00m, "Active", 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
