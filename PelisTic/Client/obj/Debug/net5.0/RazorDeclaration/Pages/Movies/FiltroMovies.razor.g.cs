// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PelisTic.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using PelisTic.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using PelisTic.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using PelisTic.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProyCicloIII\PelisTic\Client\_Imports.razor"
using PelisTic.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
using PelisTic.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class FiltroMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
       
    private List<Pelicula> Peliculas;
    string PeliculaNombre = "";
    string categorySelected = "";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool mejorCalificadas = false;

    protected override void OnInitialized()
    {
        Peliculas = pelicula.GetPelicula();
    }

    private List<Category> categories = new List<Category>();
    private void MovieNameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNuevasPeliculas();
        }
    }
    private void CargarNuevasPeliculas()
    {
        Peliculas = pelicula.GetPelicula().Where(x => x.PeliculaNombre.ToLower().Contains(PeliculaNombre.ToLower())).ToList();
        Console.WriteLine($"Nombre pelicula: {PeliculaNombre}");
        Console.WriteLine($"Categor??a seleccionada: {categorySelected}");
        Console.WriteLine($"En cartelera {enCartelera}");
        Console.WriteLine($"Futuros estrenos: {futurosEstrenos}");
        Console.WriteLine($"Mejor calificada: {mejorCalificadas}");
    }

    private void LimpiarCampos()
    {
        Peliculas = pelicula.GetPelicula();
        PeliculaNombre = "";
        categorySelected = "0";
        futurosEstrenos = false;
        enCartelera = false;
        mejorCalificadas = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicesPelicula pelicula { get; set; }
    }
}
#pragma warning restore 1591
