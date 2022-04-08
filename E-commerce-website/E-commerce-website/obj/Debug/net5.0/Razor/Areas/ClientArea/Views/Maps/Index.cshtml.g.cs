#pragma checksum "D:\ITI_Data\BigProjects\MVC\Code\E-commerce-website\E-commerce-website\E-commerce-website\Areas\ClientArea\Views\Maps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053cc42278a6890be0c8524d6057bb2904d11872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ClientArea_Views_Maps_Index), @"mvc.1.0.view", @"/Areas/ClientArea/Views/Maps/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053cc42278a6890be0c8524d6057bb2904d11872", @"/Areas/ClientArea/Views/Maps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d96a8c654f59bbef4c6a59485bbd570296453d3", @"/Areas/ClientArea/Views/_ViewImports.cshtml")]
    public class Areas_ClientArea_Views_Maps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("getlocation();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script defer src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyB4zRo34c4ItTdgOP8E9iXR9ObF1qdV7ME&v=3"">
    
</script>

<script type=""text/javascript""> 
        function getlocation() {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPos, showErr);
            navigator.geolocation.getCurrentPosition(showMap);
        }
        else {
            alert(""Sorry! your Browser does not support Geolocation API"")
        }
    };
    //Showing Current Poistion on Google Map
    function showPos(position){ 
        latt = position.coords.latitude; 
        long = position.coords.longitude; 
        latlng = new google.maps.LatLng(latt, long);
        var geocoder = new google.maps.Geocoder();
        var latlanng = `${latt},${long}`;
        console.log(latlanng);
        geocoder.geocode({ 'latLng': latlng },  (results, status) =>{
        if (status != google.maps.GeocoderStatus.OK) {
            alert(""bravo"");
        }
        // This ");
            WriteLiteral(@"is checking to see if the Geoeode Status is OK before proceeding
        if (status == google.maps.GeocoderStatus.OK) {
            console.log(results);
            var address = (results[0].formatted_address);
            console.log(address);
        }});
        var myOptions = { 
            center: latlng, 
            zoom: 15, 
            mapTypeControl: true, 
            navigationControlOptions: {style:google.maps.NavigationControlStyle.SMALL}} 
        var maps = new google.maps.Map(document.getElementById(""demo""), myOptions); 
        var markers = 
        new google.maps.Marker({position:latlng, map:maps, title:""You Location!""}); 
    }
    //Handling Error and Rejection
    function showErr(error) {
        switch(error.code){
            case error.PERMISSION_DENIED:
                alert(""User denied the request for Geolocation API."");
                break;
            case error.POSITION_UNAVAILABLE:
                alert(""USer location information is unavailable."");");
            WriteLiteral(@"
                break;
            case error.TIMEOUT:
                alert(""The request to get user location timed out."");
                break;
            case error.UNKNOWN_ERROR:
                alert(""An unknown error occurred."");
                break;}
    }

    document.onload = getlocation();
</script> 

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "053cc42278a6890be0c8524d6057bb2904d118726146", async() => {
                WriteLiteral("\r\n    <div id=\"demo\"  style=\"width: 100%; height: 100%; border-radius:8px\"></div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
