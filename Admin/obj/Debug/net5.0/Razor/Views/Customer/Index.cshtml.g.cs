#pragma checksum "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac454edac9cfd0442e0ec9d80f48efdf402c53aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac454edac9cfd0442e0ec9d80f48efdf402c53aa", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c13ece3d0cfbb1fc0f84962af70815be6a0e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""main-container"">
    <div class=""pd-ltr-20"">

        <div class=""card-box mb-30"">
            <h2 class=""h4 pd-20"">Best Selling Products</h2>
            <table class=""data-table table nowrap"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Phone Number</th>
                        <th>Gender</th>
                        <th>Delete</th>
                        <th class=""datatable-nosort"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 21 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>");
#nullable restore
#line 24 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <i class=\"fa-solid fa-trash-can\">\r\n                    ");
#nullable restore
#line 30 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { @Id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </i>\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new
                {
                    @Id = item.Id,
                    @Name = item.Name,
                @Email = item.Email,
                    @PhoneNumber = item.PhoneNumber,
                    @Gender = item.Gender,
                    @City = item.City,
                @PostalCode = item.PostalCode,
                    @Street = item.Street,
                    @profileID = item.profileID
                }));

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
#line 55 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
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
#line 63 "F:\ITI-three months\مشروع التخرج\Amazon-Clone---ITI-final-project\Admin\Views\Customer\Index.cshtml"
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
