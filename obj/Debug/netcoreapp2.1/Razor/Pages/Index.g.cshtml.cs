#pragma checksum "/home/unarix/Documentos/code/uVirtualQueues/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd18526f6f1c904962d64734a5a401785284f3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(uVirtualQueues.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(uVirtualQueues.Pages.Pages_Index), null)]
namespace uVirtualQueues.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/unarix/Documentos/code/uVirtualQueues/Pages/_ViewImports.cshtml"
using uVirtualQueues;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd18526f6f1c904962d64734a5a401785284f3f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33c4fc67b5c57ddf6d316890d6bdd50c58706f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/unarix/Documentos/code/uVirtualQueues/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(92, 42, true);
                WriteLiteral("\r\n    <script src=\"js/main.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(137, 1996, true);
            WriteLiteral(@"
<div class=""py-5 text-center"">
    <h2>Habilite las notificaciones</h2>
</div>

  
<p>Welcome to the push messaging codelab. The button below needs to be fixed to support subscribing to push.</p>
<p>
    <button disabled class=""js-push-btn mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect"">
    Enable Push Messaging
    </button>
</p>
<section class=""subscription-details js-subscription-details is-invisible"">
    <p>Once you've subscribed your user, you'd send their subscription to your
    server to store in a database so that when you want to send a message
    you can lookup the subscription and send a message to it.</p>
    <p>To simplify things for this code lab copy the following details
    into the <a href=""https://web-push-codelab.glitch.me/"">Push Companion
    Site</a> and it'll send a push message for you, using the application
    server keys on the site - so make sure they match.</p>
    <pre><code class=""js-subscription-json""></code></pre>
</section>

    <");
            WriteLiteral(@"button id=""prueba"" onclick=""probar();"" >Probar</button>


<script>


function probar()
{
    var pushEndpoint = ""eC8kA5lfrjc:APA91bHHHh3ikNWPa-614pz7FbWdPvCTn01OvkNuas6m-ilwP-U_VPHLd5QPsjL8W5G8gLquoTJd-jUVRDOziyXvxXoeY8ua2sRvt6GnG8WLpFdOkk7SI8_AxFZnlug4t9FOU7S-XjzH"";
    var p256dh = ""BAGGIn3MC7LZRCFKuRRSjA28bwQRP7mO_9AEr2l7ety-dtSn7Fcw11-aZu5UCOE0C2gVXVEaWkFLu7PWCR1ufGI"";
    var auth = ""VKMl5N1lJomQreFUjKlzeQ"";

    var settings = {
            ""url"": ""https://localhost:5001/api/webpush?pushEndpoint="" + pushEndpoint + ""&p256dh="" + p256dh + ""&auth="" + auth,
            ""method"": ""POST"",
            ""timeout"": 0,
            ""headers"": {
                    ""Content-Type"": ""application/json""
            },
            ""data"": JSON.stringify({
                    query: """",
                    variables: {}
            })
    };

    $.ajax(settings).done(function (response) {
            console.log(response);
    });
}
</script>");
            EndContext();
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
