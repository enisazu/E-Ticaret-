#pragma checksum "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b32f17a54816172d16adaf31821b5f0da38ce4df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\_ViewImports.cshtml"
using Eticaret.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\_ViewImports.cshtml"
using Eticaret.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b32f17a54816172d16adaf31821b5f0da38ce4df", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b11e296975fd3811b136a67feaa7e5a9cfb980bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""product-big-title-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""product-bit-title text-center"">
                        <h2>Shop</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""single-product-area"">
        <div class=""zigzag-bottom""></div>
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""col-md-3 col-sm-6"">
                                        <div class=""single-shop-product"">
                                            <div class=""product-upper"">
                                                <img");
            BeginWriteAttribute("src", " src=\"", 856, "\"", 882, 2);
            WriteAttributeValue("", 862, "/product/", 862, 9, true);
#nullable restore
#line 24 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 871, item.Image, 871, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 883, "\"", 889, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            </div>\r\n                                            <h2><a");
            BeginWriteAttribute("href", " href=\"", 995, "\"", 1021, 2);
            WriteAttributeValue("", 1002, "/urun/", 1002, 6, true);
#nullable restore
#line 26 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1008, item.SeoName, 1008, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                                            <div class=\"product-carousel-price\">\r\n                                                <ins>");
#nullable restore
#line 28 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                                Write(item.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins> <del>");
#nullable restore
#line 28 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                                                                     Write(Html.Raw((item.Price - 10).ToString("C")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</del>
                                            </div>  

                                            <div class=""product-option-shop"">
                                                <a class=""add_to_cart_button"" data-quantity=""1"" data-product_sku="""" data-product_id=""70"" rel=""nofollow"" href=""/canvas/shop/?add-to-cart=70"">Add to cart</a>
                                            </div>                       
                                        </div>
                                    </div>
");
#nullable restore
#line 36 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <div class=\"product-pagination text-center\">\r\n                        <nav>\r\n                          <ul class=\"pagination\">\r\n");
#nullable restore
#line 45 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                             if (Model.CurrentPage != 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                      <li>\r\n                                      <a");
            BeginWriteAttribute("href", " href=\"", 2205, "\"", 2272, 4);
            WriteAttributeValue("", 2212, "/kategori/", 2212, 10, true);
#nullable restore
#line 48 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2222, Model.CategoryName, 2222, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2241, "/", 2241, 1, true);
#nullable restore
#line 48 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2242, Html.Raw(Model.CurrentPage-1), 2242, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                        <span aria-hidden=\"true\">&laquo;</span>\r\n                                      </a>\r\n                                    </li>\r\n");
#nullable restore
#line 52 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                             for (var i = 0; i < Model.TotalPage; i++)
                            {
                                if (i + 1 == Model.CurrentPage)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2760, "\"", 2811, 4);
            WriteAttributeValue("", 2767, "/kategori/", 2767, 10, true);
#nullable restore
#line 58 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2777, Model.CategoryName, 2777, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2796, "/", 2796, 1, true);
#nullable restore
#line 58 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2797, Html.Raw(i+1), 2797, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 58 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                                                                                             Write(Html.Raw(i+1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></a></li>\r\n");
#nullable restore
#line 59 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3011, "\"", 3062, 4);
            WriteAttributeValue("", 3018, "/kategori/", 3018, 10, true);
#nullable restore
#line 62 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3028, Model.CategoryName, 3028, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3047, "/", 3047, 1, true);
#nullable restore
#line 62 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3048, Html.Raw(i+1), 3048, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                                                                                          Write(Html.Raw(i+1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>  \r\n");
#nullable restore
#line 63 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                                }

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 72 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                             if (Model.CurrentPage != Model.TotalPage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <li>\r\n                                  <a");
            BeginWriteAttribute("href", " href=\"", 3598, "\"", 3665, 4);
            WriteAttributeValue("", 3605, "/kategori/", 3605, 10, true);
#nullable restore
#line 75 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3615, Model.CategoryName, 3615, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3634, "/", 3634, 1, true);
#nullable restore
#line 75 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
WriteAttributeValue("", 3635, Html.Raw(Model.CurrentPage+1), 3635, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                    <span aria-hidden=\"true\">&raquo;</span>\r\n                                  </a>\r\n                                </li>\r\n");
#nullable restore
#line 79 "C:\Users\Enisa\OneDrive\Masaüstü\E-Ticaret\Eticaret.Presentation\Eticaret.Presentation\Views\Shop\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                          </ul>\r\n                        </nav>                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591