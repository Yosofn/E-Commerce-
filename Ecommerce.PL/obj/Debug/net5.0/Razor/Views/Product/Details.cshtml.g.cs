#pragma checksum "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1619b8eb23c59d48ee0be618471f727c2839fe79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\_ViewImports.cshtml"
using Ecommerce.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\_ViewImports.cshtml"
using Ecommerce.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\_ViewImports.cshtml"
using Ecommerce.BLL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\_ViewImports.cshtml"
using Ecommerce.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\_ViewImports.cshtml"
using Ecommerce.DAL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1619b8eb23c59d48ee0be618471f727c2839fe79", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b62998d3b6d26964bd5efe5f9f211684532e75d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""min-height-200px"">
    <div class=""page-header"">
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""title"">
                    <h4>Product Details</h4>
                </div>
                <nav aria-label=""breadcrumb"" role=""navigation"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Product Details</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
    <div class=""product-wrap"">
        <div class=""product-detail-wrap mb-30"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-12 col-sm-12"">
                    <div class=""product-slider slider-arrow"">
                        <div class=""product-slide"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1619b8eb23c59d48ee0be618471f727c2839fe795254", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 988, "~/vendors/images/product-", 988, 25, true);
#nullable restore
#line 25 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1013, Model.Id, 1013, 11, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1024, ".jpg", 1024, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6 col-md-12 col-sm-12"">
                    <div class=""product-detail-desc pd-20 card-box height-100-p"">
                        <h4 class=""mb-20 pt-20"">");
#nullable restore
#line 31 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>");
#nullable restore
#line 32 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"price\">\r\n                            Price : ");
#nullable restore
#line 34 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml"
                               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"$
                        </div>
                        <div class=""mx-w-150"">
                            <div class=""form-group"">
                                <label class=""text-blue"">Quantity</label>
                                <input readonly id=""demo3_22"" type=""text""");
            BeginWriteAttribute("value", " value=\"", 1761, "\"", 1786, 1);
#nullable restore
#line 39 "D:\Back end\workshops\Ecommerce Workshop(MVC Project)\Ecommerce Cycle37\Ecommerce.PL\Views\Product\Details.cshtml"
WriteAttributeValue("", 1769, Model.Quantity, 1769, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""demo3_22"">
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6 col-6"">
                                <a href=""#"" class=""btn btn-primary btn-block"">Add To Cart</a>
                            </div>
                            <div class=""col-md-6 col-6"">
                                <a href=""#"" class=""btn btn-outline-primary btn-block"">Buy Now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <h4 class=""mb-20"">Recent Product</h4>
        <div class=""product-list"">
            <ul class=""row"">
                <li class=""col-lg-4 col-md-6 col-sm-12"">
                    <div class=""product-box"">
                        <div class=""producct-img""><img src=""vendors/images/product-img1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2729, "\"", 2735, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""product-caption"">
                            <h4><a href=""#"">Gufram Bounce Black</a></h4>
                            <div class=""price"">
                                <del>$55.5</del><ins>$49.5</ins>
                            </div>
                            <a href=""#"" class=""btn btn-outline-primary"">Read More</a>
                        </div>
                    </div>
                </li>
                <li class=""col-lg-4 col-md-6 col-sm-12"">
                    <div class=""product-box"">
                        <div class=""producct-img""><img src=""vendors/images/product-img2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3392, "\"", 3398, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""product-caption"">
                            <h4><a href=""#"">Gufram Bounce White</a></h4>
                            <div class=""price"">
                                <del>$75.5</del><ins>$50</ins>
                            </div>
                            <a href=""#"" class=""btn btn-outline-primary"">Add To Cart</a>
                        </div>
                    </div>
                </li>
                <li class=""col-lg-4 col-md-6 col-sm-12"">
                    <div class=""product-box"">
                        <div class=""producct-img""><img src=""vendors/images/product-img3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 4055, "\"", 4061, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                        <div class=""product-caption"">
                            <h4><a href=""#"">Contrast Lace-Up Sneakers</a></h4>
                            <div class=""price"">
                                <ins>$80</ins>
                            </div>
                            <a href=""#"" class=""btn btn-outline-primary"">Add To Cart</a>
                        </div>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
