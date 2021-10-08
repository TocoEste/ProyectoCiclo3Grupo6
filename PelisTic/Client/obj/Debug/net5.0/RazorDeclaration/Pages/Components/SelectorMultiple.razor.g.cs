// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\SelectorMultiple.razor"
using PelisTic.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class SelectorMultiple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\SelectorMultiple.razor"
       
    private string removerTodoTexto = "<<";
    private string pasarTodoTexto = ">>";

    [Parameter]
    public List<SelectorMultipleModel> NoSeleccionados { get; set; }
    = new List<SelectorMultipleModel>();

    [Parameter]
    public List<SelectorMultipleModel> Seleccionados { get; set; }
    = new List<SelectorMultipleModel>();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\SelectorMultiple.razor"
                                                                            
    private void Seleccionar(SelectorMultipleModel item)
    {
        NoSeleccionados.Remove(item);
        Seleccionados.Add(item);
    }
    private void Deseleccionar(SelectorMultipleModel item)
    {
        Seleccionados.Remove(item);
        NoSeleccionados.Add(item);
    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\ProyCicloIII\PelisTic\Client\Pages\Components\SelectorMultiple.razor"
                                                                 
    private void SeleccionarTodo()
    {
        Seleccionados.AddRange(NoSeleccionados);
        NoSeleccionados.Clear();
    }
    private void DeseleccionarTodo()
    {
        NoSeleccionados.AddRange(Seleccionados);
        Seleccionados.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
