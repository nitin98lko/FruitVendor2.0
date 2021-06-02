#pragma checksum "Z:\FruitVendor\FruitVendor_MVC\Views\Admin\AdminIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c41426d9e9722ced9f6884d197565164adb3cac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminIndex), @"mvc.1.0.view", @"/Views/Admin/AdminIndex.cshtml")]
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
#line 1 "Z:\FruitVendor\FruitVendor_MVC\Views\_ViewImports.cshtml"
using FruitVendor_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\FruitVendor\FruitVendor_MVC\Views\_ViewImports.cshtml"
using FruitVendor_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c41426d9e9722ced9f6884d197565164adb3cac", @"/Views/Admin/AdminIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ba67761925c5a194e77e888d46a40e1a527589", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "Z:\FruitVendor\FruitVendor_MVC\Views\Admin\AdminIndex.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c41426d9e9722ced9f6884d197565164adb3cac3223", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            let jwtToken = sessionStorage.getItem(""jwtToken"");
            let userName = sessionStorage.getItem(""userName"");
            console.log(userName);
            console.log(jwtToken);
            $('#userName').html(userName);
            $.ajax({
                type: ""GET"",
                url: 'https://localhost:44329/api/AdminAuthor',
                headers: {
                    Authorization: 'Bearer ' + jwtToken
                },
                dataType: 'json',
                success: function (result, status, xhr) {
                    $(""#IndexPage"").show();
                   // alert(""successful "" + result[0].name);
                    var customersTable = $('#GetAllCustomers');
                    customersTable.empty();
                    $(result).each(function (index, customer) {
        ");
                WriteLiteral(@"                customersTable.append(AddCustomerRow(customer))
                    });

                },
                error: function (xhr, status, error) {
                    $(""#unAuthorised"").show();
                }
            });
        });
        function AddCustomerRow(customer) {
            var row =
                ""<tr><td id='customerId'>"" + customer.id + ""</td>"" +
                ""<td>"" + customer.name + ""</td>"" +
                ""<td>"" + customer.startLocation + ""</td>"" +
                ""<td>"" + customer.endLocation + ""</td>"" +
                ""<td>"" +
                ""<button type='button' "" +
                ""onclick='redirectToFurnitures(this)' "" +
                ""class='btn btn-primary' "" +
                ""data-id='"" + customer.id + ""'>"" +
                ""Buy"" +
                ""</button>"" +
                ""</td></tr>"";
            return row;
        }
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1 class=""text-center"" id=""unAuthorised"" style=""display:none""> you are not authorised to view this page</h1>

<div class=""text-center"" id=""IndexPage"" style=""display:none"">

    <h1 class=""display-4"">Welcome</h1> <h1 id=""userName""></h1>
    <br />
    <table class=""table table-bordered"">
        <tr>
            <th> Id</th>
            <th> Name</th>
            <th>start location</th>
            <th>End Location</th>

        </tr>
        <tbody id=""GetAllCustomers""></tbody>
    </table>




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
