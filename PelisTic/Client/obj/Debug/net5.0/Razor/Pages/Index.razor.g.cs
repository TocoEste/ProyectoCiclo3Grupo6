#pragma checksum "C:\ProyCicloIII\PelisTic\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0f2c851810329e7b5c62849da1d292667dd5c9"
// <auto-generated/>
#pragma warning disable 1591
namespace PelisTic.Client.Pages
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
#line 2 "C:\ProyCicloIII\PelisTic\Client\Pages\Index.razor"
using PelisTic.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.OpenComponent<PelisTic.Client.Pages.Components.PeliculaCardComponent>(2);
            __builder.AddAttribute(3, "Peliculas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<PelisTic.Shared.Entity.Pelicula>>(
#nullable restore
#line 5 "C:\ProyCicloIII\PelisTic\Client\Pages\Index.razor"
                                       Peliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\ProyCicloIII\PelisTic\Client\Pages\Index.razor"
      
    private List<Pelicula>Peliculas;
    protected override void OnInitialized(){
       Peliculas = pelicula.GetPelicula();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicesPelicula pelicula { get; set; }
    }
}
#pragma warning restore 1591