#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0456e5fb0d7b6a8493ed8feef8cf515fedaf60d1"
// <auto-generated/>
#pragma warning disable 1591
namespace ControlDashboard.Pages.Components
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
    public partial class TwoButtonsTextBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(3);
            __builder.AddAttribute(4, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                          Text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                                          args => OnChange(args.Value.ToString())

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    <div style=\"width:10px;\"></div>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(7);
            __builder.AddAttribute(8, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                          args => OnFirstButtonPressed()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                                                                Icon1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                                                                                    Style1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Style", "margin-bottom: 20px; width: 40px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n    <div style=\"width:10px;\"></div>\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(13);
            __builder.AddAttribute(14, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                          args => OnSecondButtonPressed()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                                                                 Icon2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 29 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
                                                                                     Style2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Style", "margin-bottom: 20px; width: 40px");
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
       
    public delegate void CustomEventHandler(string val1, string val2);
    [Parameter]
    public CustomEventHandler OnFirst { get; set; }
    [Parameter]
    public EventCallback<string> OnSecond { get; set; }
    [Parameter]
    public string Text { get; set; }
    [Parameter]
    public string Icon1 { get; set; }
    [Parameter]
    public string Icon2 { get; set; }
    [Parameter]
    public ButtonStyle Style1 { get; set; }
    [Parameter]
    public ButtonStyle Style2 { get; set; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Components\TwoButtonsTextBox.razor"
      
    private string textBoxText;

    private void OnFirstButtonPressed()
    {
        if (Text != null)
            if (Text.Length > 0)
            {
                OnFirst.Invoke(textBoxText, Text);
            }
    }

    private void OnSecondButtonPressed()
    {
        if (Text != null)
            if (Text.Length > 0)
            {
                OnSecond.InvokeAsync(Text);
            }
    }

    private void OnChange(string args)
    {
        textBoxText = args;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
