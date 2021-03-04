#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5638ae60a8e8dff0237231fe60280403dfe681f0"
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
    public partial class InputFeatureSelectPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddAttribute(2, "style", "margin-left:30px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenSelectBar<string>>(4);
            __builder.AddAttribute(5, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                                                  OnListChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                   value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
            __builder.AddAttribute(8, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => value));
            __builder.AddAttribute(9, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 9 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
              
                if (ProductFeatures != null)
                {
                    foreach (var item in ProductFeatures.List)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSelectBarItem>(12);
                __builder2.AddAttribute(13, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                                   item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                                                    item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n");
#nullable restore
#line 15 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                    }
                }
            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<br>\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "margin-left:30px;");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 23 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
  
    if(flag == true)
    {
        var currentFeatures = ProductFeatures.List.Find(x => x.Name.Equals(value));
        var currentDictionary = currentFeatures.Features;

        foreach(var item in currentDictionary)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "            ");
            __builder.OpenComponent<ControlDashboard.Pages.Products_Components.FeaturesPage_Components.ItemFeatureTextBox>(23);
            __builder.AddAttribute(24, "Display", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                          item.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                                             item.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnSubmit", new ControlDashboard.Pages.Products_Components.FeaturesPage_Components.ItemFeatureTextBox.CustomEventHandler(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
                                                                                 OnSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 32 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
        }
    }   

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
      
    [Parameter]
    public ProductFeatures ProductFeatures { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\FeaturesPage Components\InputFeatureSelectPage.razor"
      
    string value;
    bool flag = false;

    private void OnListChanged(string val)
    {
        value = val;
        flag = true;
        this.StateHasChanged();
    }

    private void OnSubmit(string key, string val)
    {
        var currentFeatures = ProductFeatures.List.Find(x => x.Name.Equals(value));
        var currentDictionary = currentFeatures.Features;
        currentDictionary[key] = val;
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591