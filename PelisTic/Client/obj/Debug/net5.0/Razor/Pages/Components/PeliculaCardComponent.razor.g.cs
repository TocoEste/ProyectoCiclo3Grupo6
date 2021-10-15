#pragma checksum "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9baeb28bd67df5dc0ba8fe8c681589818666d7"
// <auto-generated/>
#pragma warning disable 1591
namespace PelisTic.Client.Pages.Components
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
    public partial class PeliculaCardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<br>\r\n    <br>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row mb-3");
#nullable restore
#line 7 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
             foreach (var pelicula in Peliculas)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row row-cols-1 row-cols-md-3 g-4");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body d-flex flex-column align-items-start");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card h-100");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 13 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
                                           pelicula.PeliculaImagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "img-thumbnail-box-shadow");
            __builder.AddAttribute(18, "alt", "...");
            __builder.AddAttribute(19, "height");
            __builder.AddAttribute(20, "width", "150");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "h3 card-title fw-bold");
            __builder.AddContent(26, 
#nullable restore
#line 15 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
                                                                      pelicula.PeliculaNombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                    ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text text-success");
            __builder.AddContent(30, 
#nullable restore
#line 16 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
                                                                       pelicula.PeliculaSinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "                                    \r\n                                    ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "card-text");
            __builder.AddContent(34, 
#nullable restore
#line 17 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
                                                          pelicula.PeliculaStore

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.AddMarkupContent(36, "<a href=\"#\" class=\"btn btn-success\">Ver pelicula</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card-footer");
            __builder.OpenElement(40, "small");
            __builder.AddAttribute(41, "class", "text-muted");
            __builder.AddContent(42, 
#nullable restore
#line 21 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
                                                               pelicula.Premier

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                <br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\PeliculaCardComponent.razor"
      
    [Parameter] public List<Pelicula> Peliculas{get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591