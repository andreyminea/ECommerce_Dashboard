#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dcea8b9c9eb33bb3554374599338b489f44e3b"
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
#line 1 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
using ControlDashboard.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
using ControlDashboard.Services;

#line default
#line hidden
#nullable disable
    public partial class Subcategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenPanel>(0);
            __builder.AddAttribute(1, "AllowCollapse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Style", "width: 400px; margin-bottom: 20px; height: 700px;");
            __builder.AddAttribute(3, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<ControlDashboard.Pages.Components.Add>(5);
                __builder2.AddAttribute(6, "Placeholder", "Type new subcategory");
                __builder2.AddAttribute(7, "OnAdd", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                       AddSubcategory

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(8, (__value) => {
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                             add = (ControlDashboard.Pages.Components.Add)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
            }
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDataList<Subcategory>>(12);
                __builder2.AddAttribute(13, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 28 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                  1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "WrapItems", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Subcategory>>(
#nullable restore
#line 28 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                                subcategories

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Subcategory>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(18, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenCard>(19);
                    __builder3.AddAttribute(20, "Style", "width: 250px; margin-bottom: 20px; height: 300px;");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(22, "\r\n                    ");
                        __builder4.OpenElement(23, "div");
                        __builder4.AddMarkupContent(24, "\r\n                        ");
                        __builder4.OpenElement(25, "h2");
                        __builder4.AddAttribute(26, "style", "text-align: center");
                        __builder4.AddMarkupContent(27, "\r\n                            ");
                        __builder4.AddContent(28, 
#nullable restore
#line 33 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                             context?.SubcategoryName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(29, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(30, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(31, "\r\n                    <br>\r\n                    ");
                        __builder4.OpenElement(32, "div");
                        __builder4.AddMarkupContent(33, "\r\n                        ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenTextBox>(34);
                        __builder4.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                              context?.SubcategoryName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                                args => OnChange(@context?.SubcategoryName, args)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(38, "\r\n                    <br>\r\n                    ");
                        __builder4.OpenElement(39, "div");
                        __builder4.AddMarkupContent(40, "\r\n                        ");
                        __builder4.OpenElement(41, "h3");
                        __builder4.AddMarkupContent(42, "\r\n                            Category: ");
                        __builder4.AddContent(43, 
#nullable restore
#line 43 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                       CategoryName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(44, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(45, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(46, "\r\n                    ");
                        __builder4.OpenElement(47, "div");
                        __builder4.AddMarkupContent(48, "\r\n                        ");
                        __builder4.OpenElement(49, "h3");
                        __builder4.AddMarkupContent(50, "\r\n                            Features: ");
                        __builder4.AddContent(51, 
#nullable restore
#line 48 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                       context?.Features.Count

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddMarkupContent(52, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(53, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(54, "\r\n                    ");
                        __builder4.OpenElement(55, "div");
                        __builder4.AddAttribute(56, "class", "row");
                        __builder4.AddMarkupContent(57, "\r\n                        ");
                        __builder4.OpenElement(58, "div");
                        __builder4.AddAttribute(59, "class", "col-lg");
                        __builder4.AddMarkupContent(60, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(61);
                        __builder4.AddAttribute(62, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                  args => OnDelete(@context?.SubcategoryName)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(63, "Icon", "delete");
                        __builder4.AddAttribute(64, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 53 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                                                                          ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Style", "margin-bottom: 20px; width: 80px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(66, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(67, "\r\n                        <div class=\"col-lg\"></div>\r\n                        ");
                        __builder4.OpenElement(68, "div");
                        __builder4.AddAttribute(69, "class", "col-lg");
                        __builder4.AddMarkupContent(70, "\r\n                            ");
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(71);
                        __builder4.AddAttribute(72, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                  args => OnClick.InvokeAsync(@context?.SubcategoryName)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(73, "Icon", "keyboard_arrow_right");
                        __builder4.AddAttribute(74, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 57 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
                                                                                                                                                   ButtonStyle.Info

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(75, "Style", "margin-bottom: 20px; width: 80px");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(76, "\r\n                        ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(77, "\r\n                    ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(78, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
       
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
#line 66 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Template Page\Subcategories.razor"
      
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
