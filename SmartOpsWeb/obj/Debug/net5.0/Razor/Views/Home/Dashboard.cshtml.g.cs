#pragma checksum "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\_ViewImports.cshtml"
using SmartOpsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\_ViewImports.cshtml"
using SmartOpsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daedbf2b44da9a95a6bbb243c5c5aba9c3351f4", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4eee31ecc6e31cdb6d81a86bf0a13560703f555", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartOpsWeb.Models.ViewModel.DashVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TableButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/v2/sweetalert.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/v2/jquery-1.10.2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/v2/sweetalert.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_LayoutTable.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-xl-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n");
#nullable restore
#line 15 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                 if (TempData["alert_user_created_successfully"] != null)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <script type=\"text/javascript\">\r\n                        window.onload = function () {\r\n                            swal(\"Good job!\", \'");
#nullable restore
#line 27 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                          Write(TempData["pesan"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"success\");\r\n                        };\r\n                    </script>\r\n");
#nullable restore
#line 35 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                 if (TempData["alert_user_updated_successfully"] != null)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <script type=\"text/javascript\">\r\n                        window.onload = function () {\r\n                            swal(\"Good job!\", \'");
#nullable restore
#line 63 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                          Write(TempData["alert_user_updated_successfully"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"success\");\r\n                        };\r\n                    </script>\r\n");
#nullable restore
#line 66 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""card mini-stats-wid"">
                    <div class=""card-body"">
                        <div class=""media"">
                            <div class=""media-body"">
                                <p class=""text-muted font-weight-medium"">Users</p>
                                <h4 class=""mb-0"">");
#nullable restore
#line 73 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                            Write(Model.TotalUsersInDB);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            </div>

                            <div class=""mini-stat-icon avatar-sm rounded-circle bg-primary align-self-center"">
                                <span class=""avatar-title"">
                                    <i class=""fas fa-user""></i>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mini-stats-wid"">
                    <div class=""card-body"">
                        <div class=""media"">
                            <div class=""media-body"">
                                <p class=""text-muted font-weight-medium""></p>
                                <h4 class=""mb-0""></h4>
                            </div>

                            <div class=""avatar-sm rounded-circle bg-primary align-self-center mini-stat-icon"">
                                <span class=");
            WriteLiteral(@"""avatar-title rounded-circle bg-primary"">
                                    <i class=""bx bx-archive-in font-size-24""></i>
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mini-stats-wid"">
                    <div class=""card-body"">
                        <div class=""media"">
                            <div class=""media-body"">
                                <p class=""text-muted font-weight-medium""> </p>
                                <h4 class=""mb-0""></h4>
                            </div>

                            <div class=""avatar-sm rounded-circle bg-primary align-self-center mini-stat-icon"">
                                <span class=""avatar-title rounded-circle bg-primary"">
                                    <i class=""bx bx-purchase-tag-alt font-size-24""></i>
                        ");
            WriteLiteral("        </span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end row -->\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n<div");
            BeginWriteAttribute("class", " class=\"", 6478, "\"", 6486, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"vendred\"></div>\r\n");
            WriteLiteral("\r\n    <!-- start page title -->\r\n");
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-6"">

        </div>

        <div class=""col-6 text-right"">
            <div class=""btn-toolbar"">
                <div class=""btn-group focus-btn-group"">

                </div>
                <div class=""btn-group focus-btn-group pull-right"">

                </div>
            </div>
        </div>

        <div class=""col-6"">

        </div>
        <div class=""col-6 text-right"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f411778", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <!-- end page title -->

    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">

                    <div class=""table-rep-plugin"">
                        <div class=""table-responsive mb-0"" data-pattern=""priority-columns"">
                            <table id=""tech-companies-1"" class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th data-priority=""1"">Email</th>
                                        <th data-priority=""3"">PhoneNumber</th>
                                        <th data-priority=""1"" class=""center"">     Action</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 200 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                     foreach (var item in Model.DashBoardUserList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th>");
#nullable restore
#line 203 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 204 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
#nullable restore
#line 205 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
                                           Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                            <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f415272", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 206 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                                        </tr>\r\n");
#nullable restore
#line 208 "C:\Users\oloruntobi.ojumu\source\repos\SmartOpsProject\SmartOpsWeb\Views\Home\Dashboard.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>



                        </div>

                    </div>

                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->
    <!--</div>--> <!-- container-fluid -->
    <!--</div>-->
    <!-- End Page-content -->


    <footer class=""footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <script>document.write(new Date().getFullYear())</script> © SmartOps.
                </div>
                <div class=""col-sm-6"">
                    <div class=""text-sm-right d-none d-sm-block"">
                        Design & Develop by Themesbrand
                    </div>
                </div>
            </div>
        </div>
    </footer>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f418057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f419172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0daedbf2b44da9a95a6bbb243c5c5aba9c3351f420212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartOpsWeb.Models.ViewModel.DashVM> Html { get; private set; }
    }
}
#pragma warning restore 1591