#pragma checksum "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8077440c03da7f1ba4a82d189856c2edc43f0a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ClientArea_Views_Products_Details), @"mvc.1.0.view", @"/Areas/ClientArea/Views/Products/Details.cshtml")]
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
#line 1 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\_ViewImports.cshtml"
using E_commerce_website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
using E_commerce_website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8077440c03da7f1ba4a82d189856c2edc43f0a8f", @"/Areas/ClientArea/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d96a8c654f59bbef4c6a59485bbd570296453d3", @"/Areas/ClientArea/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ClientArea_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_commerce_website.Models.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var Options = ViewBag.ProductOptions;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n\r\n         <div class=\"single-product\">\r\n            <div class=\"row\"");
            BeginWriteAttribute("id", " id=\"", 295, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"col-md-6 single-top-left\">  \r\n                    <div class=\"flexslider\">\r\n                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8077440c03da7f1ba4a82d189856c2edc43f0a8f5255", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 441, "~/dbImages/", 441, 11, true);
#nullable restore
#line 18 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
AddHtmlAttributeValue("", 452, Model.ProductImage, 452, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-6 single-top-right\">\r\n                    <h3 class=\"item_name\">");
#nullable restore
#line 23 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                                     Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>Category : ");
#nullable restore
#line 24 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                             Write(Html.DisplayFor(model => model.ProductCategory.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                 \r\n");
#nullable restore
#line 26 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                 foreach(var group in Options)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p> ");
#nullable restore
#line 28 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                    Write(group.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                    <select name=\"options\" id=\"options\">\r\n");
#nullable restore
#line 30 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                     foreach (var element in group)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8077440c03da7f1ba4a82d189856c2edc43f0a8f8652", async() => {
#nullable restore
#line 32 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                                                         Write(element.Option.OptionName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                             WriteLiteral(element.OptionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 33 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </select>\r\n                    <br/>\r\n");
#nullable restore
#line 36 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n\r\n\r\n\r\n                    \r\n                    <div class=\"single-rating\">\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"single-price\">\r\n                        <ul>\r\n                            <li class=\"product-price\">");
#nullable restore
#line 58 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.ProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("EGP</li>  \r\n                            <li>");
#nullable restore
#line 59 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                           Write(Html.DisplayFor(model => model.ProductShortDes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li><br/>\r\n                            <li>Items in Stock : ");
#nullable restore
#line 60 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.ProductStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> <br />\r\n                            <li><span class=\"off\">Seller Name : ");
#nullable restore
#line 61 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.Vendor.VendorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li> 
                            <li><a href=""#""><i class=""fa fa-gift"" aria-hidden=""true""></i> Coupon</a></li>
                        </ul>   
                    </div> 

                   <p class=""single-price-text""> Text Here if You want </p>
");
            WriteLiteral("                    \r\n                </div>\r\n                <div class=\"single-product-everything\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8077440c03da7f1ba4a82d189856c2edc43f0a8f13392", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <h4>Product Description</h4>\r\n                <div class=\"alert alert-secondary\" role=\"alert\" style=\"width:100%\">\r\n                    ");
#nullable restore
#line 81 "E:\ITI_SEC\Github\Final Version\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Products\Details.cshtml"
               Write(Html.DisplayFor(model => model.ProductLongDes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                <div style=\"bottom:10px\">\r\n    \r\n\r\n            \r\n\r\n    \r\n\r\n \r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_commerce_website.Models.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
