#pragma checksum "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4534bdda277ed93012b3f0e9999d6474c69469fe"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar mb-5");
            __builder.AddAttribute(2, "role", "navigation");
            __builder.AddAttribute(3, "aria-label", "main navigation");
            __builder.AddAttribute(4, "b-t46nb3v0j2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "navbar-brand");
            __builder.AddAttribute(7, "b-t46nb3v0j2");
            __builder.AddMarkupContent(8, "<a class=\"navbar-item\" href=\"https://bulma.io\" b-t46nb3v0j2><img src=\"https://bulma.io/images/bulma-logo.png\" width=\"112\" height=\"28\" b-t46nb3v0j2></a>\r\n\r\n        ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "role", "button");
            __builder.AddAttribute(11, "class", "navbar-burger" + " " + (
#nullable restore
#line 7 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\NavMenu.razor"
                                               NavMenuClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "aria-label", "menu");
            __builder.AddAttribute(13, "aria-expanded", "false");
            __builder.AddAttribute(14, "data-target", "navbarBasicExample");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\NavMenu.razor"
                                                                                                                                                ( () => CollapseNavManu = !CollapseNavManu )

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "b-t46nb3v0j2");
            __builder.AddMarkupContent(17, "<span aria-hidden=\"true\" b-t46nb3v0j2></span>\r\n            <span aria-hidden=\"true\" b-t46nb3v0j2></span>\r\n            <span aria-hidden=\"true\" b-t46nb3v0j2></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "id", "navbarBasicExample");
            __builder.AddAttribute(21, "class", "navbar-menu" + " " + (
#nullable restore
#line 14 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\NavMenu.razor"
                                                     NavMenuClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-t46nb3v0j2");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "navbar-start");
            __builder.AddAttribute(25, "b-t46nb3v0j2");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "navbar-item");
            __builder.AddAttribute(28, "b-t46nb3v0j2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "nav-link");
            __builder.AddAttribute(31, "href", "");
            __builder.AddAttribute(32, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "D:\notocar\Apliaciones\demo-signalr\demo-signalr\RegistroPrueba\Client\Shared\NavMenu.razor"
                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(34, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-t46nb3v0j2></span> Home\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n\r\n            ");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "class", "navbar-item");
            __builder.AddAttribute(38, "b-t46nb3v0j2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "counter");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-t46nb3v0j2></span> Counter\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "class", "navbar-item");
            __builder.AddAttribute(47, "b-t46nb3v0j2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "fetchdata");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-t46nb3v0j2></span> Fetch data\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n        ");
            __builder.AddMarkupContent(54, @"<div class=""navbar-end"" b-t46nb3v0j2><div class=""navbar-item"" b-t46nb3v0j2><div class=""buttons"" b-t46nb3v0j2><a class=""button is-primary"" b-t46nb3v0j2><strong b-t46nb3v0j2>Sign up</strong></a>
                    <a class=""button is-light"" b-t46nb3v0j2>
                        Log in
                    </a></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
