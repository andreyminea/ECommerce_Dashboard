#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57fec30f8ad72d067e32dd80edd491399d41fb2"
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
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
using ControlDashboard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
using ControlDashboard.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/features/{category}/{subcategory}")]
    public partial class Features : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenSelectBar<string>>(3);
            __builder.AddAttribute(4, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, 
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                  OnChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                   value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => value = __value, value))));
            __builder.AddAttribute(7, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => value));
            __builder.AddAttribute(8, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 19 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
              
                if (features != null)
                {
                    foreach (var item in features)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSelectBarItem>(11);
                __builder2.AddAttribute(12, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                   item.FeatureListName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                               item.FeatureListName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                        }
                    }
                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n    <div style=\"width:50px\"></div>\r\n    ");
            __builder.OpenComponent<ControlDashboard.Pages.Components.SubmitButton>(17);
            __builder.AddAttribute(18, "Icon", "keyboard_arrow_right");
            __builder.AddAttribute(19, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                        OnAddList

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n");
            __builder.OpenElement(22, "div");
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 35 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
      
        if (value != null)
        {
            var feature = features.Find(x => x.FeatureListName.Equals(value));
            if (feature != null)
            {
                if (feature.Fields != null)
                {
                    foreach (var item in feature.Fields)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "                    <br>\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.AddAttribute(27, "style", "padding-left: 20px;");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenComponent<ControlDashboard.Pages.Components.TwoButtonsTextBox>(29);
            __builder.AddAttribute(30, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                  item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "Icon1", "done");
            __builder.AddAttribute(32, "Icon2", "delete");
            __builder.AddAttribute(33, "Style1", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 47 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                                            ButtonStyle.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Style2", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 47 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                                                                         ButtonStyle.Warning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "OnFirst", new ControlDashboard.Pages.Components.TwoButtonsTextBox.CustomEventHandler(
#nullable restore
#line 47 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                                                                                                       OnFeatureModified

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "OnSecond", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 47 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                                                                                                                                    OnDeleteFeature

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 49 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(39, "            <br>\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "style", "padding-left:10px;");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenComponent<ControlDashboard.Pages.Components.SubmitButton>(43);
            __builder.AddAttribute(44, "Icon", "add");
            __builder.AddAttribute(45, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 53 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                   OnAddFeature

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(47);
            __builder.AddAttribute(48, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                      args => OnDeleteList()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(49, "Text", "Delete");
            __builder.AddAttribute(50, "Icon", "delete");
            __builder.AddAttribute(51, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 54 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                                                                                                       ButtonStyle.Danger

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "Style", "margin-bottom: 20px; width: 150px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 56 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
                }
            }
        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
      
    [Parameter] public string Category { get; set; }
    [Parameter] public string Subcategory { get; set; }

    private string prefix;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Features.razor"
      
    string value;
    List<FeatureList> features;

    protected override async void OnInitialized()
    {
        prefix = Category + "/" + Subcategory;
        features = await api.Feature.GetAll(prefix);

        if (features == null)
        {
            features = new List<FeatureList>();
        }
        notifications.Success("Features for " + prefix + " loaded");
        this.StateHasChanged();
    }

    private void OnChange(string selected)
    {
        Debug.WriteLine(value);
    }

    private FeatureList FindList(string listName)
    {
        if (features == null) return null;

        return features.Find(x => x.FeatureListName.Equals(listName));
    }

    private async void OnDeleteFeature(string name)
    {
        FeatureList currentList = FindList(value);

        if(currentList != null)
        {
            if(currentList.Fields.Remove(name))
            {
                var result = await api.Feature.ModifyList(prefix, currentList);
                if(result)
                    notifications.Success("Item has been deleted");
            }
            else
                notifications.Error("Field was not found");
        }
        else
            notifications.Error("Can't find current list");
        Refresh();
    }

    private async void OnFeatureModified(string currentName, string initialName)
    {
        FeatureList currentList = FindList(value);

        if (currentList != null)
        {
            var item = currentList.Fields.FindIndex(x => x.Equals(initialName));
            if(item != -1)
            {
                currentList.Fields[item] = currentName;
                var result = await api.Feature.ModifyList(prefix, currentList);
                if (result)
                    notifications.Success("Item has been modified");
            }
            else
                notifications.Error("Field was not found");
        }
        else
            notifications.Error("Can't find current list");
        Refresh();
    }

    private async void OnDeleteList()
    {
        if (value != null)
        {
            if (value.Length > 0)
            {
                var result = await api.Feature.Delete(prefix, value);
                if (result)
                    notifications.Success("Item has been modified");
                else
                    notifications.Error("Item was not deleted");
            }
            else
                notifications.Error("Item name is not valid");
        }
        else
            notifications.Error("Item name is not valid");
        Refresh();
    }

    private async void OnAddFeature(string name)
    {
        FeatureList currentList = FindList(value);

        if (currentList != null)
        {
            if(currentList.Fields == null)
            {
                currentList.Fields = new List<string>();
            }
            currentList.Fields.Add(name);
            var result = await api.Feature.ModifyList(prefix, currentList);
            if (result)
                notifications.Success("Item has been modified");
            else
                notifications.Error("Item was not added");
        }
        else
            notifications.Error("Item couldn't be found");
        Refresh();
    }

    private async void OnAddList(string name)
    {
        if (name != null)
        {
            if (name.Length > 0)
            {
                var result = await api.Feature.AddNewList(prefix, name);
                if (result)
                    notifications.Success("List has been added");
                else
                    notifications.Error("List " + name + " was not added");
            }
            else
                notifications.Error("List name is not valid");
        }
        else
            notifications.Error("List name is not valid");
        Refresh();
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
