#pragma checksum "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd55db79bc51781c0f06b2af9f29c23437dabe3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd55db79bc51781c0f06b2af9f29c23437dabe3f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad3fcb6d272bb47b1b2a72cef65a347d02ec87af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SWAPI.TASK.WebUI.Models.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Vote for your favorite Star Wars movie!</h1>\r\n</div>\r\n\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 11 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
     foreach (var item in Model.FilmDto.results)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
         using (Html.BeginForm("FilmDetails", "Home", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm  p-2 m-0\">\r\n                        <h5>");
#nullable restore
#line 18 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(x => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <div class=\"col-sm  p-2 m-0\">\r\n                        <button class=\"btn btn-primary\" type=\"submit\">Vote</button>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fd55db79bc51781c0f06b2af9f29c23437dabe3f4986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 22 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.url);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
                                        WriteLiteral(item.url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\wisku\OneDrive\Pulpit\SWAPI.TASK\SWAPI.TASK\SWAPI.TASK.WebUI\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SWAPI.TASK.WebUI.Models.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591