using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamenApisApp.Models;

public partial class Examen2Context : DbContext
{
    public Examen2Context()
    {
    }

    public Examen2Context(DbContextOptions<Examen2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__producto__07F4A132DC0B02DD");

            entity.ToTable("producto");

            entity.Property(e => e.IdProducto)
                .ValueGeneratedNever()
                .HasColumnName("idProducto");
            entity.Property(e => e.Categoria).HasColumnName("categoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
        });

        modelBuilder.Entity<Producto>().HasData(
    new Producto { IdProducto = 1, Descripcion = "Perfume con aroma a blueberry.", Nombre = "BlueBerry Perfume", Precio = 25, Categoria = "Perfumes" },
    new Producto { IdProducto = 2, Descripcion = "Perfume con aroma a strawberry.", Nombre = "Strawberry Perfume", Precio = 30, Categoria = "Perfumes" },
    new Producto { IdProducto = 3, Descripcion = "Perfume con aroma a cherry.", Nombre = "Cherry Perfume", Precio = 28, Categoria = "Perfumes" },
    new Producto { IdProducto = 4, Descripcion = "Perfume florar, con notas de lavender.", Nombre = "Lavender Perfume", Precio = 30, Categoria = "Perfumes" },
    new Producto { IdProducto = 5, Descripcion = "Facial Cleanser con extractos de cucumber o roses.", Nombre = "Facial Cleanser", Precio = 50, Categoria = "Skincare" },
    new Producto { IdProducto = 6, Descripcion = "Lip balm con extracto de rosas y miel.", Nombre = "Lipbalm", Precio = 15, Categoria = "Skincare" },
    new Producto { IdProducto = 7, Descripcion = "Facial Scrub, deja tu piel suave.", Nombre = "Facial Scrub", Precio = 55, Categoria = "Skincare" },
    new Producto { IdProducto = 8, Descripcion = "Toner, refresca y prepara la piel.", Nombre = "Toner", Precio = 48, Categoria = "Skincare" },
    new Producto { IdProducto = 9, Descripcion = "Face Cream, hidrata y portege tu piel.", Nombre = "Face Cream", Precio = 52, Categoria = "Skincare" },
    new Producto { IdProducto = 10, Descripcion = "Gloss, hidrata y pigmenta los labios.", Nombre = "Gloss", Precio = 22, Categoria = "Make-up" },
    new Producto { IdProducto = 11, Descripcion = "Kit BT21, contiene una base de maquillage.", Nombre = "Kit BT21", Precio = 60, Categoria = "Make-up" },
    new Producto { IdProducto = 12, Descripcion = "Blush, dale un color natural a tus mejillas.", Nombre = "Kit BT21", Precio = 26, Categoria = "Make-up" },
    new Producto { IdProducto = 13, Descripcion = "Blush duo, duo de dos rubores.", Nombre = "Blush duo", Precio = 30, Categoria = "Make-up" }
);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
