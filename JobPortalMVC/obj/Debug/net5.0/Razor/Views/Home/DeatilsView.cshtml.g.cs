#pragma checksum "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e27365629ea97fe28b962f76e1ebf3dd849cd6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DeatilsView), @"mvc.1.0.view", @"/Views/Home/DeatilsView.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e27365629ea97fe28b962f76e1ebf3dd849cd6c", @"/Views/Home/DeatilsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe045993f7e9076485076506ccb6f5cade32196", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DeatilsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<JopPortalMVC.Models.DetailsView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeatilsView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
  
    ViewData["Title"] = "DeatilsView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e27365629ea97fe28b962f76e1ebf3dd849cd6c5115", async() => {
                WriteLiteral("\r\n            <h4><u><b>SORT By</b></u></h4>\r\n            Skills : ");
#nullable restore
#line 13 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                Write(Html.DropDownList("Skill", TempData["Skill"] as IEnumerable<SelectListItem>));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <hr />\r\n            <br />\r\n            Gender : ");
#nullable restore
#line 16 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                Write(Html.DropDownList("Gender", TempData["Gender"] as IEnumerable<SelectListItem>));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <hr />\r\n            <br />\r\n            Sort By : ");
#nullable restore
#line 19 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                 Write(Html.DropDownList("Sort", TempData["Sort"] as IEnumerable<SelectListItem>));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <hr />\r\n            <br />\r\n            Search: <input type=\"text\" name=\"SearchString\" placeholder=\"Name,Email & Experience\"");
                BeginWriteAttribute("value", " value=\"", 815, "\"", 847, 1);
#nullable restore
#line 22 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
WriteAttributeValue("", 823, ViewData["ValueFilter"], 823, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <hr />\r\n            <br />\r\n            <input type=\"submit\" value=\"Search\" class=\"btn btn-success\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e27365629ea97fe28b962f76e1ebf3dd849cd6c7216", async() => {
                    WriteLiteral("Clear Filter ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n");
#nullable restore
#line 30 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-2\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1252, "\"", 1273, 1);
#nullable restore
#line 34 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
WriteAttributeValue("", 1258, item.PhotoPath, 1258, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"100\" width=\"130\" />\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <p><b>Name      : </b>");
#nullable restore
#line 37 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                     Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><b>Gender    : </b>");
#nullable restore
#line 38 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                     Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><b>Contact No: </b>");
#nullable restore
#line 39 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                     Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <p><b>Email      : </b>");
#nullable restore
#line 42 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                      Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><b>Skills     :</b>");
#nullable restore
#line 43 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                     Write(item.Skills);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><b>Experience :</b>");
#nullable restore
#line 44 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
                                     Write(item.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
               Write(Html.ActionLink("View", "ParticularView", new { UserId = item.UserId }, new { @class = "btn btn-primary btn-small" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <hr />\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 52 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <table align=""center"">
        <tr>
            <td style=""font-size:25px ;text-decoration:underline;text-decoration-color:black"">
                Pages
            </td>
        </tr>
        <tr align=""center"">
            <td style=""font-size:25px"">
                ");
#nullable restore
#line 62 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\DeatilsView.cshtml"
           Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("DeatilsView", new { page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<JopPortalMVC.Models.DetailsView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
