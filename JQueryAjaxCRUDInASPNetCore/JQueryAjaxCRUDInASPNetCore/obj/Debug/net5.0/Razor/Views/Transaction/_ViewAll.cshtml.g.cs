#pragma checksum "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18ec1fb42011021caa5604ed8803a78f0af2a10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__ViewAll), @"mvc.1.0.view", @"/Views/Transaction/_ViewAll.cshtml")]
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
#line 1 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\_ViewImports.cshtml"
using JQueryAjaxCRUDInASPNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\_ViewImports.cshtml"
using JQueryAjaxCRUDInASPNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18ec1fb42011021caa5604ed8803a78f0af2a10", @"/Views/Transaction/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a51119e496a7b10396ad7705fa7d02ae39b3922", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JQueryAjaxCRUDInASPNetCore.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryAjaxDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 574, "\"", 683, 4);
            WriteAttributeValue("", 584, "showInPopup(\'", 584, 13, true);
#nullable restore
#line 23 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 597, Url.Action("AddOrEdit","Transaction",null,Context.Request.Scheme), 597, 66, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 663, "\',\'New", 663, 6, true);
            WriteAttributeValue(" ", 669, "Transaction\')", 670, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white font-weight-bold\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal\"><i class=\"fas fa-random\"></i> New Transaction</a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.BeneficiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <div>\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1499, "\"", 1623, 4);
            WriteAttributeValue("", 1509, "showInPopup(\'", 1509, 13, true);
#nullable restore
#line 47 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
WriteAttributeValue("", 1522, Url.Action("AddOrEdit","Transaction",new {id=item.Id},Context.Request.Scheme), 1522, 78, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1600, "\',\'Update", 1600, 9, true);
            WriteAttributeValue(" ", 1609, "Transaction\')", 1610, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\"><i class=\"fas fa-pencil-alt\"></i> Edit</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d18ec1fb42011021caa5604ed8803a78f0af2a109963", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d18ec1fb42011021caa5604ed8803a78f0af2a1010249", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 49 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "D:\DotNet\ASP.Net\Tedu\JQueryAjaxCRUDInASPNetCore\JQueryAjaxCRUDInASPNetCore\Views\Transaction\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JQueryAjaxCRUDInASPNetCore.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
