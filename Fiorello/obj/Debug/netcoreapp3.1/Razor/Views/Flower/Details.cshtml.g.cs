#pragma checksum "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "694afe3afac42dbf6956a1d6492f9ed3c2aec4be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flower_Details), @"mvc.1.0.view", @"/Views/Flower/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"694afe3afac42dbf6956a1d6492f9ed3c2aec4be", @"/Views/Flower/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4810dd83e6dd55f1c6387eae003c893afa2e8019", @"/Views/_ViewImports.cshtml")]
    public class Views_Flower_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flower>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 70px; height: 70px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/review1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/review2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Js/productList.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
  
    ViewData["Title"] = "Index";
    List<Flower> related = ViewBag.RelatedFlowers;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section id=""shopproductNameLis"">
    <div class=""container"">
        <div class=""row"">
            <h1>
                Product List
            </h1>
            <p>
                Where flowers are our inspiration
            </p>
        </div>
    </div>
</section>
<section id=""shopOrangeAmaryllis"">
    <div class=""container"">
        <div class=""row justify-content-end"">
            <div class=""shopAmeryllisImages d-flex col-lg-6 col"">
                <div class=""smallImages col"">
");
#nullable restore
#line 23 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                     foreach (FlowerImage flowerImage in Model.FlowerImages.Where(fi => fi.IsMain == false).ToList())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"image \">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be6843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 814, "~/assets/images/", 814, 16, true);
#nullable restore
#line 25 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
AddHtmlAttributeValue("", 830, flowerImage.Image, 830, 18, false);

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
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"bigImage\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be8724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 982, "~/assets/images/", 982, 16, true);
#nullable restore
#line 29 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
AddHtmlAttributeValue("", 998, Model.FlowerImages.FirstOrDefault(fi=>fi.IsMain==true).Image, 998, 61, false);

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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"shopAmeryllisInfo col-lg-6 col\">\r\n                <div class=\"title\">\r\n                    <h2>");
#nullable restore
#line 34 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 35 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                     if (Model.CampaignId == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 37 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n");
#nullable restore
#line 38 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"text-decoration:line-through\">");
#nullable restore
#line 41 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</p>\r\n                        <span>");
#nullable restore
#line 42 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                          Write(Model.Price*(100-Model.Campaigns.DiscountPercent)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</span>\r\n");
#nullable restore
#line 43 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"desc\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 47 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </div>
                <div class=""quantityButton"">
                    <div class=""quantity d-flex justify-content-around align-items-center"">
                        <span>Quantity</span>
                        <div class=""icon-number"">
                            <span id=""plMinus""><i class=""fas fa-caret-left""></i></span>
                            <span id=""plproductCount"">1</span>
                            <span id=""plPlus""><i class=""fas fa-caret-right""></i></span>
                        </div>
                    </div>
                    <button type=""submit"">Add to Cart</button>
                </div>
                <div style=""margin-top: 5%; line-height: 2;"" class=""tagsCategories"">
                    <span>SKU:</span> <span style=""color: grey;"">");
#nullable restore
#line 62 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                            Write(Model.FlowerCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br>\r\n                    <span>Categories:</span> <span style=\"color: grey;\">\r\n");
#nullable restore
#line 64 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                         foreach (FlowerCategory flowerCategory in Model.FlowerCategories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>\r\n                                ");
#nullable restore
#line 67 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                           Write(flowerCategory.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n");
#nullable restore
#line 69 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span> <br>\r\n                    <span>Tags:</span> <span style=\"color: grey;\">\r\n");
#nullable restore
#line 72 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                         foreach (FlowerTag flowerTag in Model.FlowerTags)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>\r\n                                ");
#nullable restore
#line 75 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                           Write(flowerTag.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span>\r\n");
#nullable restore
#line 77 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </span><br>\r\n                    <span");
            BeginWriteAttribute("style", " style=\"", 3406, "\"", 3452, 2);
            WriteAttributeValue("", 3414, "color:", 3414, 6, true);
