#pragma checksum "C:\Users\Administrator\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da87e918561f88db3d077f39b3b63f5e3e62ebb"
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
#line 1 "C:\Users\Administrator\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da87e918561f88db3d077f39b3b63f5e3e62ebb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/mobile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Administrator\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section class=\"page-intro\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-12 col-lg-6 col-md-12\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8da87e918561f88db3d077f39b3b63f5e3e62ebb4885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-sm-12 col-lg-6 col-md-12 title"">
                    <div>
                        <h1>Responsive App Landing Page</h1>

                        <div>
                            <p>Bootstrap Based Responsive Landing Page Template.</p>
                        </div>
                        <div>
                            <button type=""button"" class=""btn btn-success"">
                                <span class=""icon"">
                                    <i class=""fa-solid fa-mobile-screen-button""></i>
                                </span>

                                <span>
                                    Available on the <br>
                                    App Store
                                </span>



                            </button>
                        </div>



                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""services""");
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-4 "">
                    <div class=""service-icon"">
                        <i class=""fa-solid fa-tablet-screen-button""></i>
                    </div>
                    <div class=""service-title"">
                        <h3>Responsive Bootstrap Template</h3>
                    </div>
                    <div class=""service-text"">
                        <p>Lorem ipsum dolizzle sit tellivizzle, boom shackalack adipiscing elit. Nullam mofo velizzle, get down get down stuff, sure cool, dizzle vizzle, arcu. Yo mamma izzle tortizzle</p>
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""service-icon"">
                        <i class=""fa-solid fa-pen""></i>
                    </div>
                    <div class=""service-title"">
                        <h3>Easy to Customize</h3>
                    </div>
                    <d");
            WriteLiteral(@"iv class=""service-text"">
                        <p>Lorem ipsum dolizzle sit tellivizzle, boom shackalack adipiscing elit. Nullam mofo velizzle, get down get down stuff, sure cool, dizzle vizzle, arcu. Yo mamma izzle tortizzle</p>
                    </div>
                </div>
                <div class=""col-4"">
                    <div class=""service-icon"">
                        <i class=""fa-solid fa-star""></i>
                    </div>
                    <div class=""service-title"">
                        <h3>Ideal for Apps or Software</h3>
                    </div>
                    <div class=""service-text"">
                        <p>Lorem ipsum dolizzle sit tellivizzle, boom shackalack adipiscing elit. Nullam mofo velizzle, get down get down stuff, sure cool, dizzle vizzle, arcu. Yo mamma izzle tortizzle</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""slider"">
        <div class=""container"">
        ");
            WriteLiteral(@"    <div class=""slide-title"">
                <h2>What people say</h2>
            </div>
            <div class="" slide"">
                <div id=""carouselExampleCaptions"" class=""carousel slide"" data-bs-ride=""carousel"">
                    <div class=""carousel-indicators"">
                        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
                        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
                        <button type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
                    </div>
                    <div class=""carousel-inner"">
                        <div class=""carousel-item active"">
                            <p>""Etizzle laoreet doggy dope nisl. Dang pulvinizzle, ipsizzle dawg.""</p>
                            <h5>Martin Nizz");
            WriteLiteral(@"le</h5>

                        </div>
                        <div class=""carousel-item"">
                            <p>""Crazy tellus urna, yo mamma check out this, eleifend you son of a bizzle.""</p>
                            <h5>Jennifer Aliquizzle</h5>
                        </div>
                        <div class=""carousel-item"">
                            <p>""Praesent i saw beyonces tizzles and my pizzle went crizzle turpizzle.""</p>
                            <h5>William Lorizzle</h5>
                        </div>
                    </div>
                    <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data-bs-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""visually-hidden"">Previous</span>
                    </button>
                    <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleCaptions"" data");
            WriteLiteral(@"-bs-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""visually-hidden"">Next</span>
                    </button>
                </div>
            </div>

        </div>
    </section>
    <section class=""contact-us"">
        <div class=""container"">
            <div class=""contact-title"">
                <h2>Contact us</h2>
                <p>Want to chat? Send us a message. We'd love to hear from you!</p>
            </div>
            <div class=""contact-message"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8da87e918561f88db3d077f39b3b63f5e3e62ebb12013", async() => {
                WriteLiteral(@"
                    <div class=""col-md-6"">
                        <label for=""inputName"" class=""form-label"">Name</label>
                        <input type=""text"" class=""form-control"" id=""inputName"">
                    </div>
                    <div class=""col-md-6"">
                        <label for=""inputEmail4"" class=""form-label"">Email</label>
                        <input type=""email"" class=""form-control"" id=""inputEmail4"">
                    </div>
                    <div class=""col-12"">
                        <label for=""inputMessage"" class=""form-label"">Message</label>
                        <input type=""text"" class=""form-control"" id=""inputMessage"">
                    </div>
                    <div class=""d-grid gap-2"">
                        <button class=""btn btn-primary"" type=""button"">Send</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
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