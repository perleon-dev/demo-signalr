#pragma checksum "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918d5e7157c9ae63dad93b297ee66fe0e589b461"
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
#line 1 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Modal : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal" + " " + (
#nullable restore
#line 1 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor"
                   ClassModal

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal-background");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 2 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor"
                                            EventoModal

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-card");
            __builder.OpenElement(8, "header");
            __builder.AddAttribute(9, "class", "modal-card-head pb-3");
            __builder.OpenElement(10, "p");
            __builder.AddAttribute(11, "class", "modal-card-title");
            __builder.AddContent(12, 
#nullable restore
#line 5 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor"
                                         Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "delete");
            __builder.AddAttribute(16, "aria-label", "close");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor"
                                                                EventoModal

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#nullable restore
#line 8 "D:\notocar\Apliaciones\demo-signalr\RegistroPrueba\Client\Shared\Modal.razor"
         Formulario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
