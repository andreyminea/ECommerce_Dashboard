#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\ItemFeatureTextBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "360067f9a8defa4c13990e76d39549819461c8a7"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Products_Components.FeaturesPage_Components
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
    public partial class ItemFeatureTextBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddAttribute(2, "style", "padding:inherit;");
            __builder.OpenElement(3, "h3");
            __builder.AddAttribute(4, "style", "padding-right:15px; padding-left:15px; margin-top:5px;");
            __builder.OpenElement(5, "i");
            __builder.AddContent(6, 
#nullable restore
#line 12 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\ItemFeatureTextBox.razor"
                                                                           Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(8);
            __builder.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\ItemFeatureTextBox.razor"
                           Display

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\ItemFeatureTextBox.razor"
                                             args => OnSubmit.Invoke(Text, args)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\ItemFeatureTextBox.razor"
      
    public delegate void CustomEventHandler(string key, string value);
    [Parameter]
    public CustomEventHandler OnSubmit { get; set; }
    [Parameter]
    public string Text { get; set; }
    [Parameter]
    public string Display { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
