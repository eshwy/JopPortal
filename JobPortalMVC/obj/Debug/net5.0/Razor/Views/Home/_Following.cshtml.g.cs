#pragma checksum "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b172d093990698cf03f5f73bfacd0433ed4b09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Following), @"mvc.1.0.view", @"/Views/Home/_Following.cshtml")]
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
#line 1 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\_ViewImports.cshtml"
using JobPortalMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\_ViewImports.cshtml"
using JobPortalMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b172d093990698cf03f5f73bfacd0433ed4b09", @"/Views/Home/_Following.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe045993f7e9076485076506ccb6f5cade32196", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Following : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JobPortalMVC.Models.FollowingFollowerNameDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditFollowing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditFollowing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n    <h3>Following : ");
#nullable restore
#line 5 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
               Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-7\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n        <button type=\"button\" class=\"btn btn-outline-danger\" data-toggle=\"modal\" data-target=\"#EditFollowing_");
#nullable restore
#line 17 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
                                                                                                        Write(item.RowId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            UnFollow\r\n        </button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 22 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=", 613, "", 647, 1);
#nullable restore
#line 26 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
WriteAttributeValue("", 617, "EditFollowing_"+item.RowId, 617, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4 class=""modal-title"" id=""myModalLabel"">Modal title</h4>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7b172d093990698cf03f5f73bfacd0433ed4b097156", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            Do you want to &nbsp;<b>UnFollow ");
#nullable restore
#line 36 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
                                                        Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>&nbsp; From Following ?\r\n                        </div>\r\n                        <div class=\"row d-flex align-items-center justify-content-center\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
                       Write(Html.ActionLink("UnFollow", "EditFollowing", "Edit", new { rowId = item.RowId, UserId =item.FollowerId }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Following.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        $(\"#CreateEducation\").click(function (e) {\r\n            if (confirm(\"Do you want to Save Changes ?\")) {\r\n                $(\"#EditEducation\").submit();\r\n            }\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JobPortalMVC.Models.FollowingFollowerNameDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
