#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a93f7da2c7e368c642c62b0d63870d5b861217d"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Products_Components.PictureComponents
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
    public partial class UploadPicture : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ControlDashboard.Pages.Components.SubmitButton>(0);
            __builder.AddAttribute(1, "Text", "");
            __builder.AddAttribute(2, "Icon", "arrow_circle_up");
            __builder.AddAttribute(3, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                    ButtonStyle.Success

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 11 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                                                   OnLinkAdded

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
 if(Pictures != null)
{
    for(int index = 0; index< Pictures.Count(); index++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ControlDashboard.Pages.Components.LinkTextBox>(5);
            __builder.AddAttribute(6, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                            Pictures[index]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Index", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                     index

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Icon", "arrow_circle_up");
            __builder.AddAttribute(9, "Style", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                                                          ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnSubmit", new ControlDashboard.Pages.Components.LinkTextBox.CustomEventHandler(
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                                                                                           OnLinkChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 17 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
                                                                                                                                                    OnDeleteItem

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 18 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<br>");
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
      
    [Parameter]
    public EventCallback OnChange { get; set; }
    [Parameter]
    public List<string> Pictures { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Components\PictureComponents\UploadPicture.razor"
       

    private void OnDeleteItem(int index)
    {
        Pictures.RemoveAt(index);
        OnChange.InvokeAsync(null);
        this.StateHasChanged();
    }

    private void OnLinkAdded(string newLink)
    {
        Pictures.Add(newLink);
        OnChange.InvokeAsync(null);
        this.StateHasChanged();
    }

    private void OnLinkChanged(string newLink, int index)
    {
        if (!String.IsNullOrWhiteSpace(newLink))
        {
            Pictures[index] = newLink;
            OnChange.InvokeAsync(null);
            this.StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Notifications notifications { get; set; }
    }
}
#pragma warning restore 1591
