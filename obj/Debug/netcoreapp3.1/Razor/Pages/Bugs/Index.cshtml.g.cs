#pragma checksum "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d313244bea470ee3c61dfb1526781fd88beb091"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyBugTracker.Pages.Bugs.Pages_Bugs_Index), @"mvc.1.0.razor-page", @"/Pages/Bugs/Index.cshtml")]
namespace MyBugTracker.Pages.Bugs
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
#line 1 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\_ViewImports.cshtml"
using MyBugTracker;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d313244bea470ee3c61dfb1526781fd88beb091", @"/Pages/Bugs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d63d5cf279b002ac63bc0780d35c4f9a7cd5b6a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Bugs_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<br>
<h2>Bug List</h2>
<a class=""btn btn-primary btn-sm"" href=""/Bugs/CreateBug"">New Bug</a>
<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Title</th>
            <th>Description</th>
            <th>Assigned To</th>
            <th>Created At</th>
            <th>Action</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
         foreach (var item in Model.listBugs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
               Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
               Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
               Write(item.assigned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> <!--come back to this-->\r\n                <td>");
#nullable restore
#line 29 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
               Write(item.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n\r\n\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 846, 2);
            WriteAttributeValue("", 820, "/Bugs/EditBugs?id=", 820, 18, true);
#nullable restore
#line 33 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
WriteAttributeValue("", 838, item.id, 838, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-success btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 911, "\"", 947, 2);
            WriteAttributeValue("", 918, "/Bugs/ResolveBugs?id=", 918, 21, true);
#nullable restore
#line 34 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
WriteAttributeValue("", 939, item.id, 939, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Resolve</a>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\malai\source\repos\MyBugTracker v2\Pages\Bugs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyBugTracker.Pages.Bugs.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBugTracker.Pages.Bugs.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyBugTracker.Pages.Bugs.IndexModel>)PageContext?.ViewData;
        public MyBugTracker.Pages.Bugs.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
