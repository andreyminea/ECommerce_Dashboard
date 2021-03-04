#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e9438b70c84a37fdf20ec3cb37d7b3cc4010689"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Products_Pages
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
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
using ControlDashboard.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editproduct/{id}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>");
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-xl-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenSteps>(5);
            __builder.AddAttribute(6, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 18 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                 OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "SelectedIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                          currentStep

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Steps", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenStepsItem>(9);
                __builder2.AddAttribute(10, "Text", "General");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "box-outline");
                    __builder3.OpenComponent<ControlDashboard.Pages.Products_Components.General>(14);
                    __builder3.AddAttribute(15, "CurrentProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ControlDashboard.Data.Product>(
#nullable restore
#line 22 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                      product

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenStepsItem>(17);
                __builder2.AddAttribute(18, "Text", "Features");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(20, "div");
                    __builder3.AddAttribute(21, "class", "box-outline");
                    __builder3.OpenComponent<ControlDashboard.Pages.Products_Components.InputFeatures>(22);
                    __builder3.AddAttribute(23, "CurrentProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ControlDashboard.Data.Product>(
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                            product

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenStepsItem>(25);
                __builder2.AddAttribute(26, "Text", "Pictures");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "box-outline");
                    __builder3.OpenComponent<ControlDashboard.Pages.Products_Components.Pictures>(30);
                    __builder3.AddAttribute(31, "CurrentProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ControlDashboard.Data.Product>(
#nullable restore
#line 32 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                       product

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenStepsItem>(33);
                __builder2.AddAttribute(34, "Text", "Description");
                __builder2.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "class", "box-outline");
                    __builder3.OpenComponent<ControlDashboard.Pages.Products_Components.Description>(38);
                    __builder3.AddAttribute(39, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                product.Description

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(40, "CurrentProduct", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ControlDashboard.Data.Product>(
#nullable restore
#line 37 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                                                      product

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenStepsItem>(42);
                __builder2.AddAttribute(43, "Text", "Submit");
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(45, "div");
                    __builder3.AddAttribute(46, "class", "box-outline");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(47);
                    __builder3.AddAttribute(48, "Text", "Finish edit product");
                    __builder3.AddAttribute(49, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 42 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                                                  ButtonStyle.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
                                                                                                           Send

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
      
    [Parameter] public string ID { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\EditProduct.razor"
       
    Product product;
    private int currentStep = 0;

    protected async override void OnInitialized()
    {
        product = await api.Product.GetOne(ID);
        this.StateHasChanged();
    }

    private void OnChange(int index)
    {
        if (currentStep == 0)
        {
            if (product.CheckGeneralInfo())
            {
                currentStep = index;
            }
            else
            {
                notifications.Error("Please fill all the informations");
            }
        }
        else
        {
            if (index == 4)
            {
                if (product.CheckRest())
                {
                    currentStep = index;
                }
                else
                {
                    notifications.Error("Please enter pictures & a description");
                }
            }
            else
            {
                currentStep = index;
            }
        }
        this.StateHasChanged();
    }

    private async void Send()
    {
        var response = await api.Product.Modify(ID, product);

        if(response)
        {
            notifications.Success("Product added in the database");
            navigationManager.NavigateTo("viewproducts", true);
        }
        else
        {
            notifications.Error("Product was not added in the databse");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private APIManager api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Notifications notifications { get; set; }
    }
}
#pragma warning restore 1591