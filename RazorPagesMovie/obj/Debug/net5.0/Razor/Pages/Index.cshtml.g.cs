#pragma checksum "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427c4179497572d4d8ca995dc372291d207b4c55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RazorPagesMovie.Pages
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
#line 1 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427c4179497572d4d8ca995dc372291d207b4c55", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d8f800a4a48e0455ebfde0b66fa2af02dce2b7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var Username = "Ali";
    var year = 2024;
    var people= new string[] {"John", "Mary", "Sarah"};

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 11 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
      year=2020;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"display-4\">Welcome!</h1>\r\n    <h2> This is for Week2<h2>\r\n    <h3> My username is: ");
#nullable restore
#line 14 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                    Write(Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h4> Current date is : ");
#nullable restore
#line 15 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                      Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p>");
#nullable restore
#line 16 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
  Write(year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is a leap year : ");
#nullable restore
#line 16 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                         Write(DateTime.IsLeapYear(@year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Last week this time: ");
#nullable restore
#line 17 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                        Write(DateTime.Now - TimeSpan.FromDays(14));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
     for (var i = 0; i < people.Length; i++)
    {
        var person = people[i];
        

#line default
#line hidden
#nullable disable
            WriteLiteral(" Name_");
#nullable restore
#line 21 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 21 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                       Write(person);

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\MAFSHAR\WEB315-SEC002-W23\RazorPagesMovie\Pages\Index.cshtml"
                                          
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
