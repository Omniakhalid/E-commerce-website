#pragma checksum "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d9436c489460539e948eeb57d4cb5cac859dc61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ClientArea_Views_Orders_Details), @"mvc.1.0.view", @"/Areas/ClientArea/Views/Orders/Details.cshtml")]
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
#line 1 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\_ViewImports.cshtml"
using E_commerce_website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\_ViewImports.cshtml"
using E_commerce_website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d9436c489460539e948eeb57d4cb5cac859dc61", @"/Areas/ClientArea/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d96a8c654f59bbef4c6a59485bbd570296453d3", @"/Areas/ClientArea/Views/_ViewImports.cshtml")]
    public class Areas_ClientArea_Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_commerce_website.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShippingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShippingAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.orderTrakingNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.orderTrakingNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderShiped));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderShiped));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d9436c489460539e948eeb57d4cb5cac859dc6114268", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d9436c489460539e948eeb57d4cb5cac859dc6116471", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_commerce_website.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
