#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fe7d428ac6a582bcb5344dd7e9cbffc401c8e5f"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Products_Components.GeneralPage_Components
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
    public partial class PriceInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ControlDashboard.Pages.Components.InfoNumberIntBox>(0);
            __builder.AddAttribute(1, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                          CurrentProduct.TVA

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Text", "TVA");
            __builder.AddAttribute(3, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                              0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValueEntered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                                                 OnTVA

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<ControlDashboard.Pages.Components.InfoNumberFloatBox>(6);
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                           CalculatePriceNoTax()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Text", "Price w/o TVA");
            __builder.AddAttribute(9, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                                            0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValueEntered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Single>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Single>(this, 
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                                                               OnNoTaxPrice

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<ControlDashboard.Pages.Components.InfoNumberFloatBox>(12);
            __builder.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Single>(
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                            CurrentProduct.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Text", "Price w/ TVA");
            __builder.AddAttribute(15, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                                           0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValueEntered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Single>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Single>(this, 
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
                                                                                              OnNormalPrice

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
       
    [Parameter]
    public Product CurrentProduct { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\GeneralPage Components\PriceInfo.razor"
      

    private float CalculatePriceNoTax()
    {
        float tva = CurrentProduct.TVA / 100f;
        float result = CurrentProduct.Price / (tva + 1f);
        return RoundTo2Decimals(result);
    }

    private void OnTVA(int val)
    {
        CurrentProduct.TVA = val;
        OnNormalPrice(CurrentProduct.Price);
    }

    private void OnNoTaxPrice(float val)
    {
        float tva = CurrentProduct.TVA / 100f;
        float result = val * tva + val;
        CurrentProduct.Price = RoundTo2Decimals(result);
        this.StateHasChanged();
    }

    private void OnNormalPrice(float val)
    {
        CurrentProduct.Price = val;
        this.StateHasChanged();
    }

    private float RoundTo2Decimals(float val)
    {
        return (float)Math.Round(val * 100f) / 100f;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
