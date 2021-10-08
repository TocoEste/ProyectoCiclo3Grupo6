using System;
using System.Collections.Generic;
using PelisTic.Shared.Entity;
namespace PelisTic.Client.Services
{
    public class ServiceActor: IServiceActor
    {
       public List <Actor> GetActors(){
           return new List<Actor>{
               new Actor(){ActorName = "Robert De Niro", Gender = Gender.Masculino,BirthDate= new DateTime(1943,08,17), Nominations = 23,Biography="Biografía...", Photo="/images/Actor/deniro.jpg"},
               new Actor(){ActorName = "Robert Downey Jr", Gender = Gender.Masculino,BirthDate= new DateTime(1943,08,17), Nominations = 12,Biography="Biografía...", Photo="/images/Actor/downey.png"}
           };
       }
    }
}