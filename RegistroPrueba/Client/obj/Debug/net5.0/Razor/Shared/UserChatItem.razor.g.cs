#pragma checksum "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\UserChatItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "241f5567111d3a95eb30a947707b1ce030ec0973"
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
#line 1 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\_Imports.razor"
using RegistroPrueba.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class UserChatItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", "panel-block is-active");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\UserChatItem.razor"
                                           EnviarMensajeUsuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "<span class=\"panel-icon has-text-success-dark\"><i class=\"fas fa-user\" aria-hidden=\"true\"></i></span>\r\n    ");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\UserChatItem.razor"
     User.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
