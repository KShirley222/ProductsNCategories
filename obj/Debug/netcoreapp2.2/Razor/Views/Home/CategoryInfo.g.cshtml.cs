#pragma checksum "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06a48264fe4830ef6f598597a5d070c683e863b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoryInfo), @"mvc.1.0.view", @"/Views/Home/CategoryInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CategoryInfo.cshtml", typeof(AspNetCore.Views_Home_CategoryInfo))]
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
#line 1 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\_ViewImports.cshtml"
using ProductsandCats;

#line default
#line hidden
#line 2 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\_ViewImports.cshtml"
using ProductsandCats.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06a48264fe4830ef6f598597a5d070c683e863b9", @"/Views/Home/CategoryInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa808c942e9d5190a3b7eb49257a18bf6a81a26b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoryInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 46, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h1 class=\"col-sm-8\">");
            EndContext();
            BeginContext(64, 10, false);
#line 4 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(74, 136, true);
            WriteLiteral("</h1>\r\n    <a href=\"/\" class = \"col-sm-2\">Home</a>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-5\">\r\n        <h3>Categories</h3>\r\n");
            EndContext();
#line 10 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
          
            List<Product> Current = Model.ProdInCat.Select( a => a.ProductAssoc).ToList();
                foreach(Product p in Current)
                {


#line default
#line hidden
            BeginContext(382, 46, true);
            WriteLiteral("                <ul>\r\n                    <li>");
            EndContext();
            BeginContext(429, 6, false);
#line 16 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                   Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(435, 30, true);
            WriteLiteral("</li>\r\n                </ul>\r\n");
            EndContext();
#line 18 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                }
        

#line default
#line hidden
            BeginContext(495, 80, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-sm-5\">\r\n        <h6>Add Category:</h6>\r\n        ");
            EndContext();
            BeginContext(575, 722, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a48264fe4830ef6f598597a5d070c683e863b95577", async() => {
                BeginContext(640, 101, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <select class=\"form-control\" name=\"prodId\">\r\n");
                EndContext();
#line 26 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                    
                      List<Product> All = (List<Product>) ViewBag.AllProducts;
                      List<Product> Added = Model.ProdInCat.Select( a => a.ProductAssoc).ToList();
                      foreach(Product p in All.Except(Added))
                      {

#line default
#line hidden
                BeginContext(1031, 26, true);
                WriteLiteral("                          ");
                EndContext();
                BeginContext(1057, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a48264fe4830ef6f598597a5d070c683e863b96637", async() => {
                    BeginContext(1087, 6, false);
#line 31 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                                                  Write(p.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 31 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                             WriteLiteral(p.ProductId);

#line default
#line hidden
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
                EndContext();
                BeginContext(1102, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
                      }
                  

#line default
#line hidden
                BeginContext(1150, 140, true);
                WriteLiteral("                </select>\r\n                <input type=\"submit\" value=\"Add Category\" class= \"btn btn-primary\">\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 589, "/category/", 589, 10, true);
#line 23 "C:\Users\Kyle Shirley\Desktop\codingDojo\entity\ProductsandCats\Views\Home\CategoryInfo.cshtml"
AddHtmlAttributeValue("", 599, Model.CategoryId, 599, 17, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 616, "/product", 616, 8, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
