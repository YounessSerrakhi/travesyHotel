#pragma checksum "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe316b6b306141d95774725017b083bc7a40d69f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restauration_Dinner), @"mvc.1.0.view", @"/Views/Restauration/Dinner.cshtml")]
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
#line 1 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\_ViewImports.cshtml"
using AuthMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\_ViewImports.cshtml"
using AuthMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe316b6b306141d95774725017b083bc7a40d69f", @"/Views/Restauration/Dinner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08fb7e97ec638d34771ce52da483c4e9a7a01546", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Restauration_Dinner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AuthMvc.Models.Restaurant>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-hover", new global::Microsoft.AspNetCore.Html.HtmlString("Order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<style>
    section {
        height: 100vh;
        display: flex;
        justify-content: center;
        align-items: center;
        background-color: #eee
    }

    .card {
        height: 310px;
        width: 320px;
        background-color: #fff;
        border-radius: 20px;
        position: relative
    }

        .card .offer {
            width: 150px;
            height: 40px;
            background-color: red;
            position: absolute;
            top: 28px;
            left: -14px;
            border-radius: 20px;
            border-bottom-left-radius: 0px;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 15px;
            font-weight: 700;
            color: #fff
        }

        .card span:before {
            position: absolute;
            content: '';
            background-color: red;
            height: 30px;
            width: 17px;
            top: 20px;
     ");
            WriteLiteral(@"       left: 0px;
            border-radius: 10px;
            z-index: -10
        }

        .card span:after {
            position: absolute;
            content: '';
            background-color: #d70303;
            height: 30px;
            width: 17px;
            top: 30px;
            left: 0px;
            border-top-left-radius: 10px;
            border-bottom-left-radius: 20px;
            z-index: -10
        }

        .card .item-image {
            width: 100%;
            height: 200px;
            overflow: hidden;
            border-top-left-radius: 20px;
            border-top-right-radius: 20px
        }

            .card .item-image img {
                width: 100%;
                height: 100%;
                object-fit: cover
            }

    .item-content {
        padding: 10px
    }

        .item-content h3 {
            font-size: 20px
        }

        .item-content p {
            font-size: 15px;
            font-weight: 500
   ");
            WriteLiteral("     }\r\n\r\n    .item-price {\r\n        margin-top: 10px;\r\n        display: flex;\r\n        justify-content: space-between\r\n    }\r\n\r\n    .margin {\r\n        margin: 10px 10px 10px 10px;\r\n    }\r\n</style>\r\n<section>\r\n\r\n");
#nullable restore
#line 103 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
     foreach (var item in Model)
    {
        if (item.Type.CompareTo("Dinner") == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card margin\">\r\n                <span class=\"offer\">FirstOrder25</span>\r\n                <div class=\"item-image\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fe316b6b306141d95774725017b083bc7a40d69f7029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2555, "~/assets/img/menu/", 2555, 18, true);
#nullable restore
#line 109 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
AddHtmlAttributeValue("", 2573, item.image, 2573, 11, false);

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
            WriteLiteral(" </div>\r\n                <div class=\"item-content\">\r\n                    <h3>");
#nullable restore
#line 111 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p> ");
#nullable restore
#line 112 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 112 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <div class=\"item-price\">\r\n                        <span> ");
#nullable restore
#line 114 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
                          Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span>min order(1)</span>\r\n                          <ul class=\"list-unstyled nav1 cl-effect-10\">\r\n                         <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe316b6b306141d95774725017b083bc7a40d69f9967", async() => {
                WriteLiteral("<span>Order</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                         </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 122 "C:\Users\asus\Desktop\projet vf\AuthMvc\Views\Restauration\Dinner.cshtml"
        }
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AuthMvc.Models.Restaurant>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
