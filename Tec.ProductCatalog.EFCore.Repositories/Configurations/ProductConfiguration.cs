namespace Tec.ProductCatalog.EFCore.Repositories.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(p => p.Id);

            entity.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(p => p.Description)
                .HasMaxLength(500);

            entity.Property(p => p.Price)
                .HasPrecision(10, 2)
                .IsRequired();

            entity.Property(p => p.Stock)
                .IsRequired();

            entity.Property(p => p.ImageUrl)
                .HasMaxLength(300);

            entity.Property(p => p.Status)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("Active");

            entity.Property(p => p.CreatedAt)
                .IsRequired();

            entity.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Matrícula Semestral",
                    Description = "Pago de matrícula para estudiantes.",
                    Price = 350.00m,
                    Stock = 9999,
                    ImageUrl = "https://example.com/images/matricula.jpg",
                    Status = "Active",
                    CreatedAt = new DateTime(2024, 01, 01)
                },
     new Product
     {
         Id = 2,
         Name = "Acceso Biblioteca Digital",
         Description = "Suscripción anual a biblioteca virtual.",
         Price = 45.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/biblioteca.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 02)
     },
     new Product
     {
         Id = 3,
         Name = "Certificado de Estudios",
         Description = "Emisión de certificado académico oficial.",
         Price = 15.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/certificado.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 03)
     },
     new Product
     {
         Id = 4,
         Name = "Curso de Inglés Básico",
         Description = "Acceso a curso virtual de inglés nivel básico.",
         Price = 120.00m,
         Stock = 500,
         ImageUrl = "https://example.com/images/ingles_basico.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 04)
     },
     new Product
     {
         Id = 5,
         Name = "Curso de Programación C#",
         Description = "Curso completo de C# para principiantes.",
         Price = 199.99m,
         Stock = 300,
         ImageUrl = "https://example.com/images/csharp.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 05)
     },
     new Product
     {
         Id = 6,
         Name = "Acceso a Laboratorios Virtuales",
         Description = "Uso de laboratorios en línea para prácticas.",
         Price = 60.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/lab_virtual.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 06)
     },
     new Product
     {
         Id = 7,
         Name = "Examen de Suficiencia",
         Description = "Evaluación especial por suficiencia académica.",
         Price = 25.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/examen.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 07)
     },
     new Product
     {
         Id = 8,
         Name = "Servicio de Tutorías",
         Description = "Acceso a tutorías personalizadas.",
         Price = 75.00m,
         Stock = 500,
         ImageUrl = "https://example.com/images/tutorias.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 08)
     },
     new Product
     {
         Id = 9,
         Name = "Material de Laboratorio",
         Description = "Kit básico de materiales para laboratorio.",
         Price = 35.00m,
         Stock = 800,
         ImageUrl = "https://example.com/images/material_lab.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 09)
     },
     new Product
     {
         Id = 10,
         Name = "Curso de Matemática Avanzada",
         Description = "Curso virtual de matemáticas avanzadas.",
         Price = 150.00m,
         Stock = 400,
         ImageUrl = "https://example.com/images/matematica.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 10)
     },
     new Product
     {
         Id = 11,
         Name = "Carnet Universitario",
         Description = "Emisión de carnet para estudiantes.",
         Price = 10.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/carnet.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 11)
     },
     new Product
     {
         Id = 12,
         Name = "Estacionamiento Mensual",
         Description = "Acceso al estacionamiento del campus.",
         Price = 25.00m,
         Stock = 200,
         ImageUrl = "https://example.com/images/parking.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 12)
     },
     new Product
     {
         Id = 13,
         Name = "Impresiones y Fotocopias",
         Description = "Paquete de 200 impresiones.",
         Price = 8.50m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/impresiones.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 13)
     },
     new Product
     {
         Id = 14,
         Name = "Acceso a Gimnasio",
         Description = "Membresía mensual del gimnasio estudiantil.",
         Price = 18.00m,
         Stock = 150,
         ImageUrl = "https://example.com/images/gimnasio.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 14)
     },
     new Product
     {
         Id = 15,
         Name = "Taller de Liderazgo",
         Description = "Taller presencial de desarrollo de liderazgo.",
         Price = 90.00m,
         Stock = 200,
         ImageUrl = "https://example.com/images/liderazgo.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 15)
     },
     new Product
     {
         Id = 16,
         Name = "Acceso a Sala de Cómputo",
         Description = "Membresía mensual para sala de cómputo.",
         Price = 12.00m,
         Stock = 500,
         ImageUrl = "https://example.com/images/computo.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 16)
     },
     new Product
     {
         Id = 17,
         Name = "Software Educativo",
         Description = "Licencia anual de software educativo.",
         Price = 70.00m,
         Stock = 400,
         ImageUrl = "https://example.com/images/software.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 17)
     },
     new Product
     {
         Id = 18,
         Name = "Curso de Robótica",
         Description = "Curso práctico de robótica y electrónica.",
         Price = 220.00m,
         Stock = 150,
         ImageUrl = "https://example.com/images/robotica.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 18)
     },
     new Product
     {
         Id = 19,
         Name = "Membresía Club de Debate",
         Description = "Acceso anual al club universitario.",
         Price = 30.00m,
         Stock = 350,
         ImageUrl = "https://example.com/images/debate.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 19)
     },
     new Product
     {
         Id = 20,
         Name = "Curso de Fotografía",
         Description = "Curso presencial de fotografía artística.",
         Price = 160.00m,
         Stock = 100,
         ImageUrl = "https://example.com/images/fotografia.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 20)
     },
     new Product
     {
         Id = 21,
         Name = "Taller de Redacción",
         Description = "Taller de redacción académica.",
         Price = 40.00m,
         Stock = 250,
         ImageUrl = "https://example.com/images/redaccion.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 21)
     },
     new Product
     {
         Id = 22,
         Name = "Material Didáctico",
         Description = "Paquete de materiales escolares.",
         Price = 20.00m,
         Stock = 900,
         ImageUrl = "https://example.com/images/material_didactico.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 22)
     },
     new Product
     {
         Id = 23,
         Name = "Acceso Plataforma Virtual",
         Description = "Acceso premium a plataforma virtual.",
         Price = 50.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/plataforma.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 23)
     },
     new Product
     {
         Id = 24,
         Name = "Seguro Estudiantil",
         Description = "Póliza anual de seguro para estudiantes.",
         Price = 35.00m,
         Stock = 9999,
         ImageUrl = "https://example.com/images/seguro.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 24)
     },
     new Product
     {
         Id = 25,
         Name = "Curso de Diseño Gráfico",
         Description = "Curso completo de diseño gráfico.",
         Price = 180.00m,
         Stock = 180,
         ImageUrl = "https://example.com/images/diseno.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 25)
     },
     new Product
     {
         Id = 26,
         Name = "Taller de Música",
         Description = "Clase grupal de instrumentos musicales.",
         Price = 55.00m,
         Stock = 120,
         ImageUrl = "https://example.com/images/musica.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 26)
     },
     new Product
     {
         Id = 27,
         Name = "Curso de Cocina",
         Description = "Curso introductorio de gastronomía.",
         Price = 95.00m,
         Stock = 140,
         ImageUrl = "https://example.com/images/cocina.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 27)
     },
     new Product
     {
         Id = 28,
         Name = "Acceso Laboratorio de Química",
         Description = "Membresía mensual al laboratorio químico.",
         Price = 30.00m,
         Stock = 200,
         ImageUrl = "https://example.com/images/lab_quimica.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 28)
     },
     new Product
     {
         Id = 29,
         Name = "Taller de Emprendimiento",
         Description = "Seminario avanzado para emprendedores.",
         Price = 110.00m,
         Stock = 170,
         ImageUrl = "https://example.com/images/emprendimiento.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 29)
     },
     new Product
     {
         Id = 30,
         Name = "Curso de Excel Profesional",
         Description = "Curso avanzado de Microsoft Excel.",
         Price = 75.00m,
         Stock = 500,
         ImageUrl = "https://example.com/images/excel.jpg",
         Status = "Active",
         CreatedAt = new DateTime(2024, 01, 30)
     }
 );

        }
    }
}
