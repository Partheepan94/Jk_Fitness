#pragma checksum "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_MembershipType), @"mvc.1.0.view", @"/Views/Settings/MembershipType.cshtml")]
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
#line 1 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c6", @"/Views/Settings/MembershipType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a76d35d50c8069bc61a8cb5322bee13fcae6d10", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_MembershipType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/Loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/page.membershipTypes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
  
    ViewData["Title"] = "Membership Types";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""form-group"">
                    <h3 class=""card-title"">Display Membership Package Details</h3>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <label><strong style=""color: red"">Membership packages cannot delete until it depends on other records in the application.</strong></label>
                    </div>
                </div>
                <br />
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label>Package Name</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <input type=""text"" id=""MembershipName"" class=""form-control"" placeholder=""Enter Membership Name"">
     ");
            WriteLiteral(@"                       </div>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label>Package Code</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <input type=""text"" id=""MembershipCode"" class=""form-control"" placeholder=""Enter Membership Code"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div style=""float:right"">
                                <button type=""button"" id=""btnSearch"" class=""btn btn-secondary""><i class=""fa fa-search""></i> Search</button>
                                <button type=""button"" id=""btnAdd"" class=""btn btn-success""><i class=""fa fa-plus""></i> Add New</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>");
            WriteLiteral(@"
            <div class=""card-footer table-responsive"">
                <table id=""tblMembershipTypes"" class=""table table-bordered table-striped tblMembershipTypes"">
                    <thead>
                        <tr>
                            <th>Package Code</th>
                            <th>Package Name</th>
                            <th>Months Per Package</th>
                            <th>Package Amount</th>
                            <th>Status</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody id=""tbodyid"">
                    </tbody>
                </table>
                <div class=""msg-block"" id=""noRecords"">
                    <label>No Records found.</label>
                </div>
            </div>
            <div id=""wait"" class=""loading-gif"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c69378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br></div>\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n    <!-- /.col -->\r\n    <input type=\"hidden\" id=\"GetMembershipTypeDetails\"");
            BeginWriteAttribute("value", " value=\"", 3270, "\"", 3329, 1);
#nullable restore
#line 71 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3278, Url.Action("GetMembershipTypeDetails", "Settings"), 3278, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SaveMembershipType\"");
            BeginWriteAttribute("value", " value=\"", 3383, "\"", 3436, 1);
#nullable restore
#line 72 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3391, Url.Action("SaveMembershipType", "Settings"), 3391, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"UpdateMembershipType\"");
            BeginWriteAttribute("value", " value=\"", 3492, "\"", 3547, 1);
#nullable restore
#line 73 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3500, Url.Action("UpdateMembershipType", "Settings"), 3500, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"GetMembershipTypeById\"");
            BeginWriteAttribute("value", " value=\"", 3604, "\"", 3660, 1);
#nullable restore
#line 74 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3612, Url.Action("GetMembershipTypeById", "Settings"), 3612, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"DeleteMembershipType\"");
            BeginWriteAttribute("value", " value=\"", 3716, "\"", 3771, 1);
#nullable restore
#line 75 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3724, Url.Action("DeleteMembershipType", "Settings"), 3724, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SearchMembershipType\"");
            BeginWriteAttribute("value", " value=\"", 3827, "\"", 3882, 1);
#nullable restore
#line 76 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3835, Url.Action("SearchMembershipType", "Settings"), 3835, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"add\"");
            BeginWriteAttribute("value", " value=\"", 3921, "\"", 3941, 1);
#nullable restore
#line 77 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3929, ViewBag.Add, 3929, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"edit\"");
            BeginWriteAttribute("value", " value=\"", 3981, "\"", 4002, 1);
#nullable restore
#line 78 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 3989, ViewBag.Edit, 3989, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"delete\"");
            BeginWriteAttribute("value", " value=\"", 4044, "\"", 4067, 1);
#nullable restore
#line 79 "E:\Gym_Project\Payment_Changes(Current)\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\MembershipType.cshtml"
WriteAttributeValue("", 4052, ViewBag.Delete, 4052, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div id=""MembershipTypeModal"" class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel""><strong>Membership Package Details</strong></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""Cancel()"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""x_panel"">
                    <div class=""x_content"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c615710", async() => {
                WriteLiteral(@"
                            <input type=""hidden"" value=""0"" id=""MembershipId"" />

                            <div class=""form-group row"" id=""MembershipField"" style=""display:none;"">
                                <label class=""control-label col-md-4 col-sm-4"">Package Code</label>
                                <div class=""col-md-8 col-sm-8"">
                                    <input type=""text"" required id=""Mcode"" class=""form-control"" disabled>
                                </div>
                            </div>
                            <div class=""form-group row "">
                                <label class=""control-label col-md-4 col-sm-4 "">Package Name</label>
                                <div class=""col-md-8 col-sm-8"">
                                    <input type=""text"" id=""Mname"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""form-group row "">
                                <label ");
                WriteLiteral(@"class=""control-label col-md-4 col-sm-4 "">Months Per Package</label>
                                <div class=""col-md-8 col-sm-8"">
                                    <select class=""form-control"" id=""Months""></select>
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <label class=""control-label col-md-4 col-sm-4 "">Package Amount</label>
                                <div class=""col-md-8 col-sm-8 "">
                                    <input type=""text"" id=""MemAmount"" class=""form-control"">
                                    <span id=""Rfrm"" class=""error"" style=""color: red;display:none"">
                                        Should be Numeric Value
                                    </span>
                                </div>
                            </div>

                            <div class=""custom-control custom-checkbox"">
                                <input clas");
                WriteLiteral(@"s=""custom-control-input"" type=""checkbox"" id=""Enabled"" value=""true"">
                                <label for=""Enabled"" class=""custom-control-label"">Enable</label>
                            </div>
                            <div class=""ln_solid""></div>
                            <div class=""form-group"">
                                <div style=""float:right"">
                                    <button type=""button"" id=""btnAddMembership"" class=""btn btn-success"">Save</button>
                                    <button type=""button"" onclick=""Cancel()"" class=""btn btn-warning"">Cancel</button>
                                </div>
                            </div>
                            <div id=""wait"" class=""loading-gif"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c618934", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br></div>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c0c9b9f088ef25951cfe2ed5b19c51b6e0278c621575", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
