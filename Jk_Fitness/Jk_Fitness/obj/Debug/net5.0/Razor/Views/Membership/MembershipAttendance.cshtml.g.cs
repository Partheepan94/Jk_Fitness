#pragma checksum "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d79962976261e4f15ef3be48b971737d707e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membership_MembershipAttendance), @"mvc.1.0.view", @"/Views/Membership/MembershipAttendance.cshtml")]
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
#line 1 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d79962976261e4f15ef3be48b971737d707e0a", @"/Views/Membership/MembershipAttendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a76d35d50c8069bc61a8cb5322bee13fcae6d10", @"/Views/_ViewImports.cshtml")]
    public class Views_Membership_MembershipAttendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/Loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Attendance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/page.membersAttendance.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
  
    ViewData["Title"] = "MembershipAttendance";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""form-group"">
                    <h3 class=""card-title"">Members Attendance</h3>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Branch</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <select class=""form-control"" id=""Branch""></select>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>FirstName</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <input type=""text"" id=""FName"" class=""form-control"" ");
            WriteLiteral(@"placeholder=""FirstName"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""form-group"">
                            <label>Date</label>
                            <div class=""input-group date col-md-12 col-sm-12"" id=""date"" data-target-input=""nearest"">
                                <input type=""text"" id=""AttendDate"" class=""form-control datetimepicker-input"" data-target=""#date"" data-toggle=""datetimepicker"" />
                                <div class=""input-group-append"" data-target=""#date"" data-toggle=""datetimepicker"">
                                    <div class=""input-group-text""><i class=""fa fa-calendar""></i></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3"" style=""padding-top:31px"">
                        <div class=""form-group"">
     ");
            WriteLiteral(@"                       <button type=""button"" id=""btnSearch"" class=""btn btn-secondary col-md-12 col-sm-12""><i class=""fa fa-search""></i> Search</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer table-responsive"">
                <table id=""example1"" class=""table table-bordered table-striped tblMember"">
                    <thead>
                        <tr>
                            <th>MemberShip Id</th>
                            <th>Name</th>
                            <th>Morning Time</th>
                            <th>Evening Time</th>
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
            ");
            WriteLiteral("<div id=\"wait\" class=\"loading-gif\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77d79962976261e4f15ef3be48b971737d707e0a9639", async() => {
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
            WriteLiteral("<br></div>\r\n        </div>\r\n    </div>\r\n    <input type=\"hidden\" id=\"GetBranchDetails\"");
            BeginWriteAttribute("value", " value=\"", 3357, "\"", 3408, 1);
#nullable restore
#line 72 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3365, Url.Action("GetBranchDetails", "Employee"), 3365, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SaveMembersAttendance\"");
            BeginWriteAttribute("value", " value=\"", 3465, "\"", 3522, 1);
#nullable restore
#line 73 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3473, Url.Action("SaveMemberAttendance", "Membership"), 3473, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"UpdateMemberAttendance\"");
            BeginWriteAttribute("value", " value=\"", 3580, "\"", 3639, 1);
#nullable restore
#line 74 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3588, Url.Action("UpdateMemberAttendance", "Membership"), 3588, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"GetMemberShipAttendanceDetails\"");
            BeginWriteAttribute("value", " value=\"", 3705, "\"", 3772, 1);
#nullable restore
#line 75 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3713, Url.Action("GetMemberShipAttendanceDetails", "Membership"), 3713, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"DeleteMemberAttendance\"");
            BeginWriteAttribute("value", " value=\"", 3830, "\"", 3889, 1);
#nullable restore
#line 76 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3838, Url.Action("DeleteMemberAttendance", "Membership"), 3838, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"LoadMemberShipAttendanceDetails\"");
            BeginWriteAttribute("value", " value=\"", 3956, "\"", 4024, 1);
#nullable restore
#line 77 "E:\Gym_Project\MembershipAttendance\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Membership\MembershipAttendance.cshtml"
WriteAttributeValue("", 3964, Url.Action("LoadMemberShipAttendanceDetails", "Membership"), 3964, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

</div>

<div id=""AttendanceModal"" class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel""><strong>Attendance Time</strong></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""Cancel()"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""x_panel"">
                    <div class=""x_content"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d79962976261e4f15ef3be48b971737d707e0a14618", async() => {
                WriteLiteral(@"
                            <input type=""hidden"" value=""0"" id=""MemberId"" />
                            <input type=""hidden"" value=""0"" id=""AttendanceId"" />
                            <div class=""bootstrap-timepicker"">
                                <div class=""form-group row"">
                                    <label class=""control-label col-md-3 col-sm-3"">Morning Start Time</label>

                                    <div class=""input-group date col-md-3 col-sm-3"" id=""timepicker"" data-target-input=""nearest"">
                                        <input type=""text"" id=""MorningIn"" class=""form-control datetimepicker-input"" data-target=""#timepicker"" data-toggle=""datetimepicker"" />
                                        <div class=""input-group-append"" data-target=""#timepicker"" data-toggle=""datetimepicker"">
                                            <div class=""input-group-text""><i class=""far fa-clock""></i></div>
                                        </div>
                                 ");
                WriteLiteral(@"   </div>

                                    <label class=""control-label col-md-3 col-sm-3"">Morning End Time</label>

                                    <div class=""input-group date col-md-3 col-sm-3"" id=""timepicker1"" data-target-input=""nearest"">
                                        <input type=""text"" id=""MorningOut"" class=""form-control datetimepicker-input"" data-target=""#timepicker1"" data-toggle=""datetimepicker"" />
                                        <div class=""input-group-append"" data-target=""#timepicker1"" data-toggle=""datetimepicker"">
                                            <div class=""input-group-text""><i class=""far fa-clock""></i></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""bootstrap-timepicker"">
                                <div class=""form-group row"">
                                    <label class=""control-");
                WriteLiteral(@"label col-md-3 col-sm-3"">Evening Start Time</label>

                                    <div class=""input-group date col-md-3 col-sm-3"" id=""timepicker2"" data-target-input=""nearest"">
                                        <input type=""text"" id=""EveningIn"" class=""form-control datetimepicker-input"" data-target=""#timepicker2"" data-toggle=""datetimepicker"" />
                                        <div class=""input-group-append"" data-target=""#timepicker2"" data-toggle=""datetimepicker"">
                                            <div class=""input-group-text""><i class=""far fa-clock""></i></div>
                                        </div>
                                    </div>

                                    <label class=""control-label col-md-3 col-sm-3"" ");
                WriteLiteral(@">Evening End Time</label>

                                    <div class=""input-group date col-md-3 col-sm-3"" id=""timepicker3"" data-target-input=""nearest"">
                                        <input type=""text"" id=""EveningOut"" class=""form-control datetimepicker-input"" data-target=""#timepicker3"" data-toggle=""datetimepicker"" />
                                        <div class=""input-group-append"" data-target=""#timepicker3"" data-toggle=""datetimepicker"">
                                            <div class=""input-group-text""><i class=""far fa-clock""></i></div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""ln_solid""></div>
                            <div class=""form-group"">
                                <div style=""float:right"">
                                    <button type=""button"" id=""btnAddMemberAttendance"" class=""btn btn-succe");
                WriteLiteral(@"ss"">Save</button>
                                    <button type=""button"" onclick=""Cancel()"" class=""btn btn-warning"">Cancel</button>
                                </div>
                            </div>
                            <div id=""waitform"" class=""loading-gif"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77d79962976261e4f15ef3be48b971737d707e0a19303", async() => {
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
                WriteLiteral("<br></div>\r\n                        ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77d79962976261e4f15ef3be48b971737d707e0a21940", async() => {
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
            WriteLiteral("\r\n\r\n");
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
