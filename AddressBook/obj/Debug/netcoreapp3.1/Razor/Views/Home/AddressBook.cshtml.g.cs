#pragma checksum "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "102b932221b9e2693c82babb3e494b10f8e6455b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddressBook), @"mvc.1.0.view", @"/Views/Home/AddressBook.cshtml")]
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
#line 1 "C:\Viren\AddressBookWebApp\AddressBook\Views\_ViewImports.cshtml"
using AddressBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Viren\AddressBookWebApp\AddressBook\Views\_ViewImports.cshtml"
using AddressBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"102b932221b9e2693c82babb3e494b10f8e6455b", @"/Views/Home/AddressBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83d3ddf66f2da5e1dcb22ce082d3eb0d5342091", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddressBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddressBook.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
   ViewData["Title"] = "Address Book";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
  
    var data = (List<User>)ViewData["Message"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n\r\n            <div class=\"list-group\">\r\n                <h5 class=\"list-group-item list-group-item-action active\">Contact List</h5>\r\n\r\n");
#nullable restore
#line 17 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                 foreach (var user in data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a href=\"#\" class=\"list-group-item list-group-item-action\">\r\n                        <h6><b>");
#nullable restore
#line 20 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                          Write(user.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                                          Write(user.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h6>\r\n                        <small>");
#nullable restore
#line 21 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                          Write(user.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />");
#nullable restore
#line 21 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                                                 Write(user.EmailId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 21 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                                                                Write(user.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
#nullable restore
#line 21 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                                                                                   Write(user.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </a>\r\n");
#nullable restore
#line 23 "C:\Viren\AddressBookWebApp\AddressBook\Views\Home\AddressBook.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddressBook.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
