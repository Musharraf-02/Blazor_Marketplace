#pragma checksum "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ea697a0ac4d3ec0a602134047290a863c76b758"
// <auto-generated/>
#pragma warning disable 1591
namespace Marketplace.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
using Marketplace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Marketplace.Client.Controls.NavigationBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddAttribute(4, "style", "background-color:white ;");
            __builder.AddMarkupContent(5, "<div class=\"row p-5\" style=\"background-color: rgb(223, 236, 250);\"><div class=\"col-12 text-center\"><h3>Shop Single</h3>\r\n            <span style=\"color: rgb(128, 128, 128);\"><b>Home / Shop Single</b></span></div></div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "background-color:white ;");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 m-auto");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-8 col-12 mx-auto");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row my-5");
            __builder.AddMarkupContent(17, "<div class=\"col-md-6 col-12\" style=\"border: 1px solid rgb(223, 236, 250) ;border-radius: 10px;\"><img src=\"./images/holder.jpg\" class=\"img-fluid\" style=\"height: auto;max-width: 100%;\"></div>\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-md-6 col-12");
            __builder.AddMarkupContent(20, "<h2>Urban Bags - KeySmart - Premium Key Holders</h2>\r\n                            <br>\r\n                            ");
            __builder.AddMarkupContent(21, "<h3>$415.99</h3>\r\n\r\n                            <br>\r\n                            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "btn-group");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "btn btn-primary px-5 py-3 mx-2");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
                                                                                         (()=>onModalDialogOpen(true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "\r\n                                    View Details\r\n                                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                            <br>\r\n                            <br>\r\n\r\n                            ");
            __builder.AddMarkupContent(29, "<p style=\"color: rgb(128, 128, 128);\">Category:&emsp;&emsp; Book</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.AddMarkupContent(31, "<p class=\"text-center\"><b><u style=\"color: #0069D9;\">Description</u></b></p>\r\n                    ");
            __builder.AddMarkupContent(32, @"<div class=""row my-5
                            ""><div class=""col-md-8 col-12 mx-auto""><h6>Details</h6>
                            <p style=""color: rgb(128, 128, 128);"">
                                Lorem ipsum dolor sit amet, consectetur adipiscing
                                elit, sed do eiusmod tempor
                                incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                exercitation ullamco.
                            </p>
                            <p style=""color: rgb(128, 128, 128);"">
                                Lorem ipsum dolor sit amet, consectetur adipiscing
                                elit, sed do eiusmod tempor
                                incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
                                exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute
                                irure dolor.
                            </p></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            <hr>\r\n            ");
            __builder.AddMarkupContent(34, @"<div class=""row""><div class=""col-md-8 col-12 mx-auto my-4""><div class=""row  my-5""><div class=""col-md-4 col-12 mx-auto""><img src=""./images/logo.jpg"">
                            <h5>Call us</h5>
                            <h5 style=""color:#0069D9 ;"">123 456 7890</h5></div>
                        <div class=""col-md-4 col-12 mx-auto""><br>
                            <span>329 Queensberry Sreet, North Melbourne VIC</span>
                            <br>
                            <span>351, Australia.</span>
                            <br>
                            <span>support@jobio.com</span></div></div></div></div>
            <hr>
            ");
            __builder.AddMarkupContent(35, "<div class=\"row\"><div class=\"col-md-8  col-12 mx-auto my-3\"><span style=\"color: rgb(128, 128, 128);\"><b>©2021 Superio, All Right Reserved.</b></span></div></div>");
#nullable restore
#line 99 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
             if (ModalDialogOpen)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, @"<div class=""modal fade show"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true""><div class=""modal-dialog modal-dialog-centered"" role=""document""><div class=""modal-content""><div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLongTitle"">
                                    Urban Bags - KeySmart - Premium Key
                                    Holders
                                </h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>
                            <div class=""modal-body""><span> Shop Name: Some Shop Name</span><br>
                                <span> Shop Address: Some Shop Address</span><br>
                                <span> Shop Phone: 123 456 7890</span></div>
                            <div class=""modal-footer""><button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button></div></div></div></div>");
#nullable restore
#line 126 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\ProductDetail.razor"
       
    [Parameter]
    public int id { get; set; }

    public bool ModalDialogOpen { get; set; }

    Product product = new Product();



    protected override async Task OnInitializedAsync()
    {
        product = await Http.GetFromJsonAsync<Product>("api/Product/GetByProductID?pId=" + id);
        //ModalDialogOpen = false;
    }

    async Task onModalDialogOpen(bool open)
    {
        ModalDialogOpen = open;
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591