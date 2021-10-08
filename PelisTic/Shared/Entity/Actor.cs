using System;
using System.Diagnostics.SymbolStore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PelisTic.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ActorName{get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public Gender Gender{get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime BirthDate{get;set;}
        public int Nominations {get;set;}
        public string Biography {get;set;}
        public string Photo {get;set;}
        public List <PeliculaActor> PeliculaActor{get;set;}
        

    }

        public enum Gender{
        Femenino =0,
        Masculino=1
    }
}