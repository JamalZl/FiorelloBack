#pragma checksum "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdc9a4022ad50628cdf3a9ae8f4f5328568d1c55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialView), @"mvc.1.0.view", @"/Views/Shared/_PartialView.cshtml")]
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
#line 1 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\_ViewImports.cshtml"
using Fiorello.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc9a4022ad50628cdf3a9ae8f4f5328568d1c55", @"/Views/Shared/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4810dd83e6dd55f1c6387eae003c893afa2e8019", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flower>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "flower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;color:white;border:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addbasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
 foreach (Flower flower in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 63, "\"", 302, 4);
            WriteAttributeValue("", 71, "product", 71, 7, true);
            WriteAttributeValue(" ", 78, "all", 79, 4, true);
            WriteAttributeValue("  ", 82, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 4 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                          foreach (FlowerCategory flowerCategory in flower.FlowerCategories)
                        {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                    Write(flowerCategory.Category.Name.ToLower()+" ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                                     
                        }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 84, 194, false);
            WriteAttributeValue("                        ", 278, "", 302, 24, true);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 8 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                              Write(flower.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n    <div>\r\n        <div class=\"image\">\r\n");
#nullable restore
#line 11 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
             foreach (FlowerImage flowerImage in flower.FlowerImages)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                 if (flowerImage.IsMain == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc9a4022ad50628cdf3a9ae8f4f5328568d1c557563", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fdc9a4022ad50628cdf3a9ae8f4f5328568d1c557842", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 653, "~/assets/images/", 653, 16, true);
#nullable restore
#line 16 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
AddHtmlAttributeValue("", 669, flowerImage.Image, 669, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                                      WriteLiteral(flower.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"productName\">\r\n            ");
#nullable restore
#line 22 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
       Write(flower.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"productPrice cart-container d-flex justify-content-center\">\r\n            <div class=\"addToCart d-flex justify-content-center\">\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                 if (flower.CampaignId == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"text\"><span>Add to cart</span></div>\r\n                    <div class=\"price\"><span style=\"font-size: 12px;\">");
#nullable restore
#line 29 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                                 Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>$</span></div>\r\n");
#nullable restore
#line 30 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"margin-left:25px\" class=\"text\"><span>Add to cart</span></div>\r\n                    <div class=\"price\">\r\n                        <span style=\"font-size: 12px;\">");
#nullable restore
#line 35 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                   Write(flower.Price*(100-flower.Campaigns.DiscountPercent)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>$</span><del style=\"margin-left:8px\">");
#nullable restore
#line 35 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                                                                                                                              Write(flower.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</del>\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n    <div  style=\"display:flex; justify-content:center;margin-top:15px; border:none;\">\r\n        <button class=\"btn btn-success\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdc9a4022ad50628cdf3a9ae8f4f5328568d1c5514913", async() => {
                WriteLiteral("Add to Basket");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
                                                                                                                       WriteLiteral(flower.Id);

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
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 50 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Shared\_PartialView.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flower>> Html { get; private set; }
    }
}
#pragma warning restore 1591
