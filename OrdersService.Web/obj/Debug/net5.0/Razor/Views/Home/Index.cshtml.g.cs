#pragma checksum "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06644966cec816ee967c064fed7a7812791301fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/_ViewImports.cshtml"
using OrdersService.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/_ViewImports.cshtml"
using OrdersService.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06644966cec816ee967c064fed7a7812791301fe", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"984a615382ae532d02df1549008f86c20976fdea", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrdersService.Common.Resources.OrderResource>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Orders Service";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Orders</h1>\n</div>\n\n<div class=\"container\">\n    <div class=\"row\">\n        <div class=\"col-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06644966cec816ee967c064fed7a7812791301fe3651", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""sourceCity"">Source City</label>
                    <input type=""text"" class=""form-control"" id=""sourceCity"">
                </div>
                <div class=""form-group"">
                    <label for=""sourceAddress"">Source Address</label>
                    <input type=""text"" class=""form-control"" id=""sourceAddress"">
                </div>
                <div class=""form-group"">
                    <label for=""destinationCity"">Destination City</label>
                    <input type=""text"" class=""form-control"" id=""destinationCity"">
                </div>
                <div class=""form-group"">
                    <label for=""destinationAddress"">Destination Address</label>
                    <input type=""text"" class=""form-control"" id=""destinationAddress"">
                </div>
                <div class=""form-group"">
                    <label for=""weight"">Weight</label>
                    <input type=""number"" class=""form-contro");
                WriteLiteral(@"l"" id=""weight"">
                </div>
                <div class=""form-group"">
                    <label for=""pickUpDate"">Pick-up Date</label>
                    <input type=""date"" class=""form-control"" id=""pickUpDate"">
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

        <div class=""col-9"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"" style=""width: 10%"">#</th>
                        <th scope=""col"" style=""width: 15%"">Source City</th>
                        <th scope=""col"" style=""width: 15%"">Source Address</th>
                        <th scope=""col"" style=""width: 15%"">Destination City</th>
                        <th scope=""col"" style=""width: 15%"">Destination Address</th>
                        <th scope=""col"" style=""width: 15%"">Weight</th>
                        <th scope=""col"" style=""width: 15%"">Pick-up Date</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 56 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <th scope=\"row\">");
#nullable restore
#line 59 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                            <td>");
#nullable restore
#line 60 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.SourceCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 61 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.SourceAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 62 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.DestinationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 63 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.DestinationAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 64 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 65 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                           Write(item.PickUpDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>    \n");
#nullable restore
#line 67 "/Users/maximvolk/Prog/dotnet/orders-service/OrdersService.Web/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrdersService.Common.Resources.OrderResource>> Html { get; private set; }
    }
}
#pragma warning restore 1591