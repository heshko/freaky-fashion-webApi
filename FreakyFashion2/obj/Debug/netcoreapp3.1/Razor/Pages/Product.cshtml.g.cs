#pragma checksum "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22c2ec0dc667605105b15ba87cac07899f57c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FreakyFashion2.Pages.Pages_Product), @"mvc.1.0.razor-page", @"/Pages/Product.cshtml")]
namespace FreakyFashion2.Pages
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
#line 1 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\_ViewImports.cshtml"
using FreakyFashion2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\_ViewImports.cshtml"
using FreakyFashion2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\_ViewImports.cshtml"
using FreakyFashion2.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{UrlSlug}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22c2ec0dc667605105b15ba87cac07899f57c98", @"/Pages/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43f882952f3f7af5f3fe9a6f354a1d1b6e1b512e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <h1 class=\"text-center\">Product</h1>\r\n    <div class=\"row\">\r\n        <div class=\"col-6 mt-5 mb-5\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 249, "\"", 278, 1);
#nullable restore
#line 13 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
WriteAttributeValue("", 255, Model.Product.ImageUrl, 255, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 279, "\"", 285, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <ul class=\"list-group pt-4\">\r\n                <li class=\"list-group-item  border-0\">Name: ");
#nullable restore
#line 17 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
                                                       Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                <li class=\"list-group-item  border-0\">Description: ");
#nullable restore
#line 19 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
                                                              Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                <li class=\"list-group-item  border-0\">Price:");
#nullable restore
#line 21 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
                                                       Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kr</li>\r\n               <li class=\"list-group-item  border-0\">\r\n                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d22c2ec0dc667605105b15ba87cac07899f57c986561", async() => {
                WriteLiteral("\r\n                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d22c2ec0dc667605105b15ba87cac07899f57c986841", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Product.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                         <button class=\"btn btn-dark\" >Add to basket</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                  \r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Heshko\source\repos\FreakyFashion2\FreakyFashion2\Pages\Product.cshtml"
Write(await Component.InvokeAsync("RekommendderadeProducter",Model.Product.UrlSlug));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n<style>\r\n    .col-6 img {\r\n        height: 500px;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreakyFashion2.ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion2.ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FreakyFashion2.ProductModel>)PageContext?.ViewData;
        public FreakyFashion2.ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
