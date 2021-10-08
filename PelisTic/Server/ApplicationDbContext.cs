using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PelisTic.Shared.Entity;
using System;

namespace PelisTic.Server
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Pelicula> Peliculas {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Actor> Actors {get;set;}
        public DbSet<CategoryMovie> CategoryMovie {get;set;}
        public DbSet<PeliculaActor> PeliculaActor {get;set;}
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
        }
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<CategoryMovie>().HasKey(x=> new {x.CategoryId, x.PeliculaId});
        modelBuilder.Entity<PeliculaActor>().HasKey(x=> new {x.PeliculaId, x.ActorId});
        base.OnModelCreating(modelBuilder);
        }
    }
}