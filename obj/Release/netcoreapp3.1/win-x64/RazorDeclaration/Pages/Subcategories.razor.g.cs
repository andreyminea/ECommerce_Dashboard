#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dcea8b9c9eb33bb3554374599338b489f44e3b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ControlDashboard.Pages
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
using ControlDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using ControlDashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor"
using ControlDashboard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor"
using ControlDashboard.Services;

#line default
#line hidden
#nullable disable
    public partial class Subcategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor"
       
    [Parameter]
    public string CategoryName { get; set; }
    [Parameter]
    public EventCallback<string> OnClick { get; set; }
    [Parameter]
    public EventCallback OnModify { get; set; }

    public void SetCategory(string name)
    {
        CategoryName = name;
        Refresh();
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Subcategories.razor"
      
    List<Subcategory> subcategories;
    Add add;

    protected override async void OnInitialized()
    {
        subcategories = await api.Subcategory.GetAll(CategoryName);
        notifications.Success("Subcategories for " + CategoryName + " loaded");
        this.StateHasChanged();
    }

    private async void AddSubcategory(string name)
    {
        var result = await api.Subcategory.AddNew(CategoryName, name);

        if (result)
        {
            await OnModify.InvokeAsync(null);
            notifications.Success(name + " was added");
            Refresh();
        }
        else
            notifications.Error("New category was not added");
        add.Reset();
    }

    private async void OnChange(string oldName, string newName)
    {
        if (newName != null)
            if (newName.Length > 0)
            {
                var result = await api.Subcategory.Rename(CategoryName, oldName, newName);

                if (result)
                {
                    notifications.Success(oldName + " was modified --> " + newName);
                    Refresh();
                }
                else
                    notifications.Error(oldName + " was not modified");
            }
    }

    private async void OnDelete(string name)
    {
        var result = await api.Subcategory.Delete(CategoryName, name);

        if (result)
        {
            await OnModify.InvokeAsync(null);
            notifications.Success(name + " was deleted");
            Refresh();
        }
        else
            notifications.Error("Category was not deleted");

    }

    private void Refresh()
    {
        OnInitialized();
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private APIManager api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Notifications notifications { get; set; }
    }
}
#pragma warning restore 1591
