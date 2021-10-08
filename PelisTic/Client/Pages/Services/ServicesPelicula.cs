using System;
using System.Collections.Generic;
using PelisTic.Shared.Entity;

namespace PelisTic.Client.Services
{
    public class ServicesPelicula: IServicesPelicula
    {
        public List<Pelicula>GetPelicula(){
            return new List<Pelicula>(){
                new Pelicula(){PeliculaNombre="Amor Eterno", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/amor1.jpg",  PeliculaStore = 10, Premier=new DateTime(2014,02,14)},
                new Pelicula(){PeliculaNombre="Aquel Verano", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/Aquel.jpg",  PeliculaStore = 10, Premier=new DateTime(2021,07,09)},
                new Pelicula(){PeliculaNombre="El Secreto de Adaline", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/secreto1.jpg",  PeliculaStore = 10, Premier=new DateTime(2015,04,30)},
                new Pelicula(){PeliculaNombre="Hampstead una Cita en el parque", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/life.jpg",  PeliculaStore = 10, Premier=new DateTime(2017,06,23)},
                new Pelicula(){PeliculaNombre="El stand de los besos 3", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/primer.jpg",  PeliculaStore = 10, Premier=new DateTime(2021,08,11)},
                new Pelicula(){PeliculaNombre="Nosotros en la Noche", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/Nosotros.jpg",  PeliculaStore = 10, Premier=new DateTime(2017,09,01)},
                new Pelicula(){PeliculaNombre="Querido John", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/Querido.jpg",  PeliculaStore = 10, Premier=new DateTime(2010,04,23)},
                new Pelicula(){PeliculaNombre="Un Reino Unido", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/reino.jpg",  PeliculaStore = 10, Premier=new DateTime(2016,09,09)},
                new Pelicula(){PeliculaNombre="Votos de Amor", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/Votos.jpg",  PeliculaStore = 10, Premier=new DateTime(2012,02,06)},
                new Pelicula(){PeliculaNombre="Cincuenta sombras más oscuras", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/cincuenta1.jpg",  PeliculaStore = 10, Premier=new DateTime(2017,02,10)},
                new Pelicula(){PeliculaNombre="La Magia de la Isla", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/magia.jpg",  PeliculaStore= 8, Premier=new DateTime(2021,04,16)},
                new Pelicula(){PeliculaNombre="Yo antes de ti", PeliculaSinopsis="", PeliculaImagen="/images/peliculas/Antes.jpg",  PeliculaStore = 10, Premier=new DateTime(2016,06,03)}
            };
        }
    }
}