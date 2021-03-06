// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PelisTic.Server;

namespace PelisTic.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PelisTic.Shared.Entity.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Nominations")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.CategoryMovie", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("CategoryMovie");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<string>("PeliculaImagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeliculaNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PeliculaSinopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PeliculaStore")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Premier")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderCredits")
                        .HasColumnType("int");

                    b.HasKey("PeliculaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("PeliculaActor");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.CategoryMovie", b =>
                {
                    b.HasOne("PelisTic.Shared.Entity.Category", "Category")
                        .WithMany("CategoriesMovie")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PelisTic.Shared.Entity.Pelicula", "Pelicula")
                        .WithMany("CategoriesMovie")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.PeliculaActor", b =>
                {
                    b.HasOne("PelisTic.Shared.Entity.Actor", "Actor")
                        .WithMany("PeliculaActor")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PelisTic.Shared.Entity.Pelicula", "Pelicula")
                        .WithMany("PeliculaActor")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.Actor", b =>
                {
                    b.Navigation("PeliculaActor");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.Category", b =>
                {
                    b.Navigation("CategoriesMovie");
                });

            modelBuilder.Entity("PelisTic.Shared.Entity.Pelicula", b =>
                {
                    b.Navigation("CategoriesMovie");

                    b.Navigation("PeliculaActor");
                });
#pragma warning restore 612, 618
        }
    }
}
