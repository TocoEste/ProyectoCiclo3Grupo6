using System.Collections.Generic;
using PelisTic.Shared.Entity;

namespace PelisTic.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}