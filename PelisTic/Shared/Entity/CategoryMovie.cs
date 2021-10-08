namespace PelisTic.Shared.Entity
{
    public class CategoryMovie
    {
        public int PeliculaId{get;set;}
        public int CategoryId{get;set;}
        public Category Category {get;set;}
        public Pelicula Pelicula{get;set;}
    }
}