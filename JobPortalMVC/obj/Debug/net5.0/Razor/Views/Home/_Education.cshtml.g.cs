#pragma checksum "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e60200b0445b6c082ad6fcdbf05d77c942f32cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Education), @"mvc.1.0.view", @"/Views/Home/_Education.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e60200b0445b6c082ad6fcdbf05d77c942f32cc", @"/Views/Home/_Education.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe045993f7e9076485076506ccb6f5cade32196", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Education : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JopPortalMVC.Models.UserEducationTbl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEducation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditEducation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 align=\"center\">");
#nullable restore
#line 7 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                          Write(Html.DisplayFor(modelItem => item.EducationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-md-8\">\r\n");
#nullable restore
#line 11 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                     if (item.GroupName != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b>Group Name :</b>");
#nullable restore
#line 13 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.GroupName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 14 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <b>Graduated From:</b>");
#nullable restore
#line 15 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.CompletedEducationIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Percentage :</b>");
#nullable restore
#line 16 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.PercentageObtained));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %<br />\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <b>From:</b>");
#nullable restore
#line 19 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                           Write(Html.DisplayFor(modelItem => item.YearOfStart));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Till:</b>");
#nullable restore
#line 20 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                           Write(Html.DisplayFor(modelItem => item.YearOfEnd));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                </div>\r\n                <div class=\"col-md-1\">\r\n                    \r\n                    <button type=\"button\" class=\"btn btn-light \" data-toggle=\"modal\" data-target=\"#EditEducation_");
#nullable restore
#line 24 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                                                                                                            Write(item.RowId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                        <span class=""bi bi-pencil""></span>
                    </button>
                </div>
                <hr align=""center"" width=""50%"" style=""height:2px;border-width:0;color:gray;background-color:gray"" />
            </div>
");
#nullable restore
#line 30 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    \r\n");
#nullable restore
#line 34 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
     foreach (var Education in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=", 1480, "", 1519, 1);
#nullable restore
#line 36 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 1484, "EditEducation_"+Education.RowId, 1484, 35, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e60200b0445b6c082ad6fcdbf05d77c942f32cc9520", async() => {
                WriteLiteral("\r\n                            <div class=\"row\">\r\n                                <input");
                BeginWriteAttribute("value", " value=\"", 2192, "\"", 2216, 1);
#nullable restore
#line 46 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2200, Education.RowId, 2200, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"RowId\" type=\"hidden\" />\r\n                                <input");
                BeginWriteAttribute("value", " value=\"", 2287, "\"", 2312, 1);
#nullable restore
#line 47 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2295, Education.UserId, 2295, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" type=\"hidden\" />\r\n                                Type:<label>");
#nullable restore
#line 48 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
                                       Write(Education.EducationType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"hidden\" name=\"EducationType\"");
                BeginWriteAttribute("value", " value=\"", 2497, "\"", 2529, 1);
#nullable restore
#line 49 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2505, Education.EducationType, 2505, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n                                Group:<input type=\"text\" name=\"GroupName\"");
                BeginWriteAttribute("value", " value=\"", 2623, "\"", 2651, 1);
#nullable restore
#line 50 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2631, Education.GroupName, 2631, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                From:<input type=\"text\" name=\"CompletedEducationIn\"");
                BeginWriteAttribute("value", " value=\"", 2749, "\"", 2788, 1);
#nullable restore
#line 51 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2757, Education.CompletedEducationIn, 2757, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n                                Percentage :<input type=\"number\" step=\"any\"");
                BeginWriteAttribute("value", " value=\"", 2878, "\"", 2915, 1);
#nullable restore
#line 52 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 2886, Education.PercentageObtained, 2886, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"PercentageObtained\" required />\r\n                                Start Year :<input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 3020, "\"", 3050, 1);
#nullable restore
#line 53 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 3028, Education.YearOfStart, 3028, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"YearOfStart\" required />\r\n                                End Year :<input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 3146, "\"", 3174, 1);
#nullable restore
#line 54 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
WriteAttributeValue("", 3154, Education.YearOfEnd, 3154, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""YearOfEnd"" required />
                                <hr align=""center"" width=""50%"" style=""height:2px;border-width:0;color:gray;background-color:gray"" />
                            </div>
                            <div class=""row"">
                                <button id=""CreateEducation"" type=""submit"" value=""Create"" class=""btn btn-success"">Save changes</button>
                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                            </div>
                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 66 "C:\Users\Merit\Desktop\dotnetHandsOnFiles\JopPortal\JobPortalMVC\Views\Home\_Education.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(function () {\r\n        $(\"#CreateEducation\").click(function (e) {\r\n            if (confirm(\"Do you want to Save Changes ?\")) {\r\n                $(\"#EditEducation\").submit();\r\n            }\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JopPortalMVC.Models.UserEducationTbl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
