#pragma checksum "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "346f53e3eaef39488e31edda65462efbc98e49cb"
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
#line 3 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
using Marketplace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(5, "<div class=\"row p-5\" style=\"background-color: rgb(223, 236, 250);\"><div class=\"col-12 text-center\"><h3>Shop</h3>\r\n            <span style=\"color: rgb(128, 128, 128);\"><b>Home / Shop</b></span></div></div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "background-color:white ;");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", " col-8 m-auto");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row my-4 ");
#nullable restore
#line 16 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
                 foreach (Product product in products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card col-xl-3 p-2 col-lg-4 col-md-6 col-sm-6 mx-auto my-2");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "https://localhost:44371/api/UploadedFile?imageName=" + (
#nullable restore
#line 18 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
                                                                                      product.image

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "height", "250px");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", " card-body p text-center");
            __builder.OpenElement(22, "h6");
            __builder.AddContent(23, 
#nullable restore
#line 20 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
                                 product.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "href", "/product/" + (
#nullable restore
#line 21 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
                                                                       product.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                                View Details\r\n                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.AddMarkupContent(30, "<div class=\"row\"><div class=\"col-12 text-center  my-5\"><span style=\"color: rgb(128, 128, 128);\"><i class=\"fa fa-arrow-left mx-5\" aria-hidden=\"true\"></i>1 2 3<i class=\"fa fa-arrow-right mx-5\" aria-hidden=\"true\"></i></span></div></div>\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(31, @"<div class=""row""><div class=""col-md-8 col-12 mx-auto my-4""><div class=""row  my-5""><div class=""col-md-4 col-12 mx-auto""><img src=""./images/logo.jpg"">
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
            __builder.AddMarkupContent(32, "<div class=\"row\"><div class=\"col-md-8  col-12 mx-auto my-3\"><span style=\"color: rgb(128, 128, 128);\"><b>©2021 Superio, All Right Reserved.</b></span></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace Tutorial\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\Home.razor"
       
    List<Product> products = new List<Product>();
    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<List<Product>>("api/Product");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
