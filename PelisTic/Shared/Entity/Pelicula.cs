using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace PelisTic.Shared.Entity{

    public class Pelicula
    {
        public int Id{get;set;}
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public string PeliculaNombre {get;set;}
        public bool EnCartelera {get;set;}
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public string PeliculaSinopsis {get;set;}
        public string PeliculaImagen {get;set;}
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public int PeliculaStore {get;set;}
        public DateTime? Premier {get;set;}
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public string Trailer {get;set;}
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public List <CategoryMovie> CategoriesMovie{get;set;} = new List <CategoryMovie> ();
        public List <PeliculaActor> PeliculaActor{get;set;}
        public string ShortPeliculaNombre
        {
            get{
                if (string.IsNullOrWhiteSpace(PeliculaNombre))
                {
                    return null;
                }
                if (PeliculaNombre.Length > 60){
                    return PeliculaNombre.Substring(0,60)+ "...";
                }else{
                    return PeliculaNombre;
                }
            }
        }
    }

}