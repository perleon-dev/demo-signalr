#pragma checksum "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87be87cf2a64af39802564cbd6642315c7ade764"
// <auto-generated/>
#pragma warning disable 1591
namespace RegistroPrueba.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class ListaGenerica<TObject> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor"
 if (ListObject == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div>Cargando . . .</div>");
#nullable restore
#line 6 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor"
}
else if (ListObject.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>Sin registros</div>");
#nullable restore
#line 10 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor"
}
else
{
    foreach (var _object in ListObject) 
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 15 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor"
         Registro(_object)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\ListaGenerica.razor"
                          ;
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591