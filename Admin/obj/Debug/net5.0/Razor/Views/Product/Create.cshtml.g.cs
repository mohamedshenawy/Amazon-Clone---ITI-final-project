#pragma checksum "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "780964e1de3eba5c382f9dc76c775a93458fbf0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "F:\final project\Amazon Clone - ITI final project\Admin\Views\_ViewImports.cshtml"
using Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\final project\Amazon Clone - ITI final project\Admin\Views\_ViewImports.cshtml"
using Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
using ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"780964e1de3eba5c382f9dc76c775a93458fbf0d", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0acccc60c742d8a86eef1c0cdad0f786bf023898", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Product/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
  
    var settings = new Newtonsoft.Json.JsonSerializerSettings();
    // This tells your serializer that multiple references are okay.
    settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var test =");
#nullable restore
#line 12 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
         Write(Html.Raw( @JsonConvert.SerializeObject(Model.categories.ToList(),settings)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
  //  console.log(test);

    function handleSubmit(event) {
        //console.log(frm);
        event.preventDefault()
        var hidden = document.getElementById(""categoryId"");
        //var formData = new FormData(formElement);
        //formData.forEach((i) => console.log(i));
        //alert(frm[""ParentId""]);
        //const data = new FormData(frm);
        //const value = data.get('email');
        var navs = document.getElementById(""navs"");
        hidden.value = navs.lastChild.id;
        console.log(event.target);
        event.target.submit();
        //const l = document.getElementById(""ParentId"");
        //alert(navs.lastChild.id);
        //alert(""test"");
        //alert(data.get(""ParentId""));
        //data.set(""ParentId"", navs.lastChild.id)
        //frm[""ParentId""].value = navs.lastChild.id;
        //data.append(""ParentId"", navs.lastChild.id);
        //console.log(data);
        //l.value = navs.lastElementChild.id;
    }
    //alert(test[1].Id);
    function ");
            WriteLiteral(@"myfunction(id)
    {
        //alert(id);
      //  console.log(id);
        var navs = document.getElementById(""navs"");

        const l = document.getElementById(""ParentId"");
        const list = document.createElement(""select"");
        list.innerHTML+=`<option disabled>Select</option>`
        list.onchange = ()=>myfunction(list.value);
        //list.addEventListener(""change"", myfunction(this.value));
        var filtered = test.filter(c => c.parentId == id);
        if (filtered.length < 1) {
            if (test.find(i => i.Id == navs.lastElementChild.id)) {
                // alert(""test"");
                if (test.find(i => i.Id == navs.lastElementChild.id).parentId == test.find(i => i.Id == id).parentId) {
                    navs.removeChild(navs.lastChild);
                }
            }
            navs.innerHTML += `<li class=""breadcrumb-item active"" id=""${id}"" aria-current=""page"">${test.find(c => c.Id == id).Name}</li>`;
            return;
        }
        
        fil");
            WriteLiteral(@"tered.map(item =>
        {
            const temp = document.createElement(""option"");
            temp.value = item.Id;
            temp.innerText=item.Name;
            list.appendChild(temp);
        }
        );
        //alert(""test"");
        var cats = document.getElementById(""categories"");
        cats.lastElementChild.setAttribute('disabled', '');
        var parent = test.find(i => i.Id == id);
        if (parent.parentId) {
            list.id = parent.parentId;
        }
        else list.id = -1;
        
        const check = document.getElementById(`${list.id}`);
        console.log(check);
        //alert(list.id);
        //alert(check);
        // if (check != null) {
        if (test.find(i => i.Id == navs.lastElementChild.id)) {
            //alert(""test"");
            if (test.find(i => i.Id == navs.lastElementChild.id).parentId == test.find(i => i.Id == id).parentId) {
              //  alert(""test222222"");
                cats.appendChild(list);
              ");
            WriteLiteral(@" // check.innerHTML = list.innerHTML;
                navs.removeChild(navs.lastChild);
            }
        }
            else {
                cats.appendChild(list);
            }
            //insertAfter(list, l);
            navs.innerHTML += `<li class=""breadcrumb-item active"" id=""${id}"" aria-current=""page"">${test.find(c => c.Id == id).Name}</li>`;
        }

    //function insertAfter(newNode, referenceNode) {
    //    referenceNode.parentNode.insertBefore(newNode, referenceNode.nextSibling);
    //}

</script>

<div class=""main-container"">
    <div class=""pd-ltr-20"">

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780964e1de3eba5c382f9dc76c775a93458fbf0d9843", async() => {
                WriteLiteral("\r\n            <h4>Add Product</h4>\r\n            <hr />\r\n\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 115 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 117 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                ");
#nullable restore
#line 119 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.ValidationMessageFor(i => i.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 123 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Discount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 125 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Discount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 130 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Shipping, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 132 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Shipping, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 137 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 139 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 146 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Stock, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 148 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Stock, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 153 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Brand, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 155 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Brand, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 160 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Description, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 162 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(model => model.Description, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group\"id=\"categories\">\r\n");
                WriteLiteral("\r\n                ");
#nullable restore
#line 183 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.HiddenFor(model => model.categoryId, new { htmlAttributes = new { @id = "hidden" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <select id=\"ParentId\" onchange=\"myfunction(this.value)\" name=\"ParentId\">\r\n");
#nullable restore
#line 185 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
                     foreach (var item in Model.categories)
                    {
                        if (item.parentCategory == null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "780964e1de3eba5c382f9dc76c775a93458fbf0d17147", async() => {
#nullable restore
#line 189 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 189 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
AddHtmlAttributeValue("", 7805, item.Id, 7805, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 190 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>

            </div>
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"" id=""navs"">
                    <li class=""breadcrumb-item"" aria-current=""page"">Selected Category</li>
                </ol>
            </nav>

            <div class=""form-group"">
                ");
#nullable restore
#line 202 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
           Write(Html.LabelFor(model => model.Picture, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 204 "F:\final project\Amazon Clone - ITI final project\Admin\Views\Product\Create.cshtml"
               Write(Html.TextBox("Picture", "", new { @type = "file" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-offset-2 col-md-10\">\r\n                    <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"footer-wrap pd-20 mb-20 card-box\">\r\n            DeskApp - Bootstrap 4 Admin Template By <a href=\"https://github.com/dropways\" target=\"_blank\">Ankit Hingarajiya</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
