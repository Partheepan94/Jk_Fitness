#pragma checksum "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d8bb5847cc56a4d0d9f7b6384651fb8a244642a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_ExpensesType), @"mvc.1.0.view", @"/Views/Settings/ExpensesType.cshtml")]
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
#line 1 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\_ViewImports.cshtml"
using Jk_Fitness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d8bb5847cc56a4d0d9f7b6384651fb8a244642a", @"/Views/Settings/ExpensesType.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a76d35d50c8069bc61a8cb5322bee13fcae6d10", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_ExpensesType : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/img/Loading.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-label-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/page.expensesTypes.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
  
    ViewData["Title"] = "Expenses Types";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""form-group"">
                    <h3 class=""card-title"">Display Expenses Types Details</h3>
                </div>
            </div>
            <div class=""card-body"">
");
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label>Expenses Name</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <input type=""text"" id=""ExpensesName"" class=""form-control"" placeholder=""Enter Expenses Name"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <label>Expense Type Code</label>
                            <div class=""col-md-12 col-sm-12 "">
                                <input type=""text"" id=""ExpenseCode"" class=""form-control"" placeholder=""Enter Expense Code"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div style=""float:right"">
                                <b");
            WriteLiteral(@"utton type=""button"" id=""btnSearch"" class=""btn btn-secondary""><i class=""fa fa-search""></i> Search</button>
                                <button type=""button"" id=""btnAdd"" class=""btn btn-success""><i class=""fa fa-plus""></i> Add New</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""card-footer table-responsive"">
                <table id=""tblExpenseTypes"" class=""table table-bordered table-striped tblExpenseTypes"">
                    <thead>
                        <tr>
                            <th>Expense Code</th>
                            <th>Expense Name</th>
                            <th>Status</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody id=""tbodyid"">
                    </tbody>
                </table>
                <div class=""msg-block""");
            WriteLiteral(" id=\"noRecords\">\r\n                    <label>No Records found.</label>\r\n                </div>\r\n            </div>\r\n            <div id=\"wait\" class=\"loading-gif\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d8bb5847cc56a4d0d9f7b6384651fb8a244642a8906", async() => {
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
            WriteLiteral("<br></div>\r\n        </div>\r\n        <!-- /.card -->\r\n    </div>\r\n    <!-- /.col -->\r\n    <input type=\"hidden\" id=\"GetExpensesDetails\"");
            BeginWriteAttribute("value", " value=\"", 3170, "\"", 3223, 1);
#nullable restore
#line 70 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3178, Url.Action("GetExpensesDetails", "Settings"), 3178, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SaveExpensesType\"");
            BeginWriteAttribute("value", " value=\"", 3275, "\"", 3326, 1);
#nullable restore
#line 71 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3283, Url.Action("SaveExpensesType", "Settings"), 3283, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"UpdateExpenseType\"");
            BeginWriteAttribute("value", " value=\"", 3379, "\"", 3431, 1);
#nullable restore
#line 72 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3387, Url.Action("UpdateExpenseType", "Settings"), 3387, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"GetExpenseTypeById\"");
            BeginWriteAttribute("value", " value=\"", 3485, "\"", 3538, 1);
#nullable restore
#line 73 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3493, Url.Action("GetExpenseTypeById", "Settings"), 3493, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"DeleteExpenseType\"");
            BeginWriteAttribute("value", " value=\"", 3591, "\"", 3643, 1);
#nullable restore
#line 74 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3599, Url.Action("DeleteExpenseType", "Settings"), 3599, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"SearchExpensesType\"");
            BeginWriteAttribute("value", " value=\"", 3697, "\"", 3750, 1);
#nullable restore
#line 75 "E:\Gym_Project\New\Jk_Fitness\Jk_Fitness\Jk_Fitness\Views\Settings\ExpensesType.cshtml"
WriteAttributeValue("", 3705, Url.Action("SearchExpensesType", "Settings"), 3705, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n\r\n");
            WriteLiteral(@"<div id=""ExpensesTypeModal"" class=""modal fade bs-example-modal-lg"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""myModalLabel""><strong>Expenses Type Details</strong></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""Cancel()"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""x_panel"">
                    <div class=""x_content"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8bb5847cc56a4d0d9f7b6384651fb8a244642a13730", async() => {
                WriteLiteral(@"
                            <input type=""hidden"" value=""0"" id=""ExpenseId"" />

                            <div class=""form-group row"" id=""ExpenseField"" style=""display:none;"">
                                <label class=""control-label col-md-4 col-sm-4"">Expenses Code</label>
                                <div class=""col-md-8 col-sm-8"">
                                    <input type=""text"" required id=""Ecode"" class=""form-control"" disabled>
                                </div>
                            </div>
                            <div class=""form-group row "">
                                <label class=""control-label col-md-4 col-sm-4 "">Expenses Name</label>
                                <div class=""col-md-8 col-sm-8"">
                                    <input type=""text"" id=""Ename"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""custom-control custom-checkbox"">
                            ");
                WriteLiteral(@"    <input class=""custom-control-input"" type=""checkbox"" id=""Enabled"" value=""true"">
                                <label for=""Enabled"" class=""custom-control-label"">Enable</label>
                            </div>
                            <div class=""ln_solid""></div>
                            <div class=""form-group"">
                                <div style=""float:right"">
                                    <button type=""button"" id=""btnAddExpense"" class=""btn btn-success"">Save</button>
                                    <button type=""button"" onclick=""Cancel()"" class=""btn btn-warning"">Cancel</button>
                                </div>
                            </div>
                            <div id=""wait"" style=""display:none;position:fixed;top:30%;left:50%;padding:2px;"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d8bb5847cc56a4d0d9f7b6384651fb8a244642a15924", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d8bb5847cc56a4d0d9f7b6384651fb8a244642a18561", async() => {
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
