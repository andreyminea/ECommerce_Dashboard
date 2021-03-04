#pragma checksum "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cefce6fbfd3096839543695ca48f85a182af39e6"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewproducts")]
    public partial class ViewProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
 if (productViews == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<ProductView>>(1);
            __builder.AddAttribute(2, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ProductView>>(
#nullable restore
#line 13 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                       productViews

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ColumnWidth", "200px");
            __builder.AddAttribute(7, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(8);
                __builder2.AddAttribute(9, "Property", "ProductID");
                __builder2.AddAttribute(10, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(12);
                __builder2.AddAttribute(13, "Property", "Name");
                __builder2.AddAttribute(14, "Title", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(16);
                __builder2.AddAttribute(17, "Property", "Stock");
                __builder2.AddAttribute(18, "Title", "Stock");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(20);
                __builder2.AddAttribute(21, "Property", "Category");
                __builder2.AddAttribute(22, "Title", "Category");
                __builder2.AddAttribute(23, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenGridColumn<ProductView>>)((context) => (__builder3) => {
                    __Blazor.ControlDashboard.Pages.Products_Pages.ViewProducts.TypeInference.CreateRadzenDropDown_0(__builder3, 24, 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 21 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                               CategoryFilterChanged

#line default
#line hidden
#nullable disable
                    ), 26, 
#nullable restore
#line 21 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
                    , 27, "Text", 28, "Value", 29, "width:100%", 30, 
#nullable restore
#line 22 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                           CategoriesList

#line default
#line hidden
#nullable disable
                    , 31, 
#nullable restore
#line 21 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                  CategoryFilterValue

#line default
#line hidden
#nullable disable
                    , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CategoryFilterValue = __value, CategoryFilterValue)), 33, () => CategoryFilterValue);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(35);
                __builder2.AddAttribute(36, "Property", "Subcategory");
                __builder2.AddAttribute(37, "Title", "Category");
                __builder2.AddAttribute(38, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenGridColumn<ProductView>>)((context) => (__builder3) => {
                    __Blazor.ControlDashboard.Pages.Products_Pages.ViewProducts.TypeInference.CreateRadzenDropDown_1(__builder3, 39, 40, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                  SubcategoryFilterChanged

#line default
#line hidden
#nullable disable
                    ), 41, 
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                                        true

#line default
#line hidden
#nullable disable
                    , 42, "Text", 43, "Value", 44, "width:100%", 45, 
#nullable restore
#line 28 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                           SubcategoriesList

#line default
#line hidden
#nullable disable
                    , 46, 
#nullable restore
#line 27 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                  SubcategoryFilterValue

#line default
#line hidden
#nullable disable
                    , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SubcategoryFilterValue = __value, SubcategoryFilterValue)), 48, () => SubcategoryFilterValue);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(50);
                __builder2.AddAttribute(51, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                             false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 31 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                                TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Width", "100px");
                __builder2.AddAttribute(56, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ProductView>)((productView) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(57);
                    __builder3.AddAttribute(58, "Icon", "edit");
                    __builder3.AddAttribute(59, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 33 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                           ButtonStyle.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(60, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 33 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                   ButtonSize.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                               args => EditProduct(productView.ProductID)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<ProductView>>(63);
                __builder2.AddAttribute(64, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                          false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                             false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 36 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 36 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                                TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "Width", "100px");
                __builder2.AddAttribute(69, "Template", (Microsoft.AspNetCore.Components.RenderFragment<ProductView>)((productView) => (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(70);
                    __builder3.AddAttribute(71, "Icon", "delete");
                    __builder3.AddAttribute(72, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                             ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                       ButtonSize.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
                                                                                                                   args => DeleteProduct(productView.ProductID)

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 43 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "P:\Backend\ControlDashboard\ControlDashboard\Pages\Products Pages\ViewProducts.razor"
            
    List<Category> categories;
    List<ProductView> initialProductList;
    List<ProductView> productViews;
    List<string> CategoriesList;
    string CategoryFilterValue;
    List<string> SubcategoriesList;
    string SubcategoryFilterValue;

    protected async override void OnInitialized()
    {
        var products = await api.Product.GetAll();
        categories = await api.Category.GetAll();
        initialProductList = new List<ProductView>();
        foreach(var item in products)
        {
            initialProductList.Add(new ProductView(item, categories));
        }
        productViews = initialProductList;
        InitCategoriesList();
        this.StateHasChanged();
    }

    private void EditProduct(string ID)
    {
        navigationManager.NavigateTo("editproduct/" + ID);
    }

    private async void DeleteProduct(string ID)
    {
        var result = await api.Product.Delete(ID);
        if (result)
        {
            notifications.Success("Product deleted");
            this.OnInitialized();
        }
        else
        {
            notifications.Error("Product was not deleted");
        }
    }

    private void InitCategoriesList()
    {
        CategoriesList = new List<string>();

        foreach(var item in categories)
        {
            CategoriesList.Add(item.CategoryName);
        }
    }

    private void InitSubcategoriesList(string categoryName)
    {
        SubcategoriesList = new List<string>();
        var categ = categories.Find(x => categoryName.Equals(x.CategoryName));

        foreach(var item in categ.Subcategories)
        {
            SubcategoriesList.Add(item.SubcategoryName);
        }
    }

    private void CategoryFilterChanged()
    {
        if(CategoryFilterValue == null)
        {
            SubcategoriesList = null;
            productViews = initialProductList;
        }
        else
        {
            InitSubcategoriesList(CategoryFilterValue);
            productViews = new List<ProductView>();

            foreach(var item in initialProductList)
            {
                if (item.Category.Equals(CategoryFilterValue))
                    productViews.Add(item);
            }
        }
        this.StateHasChanged();
    }

    private void SubcategoryFilterChanged()
    {
        if(SubcategoryFilterValue == null)
        {
            CategoryFilterChanged();
        }
        else
        {
            productViews = new List<ProductView>();

            foreach (var item in initialProductList)
            {
                if (item.Category.Equals(CategoryFilterValue)
                        && item.Subcategory.Equals(SubcategoryFilterValue))
                    productViews.Add(item);
            }
        }
        this.StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private APIManager api { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Notifications notifications { get; set; }
    }
}
namespace __Blazor.ControlDashboard.Pages.Products_Pages.ViewProducts
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenDropDown_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.IEnumerable __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Change", __arg0);
        __builder.AddAttribute(__seq1, "AllowClear", __arg1);
        __builder.AddAttribute(__seq2, "TextProperty", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.AddAttribute(__seq4, "Style", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::System.Collections.IEnumerable __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Change", __arg0);
        __builder.AddAttribute(__seq1, "AllowClear", __arg1);
        __builder.AddAttribute(__seq2, "TextProperty", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.AddAttribute(__seq4, "Style", __arg4);
        __builder.AddAttribute(__seq5, "Data", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
