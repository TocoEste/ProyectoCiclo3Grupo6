#pragma checksum "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50d243f265ddce590d12ad87e0eac8f7de78d8b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row g-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group mb-2");
            __builder.AddMarkupContent(8, "<label for=\"PeliculaNombre\" class=\"form-floating\">Nombre pelicula</label>\r\n                    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                       (KeyboardEventArgs e)=>MovieNameKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "id", "PeliculaNombre");
            __builder.AddAttribute(14, "placeholder", "Buscar pelicula");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                                    PeliculaNombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PeliculaNombre = __value, PeliculaNombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group mb-2");
            __builder.AddMarkupContent(22, "<label for=\"PeliculaNombre\" class=\"form-floating\">Categoria</label>\r\n                    ");
            __builder.OpenElement(23, "select");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                                        categorySelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => categorySelected = __value, categorySelected));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(27, "option");
            __builder.AddAttribute(28, "value", "0");
            __builder.AddMarkupContent(29, "Seleccione una categoría");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", "1");
            __builder.AddMarkupContent(33, "Acción");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "2");
            __builder.AddMarkupContent(37, "Ciencia ficción");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "3");
            __builder.AddContent(41, "Comedia");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "4");
            __builder.AddContent(45, "Documental");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "5");
            __builder.AddContent(49, "Drama");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "6");
            __builder.AddContent(53, "Musical");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "7");
            __builder.AddContent(57, "Romance");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "8");
            __builder.AddContent(61, "Suspenso");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "9");
            __builder.AddContent(65, "Terror");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                         foreach (var item in categories)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "value", 
#nullable restore
#line 32 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(68, 
#nullable restore
#line 32 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                                      item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "row mb-3 justify-content-md-center");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "col");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "input-group mb-3");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "input-group-prepend");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-check");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "checkbox");
            __builder.AddAttribute(82, "aria-label", "Checkbox for following text input");
            __builder.AddAttribute(83, "id", "estrenos");
            __builder.AddAttribute(84, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                   futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.AddMarkupContent(87, "<label class=\"form-check-label\" for=\"estrenos\"><small>Futuros estrenos</small></label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "input-group mb-3");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "input-group-prepend");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "form-check");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "checkbox");
            __builder.AddAttribute(99, "aria-label", "Checkbox for following text input");
            __builder.AddAttribute(100, "id", "cartelera");
            __builder.AddAttribute(101, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                   enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.AddMarkupContent(104, "<label class=\"form-check-label\" for=\"cartelera\"><small>En cartelera</small></label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "input-group mb-3");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "input-group-prepend");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-check");
            __builder.OpenElement(114, "input");
            __builder.AddAttribute(115, "type", "checkbox");
            __builder.AddAttribute(116, "aria-label", "Checkbox for following text input");
            __builder.AddAttribute(117, "id", "mejor_calificadas");
            __builder.AddAttribute(118, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                   mejorCalificadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mejorCalificadas = __value, mejorCalificadas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                        ");
            __builder.AddMarkupContent(121, "<label class=\"form-check-label\" for=\"mejor_calificadas\"><small>Mejor calificadas</small></label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n    ");
            __builder.OpenElement(123, "button");
            __builder.AddAttribute(124, "type", "button");
            __builder.AddAttribute(125, "class", "btn btn-dark mb-2 btn-sm");
            __builder.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                                                     CargarNuevasPeliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(127, "\r\n        Buscar\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n\r\n    ");
            __builder.OpenElement(129, "button");
            __builder.AddAttribute(130, "type", "button");
            __builder.AddAttribute(131, "class", "btn btn-danger mb-2 btn-sm");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                                                       LimpiarCampos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(133, "\r\n        Limpiar campos\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
            __builder.OpenComponent<PelisTic.Client.Pages.Components.PeliculaCardComponent>(135);
            __builder.AddAttribute(136, "Peliculas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<PelisTic.Shared.Entity.Pelicula>>(
#nullable restore
#line 83 "C:\ProyCicloIII\PelisTic\Client\Pages\Movies\FiltroMovies.razor"
                                  Peliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
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
        Console.WriteLine($"Categoría seleccionada: {categorySelected}");
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
