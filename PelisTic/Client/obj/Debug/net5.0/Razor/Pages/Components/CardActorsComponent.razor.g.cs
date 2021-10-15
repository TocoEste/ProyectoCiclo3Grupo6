#pragma checksum "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c14dcb76e640039e47c0105bee2185b055b876a"
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
    public partial class CardActorsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h6>Actores</h6>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row mb-3");
#nullable restore
#line 5 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
             foreach (var actor in Actors)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card mb-3");
            __builder.AddAttribute(9, "style", "max-width: 540px;");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row g-0");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-4");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 10 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                       actor.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "img-fluid rounded-start");
            __builder.AddAttribute(17, "alt", "...");
            __builder.AddAttribute(18, "height");
            __builder.AddAttribute(19, "width");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body d-flex flex-column align-items-center");
            __builder.OpenElement(23, "h5");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 13 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                                   actor.ActorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, " \r\n                           ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "card-text");
            __builder.AddContent(29, 
#nullable restore
#line 14 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                                 actor.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                           ");
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "card-text");
            __builder.AddContent(33, 
#nullable restore
#line 15 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                                 actor.Nominations

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                           ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "card-text");
            __builder.AddContent(37, 
#nullable restore
#line 16 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                                 actor.Biography

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-footer");
            __builder.OpenElement(41, "small");
            __builder.AddAttribute(42, "class", "text-muted");
            __builder.AddContent(43, ">");
            __builder.AddContent(44, 
#nullable restore
#line 19 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
                                                        actor.BirthDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"

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
#line 29 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\CardActorsComponent.razor"
      
    [Parameter] public List<Actor> Actors{get;set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591