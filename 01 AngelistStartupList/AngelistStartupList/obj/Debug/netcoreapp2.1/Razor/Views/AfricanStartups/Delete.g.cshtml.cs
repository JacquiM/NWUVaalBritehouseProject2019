#pragma checksum "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd4d5182e474cdc6b8cb583198df5a885129061a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AfricanStartups_Delete), @"mvc.1.0.view", @"/Views/AfricanStartups/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AfricanStartups/Delete.cshtml", typeof(AspNetCore.Views_AfricanStartups_Delete))]
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
#line 1 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\_ViewImports.cshtml"
using AngelistStartupList;

#line default
#line hidden
#line 2 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\_ViewImports.cshtml"
using AngelistStartupList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd4d5182e474cdc6b8cb583198df5a885129061a", @"/Views/AfricanStartups/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c7df3e09d45a8d29c2b16f83b045063f197b4b1", @"/Views/_ViewImports.cshtml")]
    public class Views_AfricanStartups_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AngelistStartupList.Models.AfricanStartup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(94, 175, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AfricanStartup</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(270, 48, false);
#line 15 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AngellistUrl));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(362, 44, false);
#line 18 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AngellistUrl));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(450, 43, false);
#line 21 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BlogUrl));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(537, 39, false);
#line 24 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BlogUrl));

#line default
#line hidden
            EndContext();
            BeginContext(576, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(620, 52, false);
#line 27 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CommunityProfile));

#line default
#line hidden
            EndContext();
            BeginContext(672, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(716, 48, false);
#line 30 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CommunityProfile));

#line default
#line hidden
            EndContext();
            BeginContext(764, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(808, 47, false);
#line 33 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanySize));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(899, 43, false);
#line 36 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompanySize));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(986, 47, false);
#line 39 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyType));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1077, 43, false);
#line 42 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompanyType));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1164, 46, false);
#line 45 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1254, 42, false);
#line 48 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompanyUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1340, 43, false);
#line 51 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1427, 39, false);
#line 54 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1510, 45, false);
#line 57 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1599, 41, false);
#line 60 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1684, 49, false);
#line 63 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CrunchbaseUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1777, 45, false);
#line 66 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CrunchbaseUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1822, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1866, 47, false);
#line 69 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FacebookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1957, 43, false);
#line 72 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FacebookUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2000, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2044, 49, false);
#line 75 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FollowerCount));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2137, 45, false);
#line 78 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FollowerCount));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2226, 47, false);
#line 81 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HighConcept));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2317, 43, false);
#line 84 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HighConcept));

#line default
#line hidden
            EndContext();
            BeginContext(2360, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2404, 38, false);
#line 87 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2486, 34, false);
#line 90 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2564, 47, false);
#line 93 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LinkedinUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2655, 43, false);
#line 96 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LinkedinUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2742, 45, false);
#line 99 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Locations));

#line default
#line hidden
            EndContext();
            BeginContext(2787, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2831, 41, false);
#line 102 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Locations));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2916, 43, false);
#line 105 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LogoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2959, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3003, 39, false);
#line 108 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LogoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(3042, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3086, 43, false);
#line 111 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Markets));

#line default
#line hidden
            EndContext();
            BeginContext(3129, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3173, 39, false);
#line 114 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Markets));

#line default
#line hidden
            EndContext();
            BeginContext(3212, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3256, 40, false);
#line 117 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3340, 36, false);
#line 120 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3376, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3420, 47, false);
#line 123 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductDesc));

#line default
#line hidden
            EndContext();
            BeginContext(3467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3511, 43, false);
#line 126 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductDesc));

#line default
#line hidden
            EndContext();
            BeginContext(3554, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3598, 43, false);
#line 129 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quality));

#line default
#line hidden
            EndContext();
            BeginContext(3641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3685, 39, false);
#line 132 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quality));

#line default
#line hidden
            EndContext();
            BeginContext(3724, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3768, 47, false);
#line 135 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Screenshots));

#line default
#line hidden
            EndContext();
            BeginContext(3815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3859, 43, false);
#line 138 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Screenshots));

#line default
#line hidden
            EndContext();
            BeginContext(3902, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3946, 42, false);
#line 141 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3988, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4032, 38, false);
#line 144 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(4070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4114, 44, false);
#line 147 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ThumbUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4158, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4202, 40, false);
#line 150 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ThumbUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4242, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4286, 46, false);
#line 153 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4332, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4376, 42, false);
#line 156 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TwitterUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4418, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4462, 45, false);
#line 159 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(4507, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4551, 41, false);
#line 162 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(4592, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4636, 44, false);
#line 165 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.VideoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4724, 40, false);
#line 168 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
       Write(Html.DisplayFor(model => model.VideoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4764, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4802, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e08ad810db18427eba0fac28f737b0f7", async() => {
                BeginContext(4828, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4838, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ee8d2ecadb1d4049b6e1f3bdfd8f8961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 173 "C:\Users\Jacqui.Muller\source\repos\AngelistStartupList\AngelistStartupList\Views\AfricanStartups\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ListId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4878, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4962, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d02867f1dc154a70a717b0c1bb94f6c9", async() => {
                    BeginContext(4984, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5000, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5013, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AngelistStartupList.Models.AfricanStartup> Html { get; private set; }
    }
}
#pragma warning restore 1591
