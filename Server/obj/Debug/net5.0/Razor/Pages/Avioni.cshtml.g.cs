#pragma checksum "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5a004e32c19a242a5d80bca7a74e022796610a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Avioni), @"mvc.1.0.razor-page", @"/Pages/Avioni.cshtml")]
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
#line 2 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
using Server.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5a004e32c19a242a5d80bca7a74e022796610a3", @"/Pages/Avioni.cshtml")]
    public class Pages_Avioni : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
  
    ViewData["Title"] = "Lista aviona";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"Styles/Style.css\">\r\n");
            }
            );
            WriteLiteral("<a class=\"novi\" href=\"./CreateAvion\">Kreiraj novi avion</a>\r\n<table>\r\n    <tr>\r\n        <th>Avion</th>\r\n        \r\n        <th>X</th>\r\n        <th>Y</th>\r\n        <th>Edit</th>\r\n        <th>Delete</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
     foreach (var v in Model.Avioni)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
           Write(v.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          \r\n            <td>");
#nullable restore
#line 26 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
           Write(v.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
           Write(v.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 583, "\"", 610, 2);
            WriteAttributeValue("", 590, "UpdateAvion?id=", 590, 15, true);
#nullable restore
#line 28 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
WriteAttributeValue("", 605, v.ID, 605, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 672, 2);
            WriteAttributeValue("", 652, "DeleteAvion?id=", 652, 15, true);
#nullable restore
#line 29 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
WriteAttributeValue("", 667, v.ID, 667, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Milos\Desktop\kibo\Server\Pages\Avioni.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AvioniModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AvioniModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AvioniModel>)PageContext?.ViewData;
        public AvioniModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
