#pragma checksum "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3efb42d0516999d3cd155616a754de014678d06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "F:\final project\MVC-Core-Project-master\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\final project\MVC-Core-Project-master\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3efb42d0516999d3cd155616a754de014678d06b", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0acccc60c742d8a86eef1c0cdad0f786bf023898", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral(@"
<div class=""main-container"">
    <div class=""pd-ltr-20"">

        <div class=""card-box mb-30"">
            <h2 class=""h4 pd-20"">Best Selling Products</h2>
            <table class=""data-table table nowrap"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Picture</th>
                        <th>Delete</th>
                        <th class=""datatable-nosort"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 21 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n            <td>");
#nullable restore
#line 24 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 27 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
           Write(item.Picture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n                <i class=\"fa-solid fa-trash-can\">\n                    ");
#nullable restore
#line 30 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { @Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </i>\n            </td>\n             <td>\n                    ");
#nullable restore
#line 34 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { @Id = item.Id, @Name = item.Name,
                    @Description = item.Description, @Picture = item.Picture}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </td>
            <td>
                <div class=""dropdown"">
                    <a class=""btn btn-link font-24 p-0 line-height-1 no-arrow dropdown-toggle"" href=""#"" role=""button"" data-toggle=""dropdown"">
                        <i class=""dw dw-more""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right dropdown-menu-icon-list"">

                        ");
#nullable restore
#line 45 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
                   Write(Html.ActionLink("Create", "Create", null, new { @class = "dropdown-item" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <a class=""dropdown-item"" href=""#""><i class=""dw dw-eye""></i> View</a>
                        <a class=""dropdown-item"" href=""#""><i class=""dw dw-edit2""></i> Edit</a>

                        <a class=""dropdown-item"" href=""#""><i class=""dw dw-delete-3""></i> Delete</a>
                    </div>
                </div>
            </td>
        </tr>");
#nullable restore
#line 53 "F:\final project\MVC-Core-Project-master\Admin\Views\Category\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""footer-wrap pd-20 mb-20 card-box"">
            DeskApp - Bootstrap 4 Admin Template By <a href=""https://github.com/dropways"" target=""_blank"">Ankit Hingarajiya</a>
        </div>
    </div>
</div>



");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
