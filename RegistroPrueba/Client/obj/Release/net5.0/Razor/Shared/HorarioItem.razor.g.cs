#pragma checksum "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "167f3819e78acaac053bc6d122c7e123845a51ea"
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
    public partial class HorarioItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "column is-3-widescreen is-4-desktop is-6-tablet ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<div class=\"card-image\"><figure class=\"image is-4by3 mx-0\"><img src=\"https://bulma.io/images/placeholders/1280x960.png\" alt=\"Placeholder image\"></figure></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-content");
            __builder.AddMarkupContent(7, @"<div class=""media""><div class=""media-left""><figure class=""image is-48x48 mx-0""><img src=""https://bulma.io/images/placeholders/96x96.png"" alt=""Placeholder image""></figure></div>
                <div class=""media-content""><p class=""title is-4"">John Smith</p>
                    <p class=""subtitle is-6"">johnsmith</p></div></div>

            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content");
            __builder.AddMarkupContent(10, "\r\n                Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n                Phasellus nec iaculis mauris. ");
            __builder.AddMarkupContent(11, "<a>bulmaio</a>.\r\n                ");
            __builder.AddMarkupContent(12, "<a href=\"#\">#css</a> ");
            __builder.AddMarkupContent(13, "<a href=\"#\">#responsive</a>\r\n                <br>\r\n                ");
            __builder.OpenElement(14, "time");
            __builder.AddAttribute(15, "datetime", "2016-1-1");
            __builder.AddContent(16, 
#nullable restore
#line 26 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                                           Horario.FechaHorarioInicio

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " - ");
            __builder.AddContent(18, 
#nullable restore
#line 26 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                                                                         Horario.FechaHorarioFin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content pt-0");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "buttons are-small");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "button is-success");
            __builder.AddAttribute(26, "disabled", 
#nullable restore
#line 30 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                                                                  !Horario.Disponible

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                                                                                                  EscogerHorario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Realizar Recerva");
            __builder.CloseElement();
#nullable restore
#line 32 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                     if (AnularRecerva)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "button is-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                                                                   CancelarHorario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Anular Recerva");
            __builder.CloseElement();
#nullable restore
#line 35 "D:\notocar\Apliaciones\RetosCSharp\SolicitarMotorisado\RegistroPrueba\Client\Shared\HorarioItem.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