#nullable restore
#line 79 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
WriteAttributeValue("", 3420, Model.InStock ? "Green":"Red", 3420, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 80 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                    Write(Model.InStock ? "Available":"Not Available");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </span>

                </div>
            </div>
        </div>
    </div>
</section>
<section id=""shopDesc-info-review"">
    <div class=""shopTitle"">
        <div class=""container"">
            <div class=""row"">
                <div class=""shopDescription myCart tabActive col-lg-2"" data-id=""description"">DESCRIPTION</div>
                <div class=""shopInfo myCart col-lg-3"" data-id=""information"">ADDITIONAL INFORMATION</div>
                <div class=""shopReview myCart col-lg-2"" data-id=""reviews"">REVIEWS</div>
            </div>
        </div>
    </div>
    <div class=""shopDesc tab"" id=""description"">
        <div class=""container"">
            <div class=""row"">
                <div class=""descCart shopActive col-lg-12"">
                    <div class=""descTitle"">
                        <h2>The power of flowers</h2>
                    </div>
                    <div class=""innerDesc"">
                        <p>
                            Aliquam lorem ante");
            WriteLiteral(@", dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra
                            nulla ut
                            metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel
                            augue.
                            Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus,
                            tellus
                            eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed
                            ipsum.
                            Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio
                            et ante
                        </p>
                    </div>
                </div>

            </div>
        </div>

    </div>
    <div class=""shopInfo tab d-none"" id=""information"">
        <div class=""container"">
            <div class=""row"">
                <div class=""infoCart"">
                    <div class=""");
            WriteLiteral("infoTitleDesc\">\r\n                        <span style=\"font-size: 14px; font-weight: bold;\">\r\n                            Weight: <span style=\"color: grey; font-size: 12px;\">");
#nullable restore
#line 131 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                                           Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </span> <br>\r\n                        <span style=\"font-size: 14px; font-weight: bold;\">\r\n                            Dimensions: <span style=\"color: grey; font-size: 12px;\">");
#nullable restore
#line 134 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
                                                                               Write(Model.Dimension);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" cm</span>
                        </span>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""shopReview tab  d-none"" id=""reviews"">
        <div class=""container"">
            <div class=""row"">
                <div class=""rewievCart"">
                    <div class=""reviews"">
                        <div class=""title"">
                            <h2 style=""font-size: 29px; padding-top: 5%; font-family: 'Times New Roman', Times, serif;"">
                                Reviews
                            </h2>
                        </div>
                        <div style=""margin-top: 4%;"" class=""content d-flex"">
                            <div class=""image"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be20622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                            <div style=""margin-left: 20px;"" class=""info"">
                                <div style=""padding-bottom: 8px;"" class=""name"">
                                    <span> Joshua Garcia</span> <span style=""color: grey; font-size: 11px; padding-left: 10px;"">27.04.2018</span>
                                </div>
                                <div style=""padding-top: 10px;"" class=""desc"">
                                    <p style=""color: grey;"">
                                        Lorem ipsum dolor sit amet, consectetuer adipiscing
                                        elit. Aenean commodo
                                        ligula eget dolor. Aenean massa. Cum sociis Theme natoque penatibus et
                                        magnis dis parturient montes, nascetur ridiculus mus.
                                    </p>
                                </div>
                            </div>
                      ");
            WriteLiteral("  </div>\r\n                        <div style=\"margin-top: 4%;\" class=\"content d-flex\">\r\n                            <div class=\"image\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be23069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                            <div style=""margin-left: 20px;"" class=""info"">
                                <div style=""padding-bottom: 8px;"" class=""name"">
                                    <span> JOAN STANLEY </span> <span style=""color: grey; font-size: 11px; padding-left: 10px;"">27.04.2018</span>
                                </div>
                                <div style=""padding-top: 10px;"" class=""desc"">
                                    <p style=""color: grey;"">
                                        Etiam rhoncus. Maecenas tempus, tellus eget
                                        condimentum rhoncus, sem quam
                                        semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc,
                                        blandit vel, luctus pulvinar, hendrerit
                                    </p>
                                </div>
                            </div>
                        </div>
   ");
            WriteLiteral(@"                 </div>
                    <div style=""margin-top: 3%;"" class=""createReview"">
                        <div class=""title "">
                            <h2>Add a review</h2>
                            <p style=""color: grey; font-size: 13px;"">
                                Your email address will not be published.
                                Required fields are marked *
                            </p>
                        </div>
                        <div class=""registration"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be25894", async() => {
                WriteLiteral(@"
                                <label style=""margin-bottom:10px; color: grey; font-size: 12px;"" for=""txt"">
                                    Your
                                    review*
                                </label><br>
                                <textarea style=""width: 100%;""");
                BeginWriteAttribute("name", " name=\"", 10091, "\"", 10098, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""txt"" cols=""150"" rows=""8""
                                          required></textarea>
                                <label style=""color: grey; font-size: 12px;"" for=""name"">Name *</label><br>
                                <input style=""width: 100%; height: 50px;"" type=""text"" id=""name""
                                       required><br><br>
                                <label style=""color: grey; font-size: 12px;"" for=""mail"">Email *</label><br>
                                <input style=""width: 100%; height: 50px;"" type=""email"" id=""mail""
                                       required><br><br>
                                <input type=""checkbox""");
                BeginWriteAttribute("name", " name=\"", 10776, "\"", 10783, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 10784, "\"", 10789, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                <p style=""color: grey;"">
                                    Save my name, email, and website in this browser for the
                                    next time I comment.
                                </p>
                                <button type=""submit"">Submit</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            </div>
        </div>
    </div>
</section>
<section id=""shopRelatedProducts"">
    <div class=""container"">
        <div class=""row"">
            <h3>RELATED PRODUCTS</h3>
            <div class=""products d-flex justify-content-between"">
                ");
#nullable restore
#line 233 "C:\Users\User\Documents\BackEnd\Fiorello\Fiorello\Views\Flower\Details.cshtml"
           Write(await Html.PartialAsync("_PartialView", related));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "694afe3afac42dbf6956a1d6492f9ed3c2aec4be29805", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flower> Html { get; private set; }
    }
}
#pragma warning restore 1591
