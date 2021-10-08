namespace  PelisTic.Shared.Entity
{
    public class PeliculaActor
    {
        public int ActorId{get;set;}
        public int PeliculaId{get;set;}
        public Actor Actor {get;set;}
        public Pelicula Pelicula{get;set;}
        public int OrderCredits{get;set;}
        public string Character{get;set;}
    }
}