#pragma checksum "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afdf4725a08851588bb2323c1cbd93790fa81c62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\_ViewImports.cshtml"
using MovieASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\_ViewImports.cshtml"
using MovieASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afdf4725a08851588bb2323c1cbd93790fa81c62", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ab559656fbc9edf325a7eb5420907edcd9ada5", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dal.Entities.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Liste des films</h1>\r\n");
#nullable restore
#line 5 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
 if (MovieASP.Tools.SessionHelper.User != null && MovieASP.Tools.SessionHelper.User.IsAdmin)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afdf4725a08851588bb2323c1cbd93790fa81c623765", async() => {
                WriteLiteral("Ajouter un film");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 10 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Synopsis));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n               \r\n                <td>\r\n");
#nullable restore
#line 44 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
                     if (MovieASP.Tools.SessionHelper.User != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
                   Write(Html.ActionLink("Details", "Detail", new { id = item.Id }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
                                                                                   
                    }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Steve\source\Demo\NetAzure21\CorrectifFilmASP\MovieASP\Views\Movie\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dal.Entities.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
