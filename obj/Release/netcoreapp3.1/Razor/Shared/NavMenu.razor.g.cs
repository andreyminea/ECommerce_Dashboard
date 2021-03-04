#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78b1d2a76725e7368c9350094a66df10adf40b6"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Pages.Products_Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>ControlDashboard</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
                                             ToogleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
                                        ToogleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-1");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "javascript: void(0)");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
                                                                           ()=>expandOrders = !expandOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-task\" aria-hidden=\"true\"></span>\r\n                Orders\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 15 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
             if (expandOrders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "123");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n                            <span class=\"oi oi-eye\" aria-hidden=\"true\"></span>\r\n                            See all\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(41);
            __builder.AddAttribute(42, "class", "nav-link");
            __builder.AddAttribute(43, "href", "123");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                            <span class=\"oi oi-fire\" aria-hidden=\"true\"></span>\r\n                            Pending\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", "nav-item px-3");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "nav-link");
            __builder.AddAttribute(53, "href", "123");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                            <span class=\"oi oi-paperclip\" aria-hidden=\"true\"></span>\r\n                            Resolved\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 35 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "class", "nav-item px-1");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(63);
            __builder.AddAttribute(64, "class", "nav-link");
            __builder.AddAttribute(65, "href", "javascript: void(0)");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
                                                                           ()=>expandProducts = !expandProducts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n                <span class=\"oi oi-box\" aria-hidden=\"true\"></span>\r\n                Products\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 42 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
             if (expandProducts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "nav-item px-3");
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
            __builder.AddAttribute(75, "class", "nav-link");
            __builder.AddAttribute(76, "href", "addproduct");
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n                            <span class=\"oi oi-plus\" aria-hidden=\"true\"></span>\r\n                            Add\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "li");
            __builder.AddAttribute(82, "class", "nav-item px-3");
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(84);
            __builder.AddAttribute(85, "class", "nav-link");
            __builder.AddAttribute(86, "href", "viewproducts");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(88, "\r\n                            <span class=\"oi oi-clipboard\" aria-hidden=\"true\"></span>\r\n                            View\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 56 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item px-1");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(96);
            __builder.AddAttribute(97, "class", "nav-link");
            __builder.AddAttribute(98, "href", "templates");
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span>\r\n                Templates\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "P:\Backend\ControlDashboard\ControlDashboard\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private bool expandProducts = false;
    private bool expandOrders = false;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    private void ToogleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
