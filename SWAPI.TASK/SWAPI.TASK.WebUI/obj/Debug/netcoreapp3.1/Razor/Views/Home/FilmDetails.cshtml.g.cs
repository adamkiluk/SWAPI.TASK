#pragma checksum "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c7cb66816ec89d63242c0c3505f2b0c01c4981b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FilmDetails), @"mvc.1.0.view", @"/Views/Home/FilmDetails.cshtml")]
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
#line 1 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\_ViewImports.cshtml"
using SWAPI.TASK.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\_ViewImports.cshtml"
using SWAPI.TASK.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c7cb66816ec89d63242c0c3505f2b0c01c4981b", @"/Views/Home/FilmDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3fcb6d272bb47b1b2a72cef65a347d02ec87af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FilmDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWAPI.TASK.WebUI.Models.FilmDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
  
    ViewData["Title"] = "MovieDetails";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
 using (Html.BeginForm("SendVoteValue", "Home", new { Model.FilmDetailsDto.url, Model.SelectedUserVote, Model.FilmDetailsDto.episode_id }, FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>Created: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 13 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>Edited: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 21 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.edited));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>Director: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 29 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.director));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>Producer: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 37 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.producer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>Title: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 45 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>URL: </p>\r\n            </div>\r\n            <div class=\"col-sm  p-2 m-0\">\r\n                <p>");
#nullable restore
#line 53 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
              Write(Html.DisplayFor(x => x.FilmDetailsDto.url));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <h5>How mutch do you love that movie?</h5>\r\n        <div>");
#nullable restore
#line 59 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
        Write(Html.DropDownListFor(m => m.SelectedUserVote, Enumerable.Range(1, 10).Select(i => new SelectListItem { Text = i.ToString(), Value = i.ToString() })));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"col-sm  p-2 m-0\">\r\n        <input type=\"submit\" value=\"Vote\" />\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
 if (Model.FilmReviewsDto.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <h5>Vote history:</h5>
        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Vote rating</th>
                    <th scope=""col"">Date</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 78 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
                 foreach (var item in Model.FilmReviewsDto.Select((value, index) => (value, index)))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 81 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
                                   Write(item.index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 82 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
                       Write(item.value.UserRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 83 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
                       Write(item.value.VoteDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 85 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 89 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\FilmDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWAPI.TASK.WebUI.Models.FilmDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
