#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26ea123a7f90c7e923cfec5ca1cee95d3d6a72ec"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Template_Page
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/templates")]
    public partial class Templates : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg");
            __builder.OpenComponent<ControlDashboard.Pages.Template_Page.Categories>(4);
            __builder.AddAttribute(5, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                             SetCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Deleted", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                                   OnCategoryDeleted

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                                                            categories = (ControlDashboard.Pages.Template_Page.Categories)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    <div class=\"col-lg\"></div>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg");
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
          
            if (showSubcategories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ControlDashboard.Pages.Template_Page.Subcategories>(11);
            __builder.AddAttribute(12, "CategoryName", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                              category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnModify", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                                                  OnModifiedSubcategories

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                                                                                    GoToFeatures

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(15, (__value) => {
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
                                                                                                                        subcategories = (ControlDashboard.Pages.Template_Page.Subcategories)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 19 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
            }
        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Templates.razor"
      
    Subcategories subcategories;
    Categories categories;
    string category;
    bool showSubcategories = false;

    private void SetCategory(string categoryName)
    {
        showSubcategories = true;
        category = categoryName;
        this.StateHasChanged();

        if (subcategories != null)
            subcategories.SetCategory(categoryName);
    }

    private void OnCategoryDeleted(string categoryName)
    {
        if (category != null)
        {
            if (category.Equals(categoryName))
            {
                showSubcategories = false;
                this.StateHasChanged();
            }
        }
    }

    private void OnModifiedSubcategories()
    {
        categories.Refresh();
    }

    private void GoToFeatures(string subcategory)
    {
        var uri = "features/" + category + "/" + subcategory;
        navigationManager.NavigateTo(uri, true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
