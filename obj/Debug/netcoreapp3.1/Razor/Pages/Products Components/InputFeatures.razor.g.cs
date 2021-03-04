#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b609132d721dac89233073758c675c5dd53bdfec"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Products_Components
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
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
using ControlDashboard.Pages.Products_Components.FeaturesPage_Components;

#line default
#line hidden
#nullable disable
    public partial class InputFeatures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
 if(okFlag)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ControlDashboard.Pages.Products_Components.FeaturesPage_Components.InputFeatureSelectPage>(0);
            __builder.AddAttribute(1, "ProductFeatures", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ControlDashboard.Data.ProductFeatures>(
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
                                             CurrentProduct.FeaturesLists

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
       
    [Parameter]
    public Product CurrentProduct { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\InputFeatures.razor"
      
    List<Category> categories;
    bool okFlag = false;
    static string catID = "";
    static string scatID = "";

    protected async override void OnInitialized()
    {
        categories = await api.Category.GetAll();
        GetFeatures();
        okFlag = true;
        this.StateHasChanged();
    }

    private void GetFeatures()
    {
        var category = categories.Find(x => x.DocID == CurrentProduct.CategoryID);
        var subcategory = category.Subcategories.Find(x => x.DocID == CurrentProduct.SubcategoryID);

        if(!(CurrentProduct.CategoryID.Equals(catID) && CurrentProduct.SubcategoryID.Equals(scatID)))
        {
            bool editFlag = false;
            if (catID.Equals("") && CurrentProduct.FeaturesLists != null)
                editFlag = true;

            catID = CurrentProduct.CategoryID;
            scatID = CurrentProduct.SubcategoryID;

            if(!editFlag)
                InitFeaturesLists(subcategory.Features);
        }
    }

    private void InitFeaturesLists(List<FeatureList> features)
    {
        CurrentProduct.FeaturesLists = new ProductFeatures();
        CurrentProduct.FeaturesLists.List = new List<ProductFeatureList>();
        foreach (var item in features)
        {
            var newList = new ProductFeatureList();
            newList.Name = item.FeatureListName;
            newList.Features = new Dictionary<string, string>();

            foreach (var elem in item.Fields)
            {
                newList.Features.Add(elem, "");
            }
            CurrentProduct.FeaturesLists.List.Add(newList);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private APIManager api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Notifications notifications { get; set; }
    }
}
#pragma warning restore 1591