#pragma checksum "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f89a267199225493349e7a0af269fe3144fa32a5"
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
#line 1 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\_Imports.razor"
using Marketplace.Client.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
using Marketplace.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateProduct/{id:int}")]
    public partial class UpdateProduct : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(5, "<div class=\"row p-5\" style=\"background-color: rgb(223, 236, 250);\"><div class=\"col-12 text-center\"><h3>Seller Dashboard</h3>\r\n            <span style=\"color: rgb(128, 128, 128);\"><b>Home / Seller Dashboard</b></span></div></div>\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "background-color:white ;");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 m-auto");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "newProduct px-5 py-0");
            __builder.AddMarkupContent(17, "<br>\r\n                        ");
            __builder.AddMarkupContent(18, "<h4>Update Product Details</h4>\r\n                        <br>\r\n\r\n                        <br>\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(19);
            __builder.AddAttribute(20, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                         newProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "<label for=\"name\"><b>Name:</b></label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "id", "name");
                __builder2.AddAttribute(28, "placeholder", "Enter product name");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                        newProduct.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.name = __value, newProduct.name))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newProduct.name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n                            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "row");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-md-4 image-upload-wrap");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(37);
                __builder2.AddAttribute(38, "class", "file-upload-input");
                __builder2.AddAttribute(39, "type", "file");
                __builder2.AddAttribute(40, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                                                               e => LoadFiles(e)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(41, "accept", "image/*");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-row");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(47, "<label for=\"price\"><b>Price:</b></label>\r\n                                    ");
                __Blazor.Marketplace.Client.Pages.UpdateProduct.TypeInference.CreateInputNumber_0(__builder2, 48, 49, "form-control", 50, "price", 51, "Enter product price", 52, 
#nullable restore
#line 42 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                              newProduct.price

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.price = __value, newProduct.price)), 54, () => newProduct.price);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n                                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(58, "<label for=\"catagory\"><b>Category:</b></label>\r\n                                    ");
                __builder2.OpenElement(59, "select");
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "id", "catagory");
                __builder2.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                   newProduct.category

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newProduct.category = __value, newProduct.category));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(64, "option");
                __builder2.AddContent(65, "Food");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                        ");
                __builder2.OpenElement(67, "option");
                __builder2.AddContent(68, "Women");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                        ");
                __builder2.OpenElement(70, "option");
                __builder2.AddContent(71, "Men");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                        ");
                __builder2.OpenElement(73, "option");
                __builder2.AddContent(74, "Kids");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                        ");
                __builder2.OpenElement(76, "option");
                __builder2.AddContent(77, "Mobile");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n                            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "form-group");
                __builder2.AddMarkupContent(81, "<label for=\"description\"><b>Description:</b></label>\r\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(82);
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "rows", "3");
                __builder2.AddAttribute(85, "id", "comment");
                __builder2.AddAttribute(86, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                            newProduct.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newProduct.description = __value, newProduct.description))));
                __builder2.AddAttribute(88, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newProduct.description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                            <br>\r\n                            ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "text-center");
                __builder2.OpenElement(92, "a");
                __builder2.AddAttribute(93, "class", "btn btn-primary");
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
                                                                     updateProd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(95, "Update Product");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n            <hr>\r\n            ");
            __builder.AddMarkupContent(97, @"<div class=""row""><div class=""col-md-8 col-12 mx-auto my-4""><div class=""row  my-5""><div class=""col-md-4 col-12 mx-auto""><img src=""./images/logo.jpg"">
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
            __builder.AddMarkupContent(98, "<div class=\"row\"><div class=\"col-md-8  col-12 mx-auto my-3\"><span style=\"color: rgb(128, 128, 128);\"><b>©2021 Superio, All Right Reserved.</b></span></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\ASUS\PUCIT Files\Web Engineering\MarketPlace\Blazor_Marketplace\Marketplace\Marketplace\Client\Pages\UpdateProduct.razor"
       
    [Parameter]
    public int id { get; set; }

    IBrowserFile selectedFile;

    Product newProduct = new Product();
    Product oldProd = new Product();

    protected override async Task OnInitializedAsync()
    {
        oldProd = await Http.GetFromJsonAsync<Product>("api/Product/GetByProductID?pId=" + id);
        newProduct.id = oldProd.id;
        newProduct.sellerId = oldProd.sellerId;
        newProduct.image = oldProd.image;
        newProduct.name = oldProd.name;
        newProduct.price = oldProd.price;
        newProduct.description = oldProd.description;
        newProduct.category = oldProd.category;
    }

    async void updateProd()
    {
        newProduct.id = oldProd.id;
        newProduct.sellerId = oldProd.sellerId;

        if (selectedFile != null)
        {
            Stream stream = selectedFile.OpenReadStream();
            MemoryStream ms = new MemoryStream();
            await stream.CopyToAsync(ms);
            stream.Close();

            UploadedFile uploadedFile = new UploadedFile();
            uploadedFile.FileName = DateTime.Now.ToString("yymmssfff") + selectedFile.Name;
            uploadedFile.FileContent = ms.ToArray();
            ms.Close();

            await Http.PostAsJsonAsync<UploadedFile>("/api/UploadedFile", uploadedFile);
            newProduct.image = uploadedFile.FileName;
        }

        else
        {
            newProduct.image = oldProd.image;
        }

        if (newProduct.name == "")
        {
            newProduct.name = oldProd.name;
        }

        if (newProduct.price == null)
        {
            newProduct.price = oldProd.price;
        }

        if (newProduct.description == "")
        {
            newProduct.description = oldProd.description;
        }

        await Http.PutAsJsonAsync<Product>("/api/Product?key=" + newProduct.id, newProduct);

        NavManager.NavigateTo("/dashboard");

    }

    public async Task LoadFiles(InputFileChangeEventArgs e)
    {
        selectedFile = e.File;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Marketplace.Client.Pages.UpdateProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
