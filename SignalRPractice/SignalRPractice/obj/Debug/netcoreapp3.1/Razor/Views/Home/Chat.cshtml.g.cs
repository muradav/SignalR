#pragma checksum "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5f21dc2729e47402a286f43334376703822f89f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.view", @"/Views/Home/Chat.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\_ViewImports.cshtml"
using SignalRPractice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\_ViewImports.cshtml"
using SignalRPractice.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f21dc2729e47402a286f43334376703822f89f", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc0f4cc42b60098336409081585db3072aff5fb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
  
    ViewData["Title"] = "Chat";
    var user = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"container display-flex\">\r\n        <div class=\"row\">&nbsp;</div>\r\n      <div class=\"col-6 justify-content-start\">\r\n     <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
             if (User.Identity.IsAuthenticated)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2\">User</div>\r\n            <div class=\"col-4\"><input type=\"text\" id=\"userInput\"");
            BeginWriteAttribute("value", " value=\"", 400, "\"", 427, 1);
#nullable restore
#line 13 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
WriteAttributeValue("", 408, User.Identity.Name, 408, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></div>\r\n");
#nullable restore
#line 14 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
           }
             else
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2\">User</div>\r\n            <div class=\"col-4\"><input type=\"text\" value=\"Bot\" id=\"userInput\"/></div>\r\n");
#nullable restore
#line 19 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-2"">Message</div>
            <div class=""col-4""><input type=""text"" id=""messageInput"" /></div>
        </div>
        <div class=""row"">&nbsp;</div>
        <div class=""row"">
            <div class=""col-6"">
                <input type=""button"" id=""sendButton"" value=""Send Message"" />
            </div>
        </div>
    </div>
    <div class=""col-3"">
");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
         foreach (var chatUser in ViewBag.ChatUsers)
       {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
            if (User.Identity.Name!=chatUser.UserName)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul>\r\n");
#nullable restore
#line 38 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
                 if (chatUser.isOnline)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <b> Offline :");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
                      Write(chatUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    <input type=\"button\" id=\"sendPrivate\" class=\"dropdown-item\" value=\"Send Private Message\" href=\"#\">\r\n");
#nullable restore
#line 42 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <b> Offline :");
#nullable restore
#line 45 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
                            Write(chatUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    <input type=\"button\" id=\"sendPrivate\" class=\"dropdown-item\" value=\"Send Private Message\" href=\"#\">\r\n");
#nullable restore
#line 47 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 49 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
           }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\HP\Desktop\Development\SignalR\SignalRPractice\SignalRPractice\Views\Home\Chat.cshtml"
            
       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
      </div>

    <div class=""row"">
        <div class=""col-12"">
            <hr />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-6"">
            <ul id=""messagesList"">
            </ul>
        </div>
    </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5f21dc2729e47402a286f43334376703822f89f8876", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js""></script>
        <script>
         var connection = new signalR.HubConnectionBuilder().withUrl(""/chat"").build();
         connection.start();
           $(""#sendButton"").click(function(){
             let user=$(""#userInput"").val();
             let message=$(""#messageInput"").val();
             connection.invoke(""SendMessage"",user,message)
         })
         connection.on(""ReceiveMessage"",function(user,message,date){
              let li = `<li>${user} : ${message} ${date}</li>`
            $(""#messagesList"").append(li);
         });
           $(""#sendPrivate"").click(function(){
             let user=$(""#userInput"").val();
             let message=$(""#messageInput"").val();
             connection.invoke(""SendMessagePrivate"",user,message)
           })
         connection.on(""ReceivePrivateMessage"",function(user,message,date){
              let li = `<li>${user} : ${message} ${date}</li>`");
                WriteLiteral("\n            $(\"#messagesList\").append(li);\r\n         });\r\n        \r\n        </script>\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
